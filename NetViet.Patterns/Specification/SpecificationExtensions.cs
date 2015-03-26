using System.Collections.Generic;

namespace NetViet.Patterns.Specification
{
    public static class SpecificationExtensions
    {
        public static ISpecification<T> AndWith<T>(this ISpecification<T> specification, ISpecification<T> otherSpecification)
        {
            var specifications = new List<ISpecification<T>>
                {
                    specification,
                    otherSpecification
                };
            return new AndSpecification<T>(specifications);
        }

        public static ISpecification<T> OrWith<T>(this ISpecification<T> specification, ISpecification<T> otherSpecification)
        {
            var specifications = new List<ISpecification<T>>
                {
                    specification,
                    otherSpecification
                };
            return new OrSpecification<T>(specifications);
        }

        public static ISpecification<T> NotWith<T>(this ISpecification<T> specification, ISpecification<T> otherSpecification)
        {
            return AndWith(specification, new NotSpecification<T>(otherSpecification));
        }
    }
}
