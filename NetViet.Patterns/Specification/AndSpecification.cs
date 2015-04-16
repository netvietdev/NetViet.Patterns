using System.Linq;

namespace Rabbit.Patterns.Specification
{
    public class AndSpecification<T> : GroupSpecification<T>
    {
        public AndSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
            : base(leftSpecification, rightSpecification)
        {
        }

        public AndSpecification(params ISpecification<T>[] specifications)
            : base(specifications)
        {
        }

        public override bool IsSatisfiedBy(T @object)
        {
            return Specifications.All(s => s.IsSatisfiedBy(@object));
        }
    }
}
