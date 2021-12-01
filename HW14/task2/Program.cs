// See https://aka.ms/new-console-template for more information
using System.Collections;
using task2;



DateTimeQueue dateTimeQueue = new DateTimeQueue();
dateTimeQueue.Enqueue(DateTime.Now.AddDays(1));
dateTimeQueue.Enqueue(DateTime.Now.AddDays(2));
dateTimeQueue.Enqueue(DateTime.Now.AddDays(3));
dateTimeQueue.Enqueue(DateTime.Now.AddDays(4));

Console.WriteLine(dateTimeQueue.Dequeue());
Console.WriteLine(dateTimeQueue.Dequeue());
Console.WriteLine(dateTimeQueue.Dequeue());
Console.WriteLine(dateTimeQueue.Peek());

ObjectQueue obi = new ObjectQueue ();

obi.Enqueue ( "seven");
obi.Enqueue("six");
obi.Enqueue("ten");

Console.WriteLine(obi.Dequeue());
Console.WriteLine(obi.Dequeue());
Console.WriteLine(obi.Peek());
Console.WriteLine( obi.Dequeue());

CustomQueue<string> queue= new CustomQueue<string>();

queue.Enqueue("a");
queue.Enqueue("b");
queue.Enqueue("c");

Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());

