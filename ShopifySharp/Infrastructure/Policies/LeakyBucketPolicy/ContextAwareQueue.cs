using System;
using System.Collections.Generic;

namespace ShopifySharp;

internal class ContextAwareQueue<T>
{
    private Queue<T> _BackgroundQueue { get; set; }= new Queue<T>();

    private Queue<T> _ForegroundQueue { get; set;} = new Queue<T>();

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

    /// Removes the item and updates the queue.
    public void RemoveAndUpdateQueue(T itemToRemove)
    {
        if (_ForegroundQueue.Contains(itemToRemove))
        {
            _ForegroundQueue = CopyQueueExcludingItem(_ForegroundQueue, itemToRemove);
            return;
        }

        if (_BackgroundQueue.Contains(itemToRemove))
        {
            _BackgroundQueue = CopyQueueExcludingItem(_BackgroundQueue, itemToRemove);
        }
    }

    /// Copies the items in <paramref name="existingQueue"/> to a new queue, excluding <paramref name="itemToExclude"/>.
    private static Queue<T> CopyQueueExcludingItem(Queue<T> existingQueue, T itemToExclude)
    {
        var newQueue = new Queue<T>();

        while (existingQueue.Count > 0)
        {
            var itemToAdd = existingQueue.Dequeue();
            if (!itemToAdd.Equals(itemToExclude))
            {
                newQueue.Enqueue(itemToAdd);
            }
        }

        return newQueue;
    }
}
