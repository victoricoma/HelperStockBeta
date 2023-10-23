using HelperStockBeta.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Entities
{
    public sealed class Products : Entity
    {
        public string Name { get;private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public int Stock {  get; private set; }

        public string Image {  get; private set; }

        public Products(string name, string description, decimal price, int stock, string image)
        {
            ValidationDomain(name, description, price, stock, image);
        }

        public Products(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0,
                "Invalid negative values for id");
            ValidationDomain(name, description, price, stock, image);
        }

        public void  Update(int id, string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidationDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }

        private void ValidationDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required");
            DomainExceptionValidation.When(name.Length < 3,
                "Invalid short names, minimum 3 characters");
            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
                            "Invalid description. Description is required");
            DomainExceptionValidation.When(description.Length < 5,
                "Invalid short descriptions, minimum 3 characters");
            DomainExceptionValidation.When(price < 0,
                "Invalid negative values for price");
            DomainExceptionValidation.When(stock < 0,
                            "Invalid negative values for stock");
            DomainExceptionValidation.When(description.Length > 250,
             "Invalid short url, maximum 250 characters");

            Name = name; 
            Description = description; 
            Price = price; 
            Stock = stock; 
            Image = image;
        }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
