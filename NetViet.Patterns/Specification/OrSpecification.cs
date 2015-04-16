using System.Linq;

namespace Rabbit.Patterns.Specification
{
    public class OrSpecification<T> : GroupSpecification<T>
    {
        public OrSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
            : base(leftSpecification, rightSpecification)
        {
        }

        public OrSpecification(params ISpecification<T>[] specifications)
            : base(specifications)
        {
        }

        public override bool IsSatisfiedBy(T @object)
        {
            return Specifications.Any(spec => spec.IsSatisfiedBy(@object));
        }
    }
}
