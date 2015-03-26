using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetViet.Patterns.Specification;

namespace NetViet.Patterns.Tests.Specification
{
    [TestClass]
    public class SpecificationTest
    {
        public class NegativeNumberSpecification : ISpecification<int>
        {
            public bool IsSatisfiedBy(int @object)
            {
                return @object < 0;
            }
        }

        public class HasTwoDigitsSpecification : ISpecification<int>
        {
            public bool IsSatisfiedBy(int @object)
            {
                return Math.Abs(@object) < 100;
            }
        }

        [TestMethod]
        public void AndSpecificationMustValidateAllSpecifications()
        {
            // Arrange
            var spec = new NegativeNumberSpecification().AndWith(new HasTwoDigitsSpecification());

            // Act
            var isSatisfied = spec.IsSatisfiedBy(-110);

            // Assert
            Assert.IsFalse(isSatisfied);
        }
    }
}
