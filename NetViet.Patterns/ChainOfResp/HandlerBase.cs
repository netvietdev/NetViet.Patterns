using System;
using Rabbit.Patterns.Specification;

namespace Rabbit.Patterns.ChainOfResp
{
    public abstract class HandlerBase<T> : IHandler<T>
    {
        private readonly Action<T> _action;
        private readonly ISpecification<T> _specification;
        private IHandler<T> _successor;

        protected HandlerBase(Action<T> action)
            : this(action, new YesSpecification<T>())
        {
        }

        protected HandlerBase(Action<T> action, ISpecification<T> specification)
        {
            _action = action;
            _specification = specification;
        }

        public void HandleRequest(T @object)
        {
            if (CanHandle(@object))
            {
                _action(@object);
            }

            if (_successor != null)
            {
                _successor.HandleRequest(@object);
            }
        }

        public bool CanHandle(T @object)
        {
            return _specification.IsSatisfiedBy(@object);
        }

        public void SetSuccessor(IHandler<T> successor)
        {
            _successor = successor;
        }
    }
}
