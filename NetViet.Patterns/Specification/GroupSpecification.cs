using System.Collections.Generic;

namespace Rabbit.Patterns.Specification
{
    public abstract class GroupSpecification<T> : ISpecification<T>
    {
        protected readonly IEnumerable<ISpecification<T>> Specifications;

        protected GroupSpecification(params ISpecification<T>[] specifications)
        {
            Specifications = specifications;
        }

        public abstract bool IsSatisfiedBy(T @object);
    }
}
