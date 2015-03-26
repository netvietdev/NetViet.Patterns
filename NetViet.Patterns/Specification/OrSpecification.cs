using System.Collections.Generic;
using System.Linq;

namespace NetViet.Patterns.Specification
{
    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly IEnumerable<ISpecification<T>> _specifications;

        public OrSpecification(IEnumerable<ISpecification<T>> specifications)
        {
            _specifications = specifications;
        }

        public bool IsSatisfiedBy(T @object)
        {
            return _specifications.Any(spec => spec.IsSatisfiedBy(@object));
        }
    }
}
