using System.Collections.Generic;

namespace NetViet.Patterns.Specification
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
