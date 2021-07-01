using AutoMapperAppPresents.Models;
using System.Collections.Generic;

namespace AutoMapperAppPresents
{
    public static class AppRepository
    {
        public static User GetUser()
        {
            var products = new List<Product>
            {
                new Product{Id = 1, Title = "Shirt", Cost = 2500, Description = "Good thing for good price"},
                new Product{Id = 2, Title = "Hat", Cost = 800, Description = "Summer device for summer weather"},
                new Product{Id = 3, Title = "Shoes", Cost = 2500, Description = "Every mab should have this great pair of shoes"},
                new Product{Id = 4, Title = "Tie", Cost = 2500, Description = "Holiday attribute"},

            };

            var user = new User
            {
                Id = 1,
                Name = "Aleksei",
                Surname = "Bondarenko",
                Password = "1234",
                Email = "delchew@mail.ru",
                Products = products
            };
            return user;
        }
    }
}
