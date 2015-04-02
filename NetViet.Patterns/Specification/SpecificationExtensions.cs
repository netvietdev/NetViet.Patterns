namespace NetViet.Patterns.Specification
{
    public static class SpecificationExtensions
    {
        public static ISpecification<T> AndWith<T>(this ISpecification<T> specification, ISpecification<T> otherSpecification)
        {
            return new AndSpecification<T>(specification, otherSpecification);
        }

        public static ISpecification<T> OrWith<T>(this ISpecification<T> specification, ISpecification<T> otherSpecification)
        {
            return new OrSpecification<T>(specification, otherSpecification);
        }

        public static ISpecification<T> NotWith<T>(this ISpecification<T> specification, ISpecification<T> otherSpecification)
        {
            return AndWith(specification, new NotSpecification<T>(otherSpecification));
        }
    }
}
