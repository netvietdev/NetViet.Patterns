namespace Rabbit.Patterns.Specification
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T @object);
    }
}
