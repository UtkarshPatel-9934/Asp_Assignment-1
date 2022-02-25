using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UtkarshSandalsStore.Data;
using System;
using System.Linq;

namespace UtkarshSandalsStore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UtkarshSandalsStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UtkarshSandalsStoreContext>>()))
            {
                // Look for any Sandals.
                if (context.Sandal.Any())
                {
                    return;   // DB has been seeded
                }
                // Added my data for the product. there are 10 unique data I added here...
                context.Sandal.AddRange(
                    new Sandal
                    {
                        ArtNumber = 133,
                        CompanyName = "Bata",
                        Colour = "Blue",
                        Material = "Leather",
                        Size = 7,
                        Price = 179,
                        Ratings = 5
                    },

                    new Sandal
                    {
                        ArtNumber = 103,
                        CompanyName = "Nike",
                        Colour = "Olive",
                        Material = "Rubber",
                        Size = 9,
                        Price = 144,
                        Ratings = 3
                    },

                    new Sandal
                    {
                        ArtNumber = 111,
                        CompanyName = "Woodland",
                        Colour = "Red",
                        Material = "Leather",
                        Size = 5,
                        Price = 88,
                        Ratings = 3
                    },

                     new Sandal
                     {
                         ArtNumber = 77,
                         CompanyName = "Win",
                         Colour = "Black",
                         Material = "Rubber",
                         Size = 8,
                         Price = 79,
                         Ratings = 5
                     },
                      new Sandal
                      {
                          ArtNumber = 144,
                          CompanyName = "Woods",
                          Colour = "Pink",
                          Material = "Leather",
                          Size = 10,
                          Price = 99,
                          Ratings = 4
                      },
                       new Sandal
                       {
                           ArtNumber = 93,
                           CompanyName = "PU",
                           Colour = "Violet",
                           Material = "Leather",
                           Size = 7,
                           Price = 80,
                           Ratings = 5
                       },
                        new Sandal
                        {
                            ArtNumber = 83,
                            CompanyName = "Bata",
                            Colour = "Pink",
                            Material = "Rubber",
                            Size = 7,
                            Price = 79,
                            Ratings = 2
                        },
                         new Sandal
                         {
                             ArtNumber = 77,
                             CompanyName = "Addidas",
                             Colour = "Grey",
                             Material = "Rubber",
                             Size = 7,
                             Price = 111,
                             Ratings = 3
                         },
                          new Sandal
                          {
                              ArtNumber = 333,
                              CompanyName = "Ved",
                              Colour = "Green",
                              Material = "Rubber",
                              Size = 7,
                              Price = 70,
                              Ratings = 4
                          },
                           new Sandal
                           {
                               ArtNumber = 144,
                               CompanyName = "YSL",
                               Colour = "Orange",
                               Material = "Leather",
                               Size = 9,
                               Price = 99,
                               Ratings = 3
                           }
                );
                context.SaveChanges();
            }
        }
    }
}