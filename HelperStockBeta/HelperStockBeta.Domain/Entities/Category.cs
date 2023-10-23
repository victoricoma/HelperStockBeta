using HelperStockBeta.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required!");
            DomainExceptionValidation.When(name.Length < 3,
                "Name is minimum 3 charecters!");
            Name = name;
        }

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0,
                "Identification is positive values!");
            Id = id;
            ValidateDomain(name);
        }

        public void Update(string name)
        {
            ValidateDomain(name);
        }

        public ICollection<Products> Products { get; set; }
    }
}
