using System.Collections.Generic;
using System.Linq;

namespace NetViet.Patterns.Specification
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly IEnumerable<ISpecification<T>> _specifications;

        public AndSpecification(IEnumerable<ISpecification<T>> specifications)
        {
            _specifications = specifications;
        }

        public bool IsSatisfiedBy(T @object)
        {
            return _specifications.All(spec => spec.IsSatisfiedBy(@object));
        }
    }
}
