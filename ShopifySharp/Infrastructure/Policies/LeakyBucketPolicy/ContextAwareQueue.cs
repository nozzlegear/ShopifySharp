using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    internal class ContextAwareQueue<T>
    {
        private readonly Queue<T> _BackgroundQueue = new Queue<T>();

        private readonly Queue<T> _ForegroundQueue = new Queue<T>();

        private readonly Func<RequestContext> _getContext;

        public int Count => _BackgroundQueue.Count + _ForegroundQueue.Count;

        public ContextAwareQueue(Func<RequestContext> getContext)
        {
            _getContext = getContext;
        }

        public void Enqueue(T i)
        {
            (_getContext() == RequestContext.Background ? _BackgroundQueue : _ForegroundQueue).Enqueue(i);
        }

        public T Peek() => _ForegroundQueue.Count > 0 ? _ForegroundQueue.Peek() : _BackgroundQueue.Peek();

        public T Dequeue() => _ForegroundQueue.Count > 0 ? _ForegroundQueue.Dequeue() : _BackgroundQueue.Dequeue();
    }
}
