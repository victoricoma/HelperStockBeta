using FluentAssertions;
using HelperStockBeta.Domain.Entities;

namespace HelperStockBeta.Domain.Tests
{
    public class CategoryUnitTestBase
    {
        [Fact(DisplayName = "Create category with valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName = "Id parameter negative error")]
        public void CreateCategory_NegativeIdValue_ResultObjectValidState()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should()
                .Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Identification is positive values!");
        }
    }
}