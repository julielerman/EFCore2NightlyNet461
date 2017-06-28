
using Data.Nightly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new SamuraiContext())
            {
                //context.Database.EnsureCreated();
                //Seed(context);
                var samurais = context.Samurais.ToList();
                Console.WriteLine(samurais.Count());
            }
        }
        private static void Seed(SamuraiContext context)
        {
            if (context.Samurais.Any())
            {
                return;
            }
            var samurai = new Samurai
            {
                Name = "Kambei Shimada",
                Quotes = new List<Quote>
                               {
                                 new Quote {Text = "I've come to save you"}
                               }
            };
            var samurai2 = new Samurai
            {
                Name = "Kyūzō",
                Quotes = new List<Quote> {
          new Quote {Text = "Watch out for my sharp sword!"},
          new Quote {Text="I told you to watch out for the sharp sword! Oh well!" }
        }
            };
            var samurai3 = new Samurai { Name = "Shichirōji " };
            samurai3.SecretIdentity = new SecretIdentity { RealName = "Julie" };

            context.Samurais.AddRange(samurai, samurai2, samurai3);

            context.SaveChanges();
        }
    }
}
