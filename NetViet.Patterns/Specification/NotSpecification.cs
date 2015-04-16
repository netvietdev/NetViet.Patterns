namespace Rabbit.Patterns.Specification
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _specification;

        public NotSpecification(ISpecification<T> specification)
        {
            _specification = specification;
        }

        public bool IsSatisfiedBy(T @object)
        {
            return _specification.IsSatisfiedBy(@object) == false;
        }
    }
}
