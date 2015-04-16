namespace Rabbit.Patterns.ChainOfResp
{
    public interface IHandler<T>
    {
        void HandleRequest(T @object);

        bool CanHandle(T @object);

        void SetSuccessor(IHandler<T> successor);
    }
}
