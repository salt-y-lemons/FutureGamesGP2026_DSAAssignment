using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class GenericQueue<Type> {

    [SerializeField] private List<Type> queue = new();

    public void Enqueue(Type InElement) {
        queue.Add(InElement);
    }

    public Type Peek() {
        if (queue.Count == 0)
            throw new Exception("The queue is empty, cannot see peak.");

        return queue[0];
    }

    public Type Dequeue() {
        if(queue.Count == 0)
            throw new Exception("The queue is empty, cannot dequeue element.");

        Type topOfQueue = queue[0];
        queue.RemoveAt(0);
        return topOfQueue;
    }

    public void Clear() => queue.Clear(); 
}

