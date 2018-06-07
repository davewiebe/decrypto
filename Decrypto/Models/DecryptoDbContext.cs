using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Decrypto.Models
{
    public class DecryptoDbContext : DbContext
    {
        public DecryptoDbContext(): base("DecryptoConnectionString")
        {
            Database.SetInitializer(new DecryptoDbContextSeedInitializer());
        }

        public DbSet<GameRound> GameRounds { get; set; }
        public DbSet<Clue> Clues { get; set; }
    }


    public class DecryptoDbContextSeedInitializer : DropCreateDatabaseIfModelChanges<DecryptoDbContext>
    {
        public override void InitializeDatabase(DecryptoDbContext context)
        {
        //    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
        //    , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }

        protected override void Seed(DecryptoDbContext context)
        {
            Clue clue1 = new Clue { Word = 1, Hint = "Body", Guess = 1 };
            Clue clue2 = new Clue { Word = 2, Hint = "Stream", Guess = 2 };
            Clue clue3 = new Clue { Word = 3, Hint = "Luggage", Guess = 3 };
            GameRound gr = new GameRound { Clue1 = clue1, Clue2 = clue2, Clue3 = clue3 };
            context.Clues.Add(clue1);
            context.Clues.Add(clue2);
            context.Clues.Add(clue3);
            context.GameRounds.Add(gr);
            context.SaveChanges();
        }
    }
}
