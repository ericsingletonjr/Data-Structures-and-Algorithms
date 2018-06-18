# Implement A Stack and A Queue

Both a stack and a queue are similar to linked lists in that they both are implemented with nodes that consist of a value and a reference that is either pointed to the next node or if not, is null.

The difference lies in how they are using these references and the order in which operations happen. A stack follows a Last In, First Out (LIFO) principle whereas a queue follows a First In, First Out (FIFO) principle.

Uses for Stacks and Queues:
* They fundamentally provide an order to accessing your data. This can enforce specific patterns that you as a developer want
* The time is always O(1) since we are following a specific guideline so this creates faster actions for larger data

## Challenge
After learning about the concept of stacks and queues, implement the following functionality.
* Stack - 
  * Push() - Method to add a node to the top of the Stack
  * Pop() - Method to remove and return the node from the top of the Stack
  * Peek() - Method that always returns the top of the Stack
* Queue -
  * Enqueue() - Method that adds a node to the queue
  * Dequeue() - Method that removes and returns node at the front of the Queue
  * Peek() - Method that always returns the Front of the queue

Unit tests are provided with this challenge
***
## Visual
![Stack and Queue whiteboard image](../../assets/stack_queue.jpg)