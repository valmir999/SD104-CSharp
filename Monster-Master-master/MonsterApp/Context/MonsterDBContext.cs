using Microsoft.EntityFrameworkCore;
using System;

namespace MonsterApp.Context
{
    public class MonsterDBContext : DbContext
    {
        public MonsterDBContext(DbContextOptions options) :  base(options)
        {
        }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MonsterType> MonsterTypes { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<UserMonsterCollection> UserMonsterCollections { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<UserType>().HasData(
                new UserType() { UserTypeId = 1, TypeName = "Admin"},
                new UserType() { UserTypeId = 2, TypeName = "User"}
                );

            modelBuilder.Entity<MonsterType>().HasData(
                new MonsterType() { MonsterTypeId = 1, TypeName = "Generation I" },
                new MonsterType() { MonsterTypeId = 2, TypeName = "Generation II" },
                new MonsterType() { MonsterTypeId = 3, TypeName = "Generation III" },
                new MonsterType() { MonsterTypeId = 4, TypeName = "Generation IV" }
                );

            modelBuilder.Entity<User>().HasData(
               new User() { UserId = 1, FirstName = "Mandar", LastName = "Ambre", EmailAddress = "ambremandar@gmail.com", Password = "test123", Gold=1,DateAccountCreated= DateTime.Now },
               new User() { UserId = 2, FirstName = "Steve", LastName = "Rossiter", EmailAddress = "steve.rossiter@ancoraeducation.com", Password = "test123", Gold = 1, DateAccountCreated = DateTime.Now }

               );

            modelBuilder.Entity<Monster>().HasData(
               new Monster() { MonsterId = 1, Name = "Bulbasaur",Attack=0,Defense=0,Health=5,Level=1 },
               new Monster() { MonsterId = 2, Name = "Pichu", Attack = 0, Defense = 0, Health = 5, Level = 1 }
               );
        }
    }
}
