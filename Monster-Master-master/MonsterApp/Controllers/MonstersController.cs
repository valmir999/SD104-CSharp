using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MonsterApp.Context;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace MonsterApp.Controllers
{
    public class MonstersController : Controller
    {
        private readonly MonsterDBContext _context;

        public MonstersController(MonsterDBContext context)
        {
            _context = context;
        }

        // GET: Collection of Monsters for a User
        public async Task<IActionResult> UserMonsters(int id)
        {
            var userMonsterCollections = await _context.UserMonsterCollections.Include(u => u.User).Include(m => m.Monster).Where(um => um.User.UserId == id).ToListAsync();

            List<Monster> monsters = userMonsterCollections.Select(um => um.Monster).ToList();

            return View(monsters);
        }

        //GET: All Monsters
        public async Task<IActionResult> Index()
        {
           return View(await _context.Monsters.ToListAsync());
        }

        // GET: Monsters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monsters
                .FirstOrDefaultAsync(m => m.MonsterId == id);
            if (monster == null)
            {
                return NotFound();
            }

            return View(monster);
        }

        // GET: Monsters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monsters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MonsterId,Name,Health,Attack,Defense,Level")] Monster monster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monster);
        }

        // GET: Monsters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monsters.FindAsync(id);
            if (monster == null)
            {
                return NotFound();
            }
            return View(monster);
        }

        // POST: Monsters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MonsterId,Name,Health,Attack,Defense,Level")] Monster monster)
        {
            if (id != monster.MonsterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonsterExists(monster.MonsterId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = id });
            }
            return View(monster);
        }

        public async Task<IActionResult> Purchase(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userID = Convert.ToInt32(HttpContext.Session.GetString("UserID"));

            var userMonster = _context.UserMonsterCollections.Where(um => um.User.UserId == userID && um.Monster.MonsterId == id);

            ViewBag.AlreadyPurchased = false;
            if (userMonster.Any())
            {
                ViewBag.AlreadyPurchased = true;
            }

            var user = _context.Users.Where(u => u.UserId == userID).FirstOrDefault();
            ViewBag.GoldCoins = user.Gold;

            var monster = await _context.Monsters.FindAsync(id);
            if (monster == null)
            {
                return NotFound();
            }
            return View(monster);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Purchase(int id, [Bind("MonsterId,Name,Health,Attack,Defense,Level")] Monster monster)
        {
            if (id != monster.MonsterId)
            {
                return NotFound();
            }
            
            try
            {
                var userID = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
                var loggedInUser = _context.Users.FirstOrDefault(u => u.UserId == userID);
                var selectedMonster = _context.Monsters.FirstOrDefault(u => u.MonsterId == id);
                var userMonster = new UserMonsterCollection() { Monster = selectedMonster, User = loggedInUser };

                // Use 2 Gold coins to buy a Monster
                loggedInUser.Gold -= 2;
                _context.Update(loggedInUser);

                _context.Add(userMonster);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonsterExists(monster.MonsterId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index), new { id = id });            
        }

        // GET: Monsters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monster = await _context.Monsters
                .FirstOrDefaultAsync(m => m.MonsterId == id);
            if (monster == null)
            {
                return NotFound();
            }

            return View(monster);
        }

        // POST: Monsters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monster = await _context.Monsters.FindAsync(id);
            _context.Monsters.Remove(monster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonsterExists(int id)
        {
            return _context.Monsters.Any(e => e.MonsterId == id);
        }

        // GET: Monsters
        // userid
        public async Task<IActionResult> Train(int id)
        {
            var userMonsterCollections = _context.UserMonsterCollections.Include(u => u.User).Include(m => m.Monster).Where(um => um.User.UserId == id).ToList();

            List<Monster> monsters = userMonsterCollections.Select(um => um.Monster).ToList();

            return View(monsters);
        }

        // Attack
        // monsterid
        public async Task<IActionResult> Attack(int id)
        {
            Random r = new Random();           
            var monster = await _context.Monsters.FirstOrDefaultAsync(m=>m.MonsterId==id);
            monster.Attack++;
            monster.Health = Enumerable.Range(monster.Health, 100).OrderBy(x => Guid.NewGuid()).Take(10).FirstOrDefault();  //r.Next(monster.Health, 1000);

            var newLevel = monster.Health/100;

            if(newLevel>monster.Level)
            {
                //User earns a Gold coin
                AddGoldToUser();
                TempData["EarnedNewGold"] = "true";
            }
            monster.Level = newLevel;

            _context.Update(monster);
            var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            await _context.SaveChangesAsync();
            return RedirectToAction("Train","Monsters", new { id = userid });
        }

        public async Task<IActionResult> Defense(int id)
        {
            Random r = new Random();
            var monster = await _context.Monsters.FirstOrDefaultAsync(m => m.MonsterId == id);
            monster.Defense++;
            monster.Health = r.Next(0, monster.Health);

            var newLevel = monster.Health / 100;
            monster.Level = newLevel;

            _context.Update(monster);
            var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            await _context.SaveChangesAsync();
            return RedirectToAction("Train", "Monsters", new { id = userid });
        }

        private void AddGoldToUser()
        {
            var userID = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            var loggedInUser = _context.Users.FirstOrDefault(u => u.UserId == userID);
            loggedInUser.Gold++;

            _context.Update(loggedInUser);
            _context.SaveChanges();
        }
    }
}
