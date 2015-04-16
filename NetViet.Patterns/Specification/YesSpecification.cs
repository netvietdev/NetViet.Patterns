namespace Rabbit.Patterns.Specification
{
    public sealed class YesSpecification<T> : ISpecification<T>
    {
        public bool IsSatisfiedBy(T @object)
        {
            return true;
        }
    }
}
