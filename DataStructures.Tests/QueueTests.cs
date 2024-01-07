using Implementations;
using System;
using Xunit;

namespace Implementations.Tests
{
    public class StaticQueueTests
    {
        [Fact]
        public void EnqueueAndDequeue_ShouldRetrieveSameItem()
        {
            // Arrange
            var queue = new StaticQueue<int>(1);
            var item = 42;

            // Act
            queue.Enqueue(item);
            var result = queue.Dequeue();

            // Assert
            Assert.Equal(item, result);
        }

        [Fact]
        public void Dequeue_OnEmptyQueue_ShouldThrowInvalidOperationException()
        {
            // Arrange
            var queue = new StaticQueue<int>(1);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Fact]
        public void Peek_ShouldReturnFirstItemWithoutRemoving()
        {
            // Arrange
            var queue = new StaticQueue<int>(2);
            int number1 = 42;
            int number2 = 100;

            // Enqueue them into the queue
            queue.Enqueue(number1);
            queue.Enqueue(number2);

            // Act
            var result = queue.Peek();

            // Assert
            Assert.Equal(number1, result); // Verify that Peek doesn't remove the item
            Assert.Equal(2, queue.Count()); // Verify the count is still 2
        }

        [Fact]
        public void Dequeue_OnCustomAndSystem_ShouldEqualTheSame()
        {
            // Arrange
            var customQueue = new StaticQueue<int>(200);
            var systemQueue = new Queue<int>();

            // Sample 200 random integers in the range [0, 1000]
            var random = new Random();
            for (int i = 0; i < 200; i++)
            {
                var number = random.Next(1000);
                customQueue.Enqueue(number);
                systemQueue.Enqueue(number);
            }

            // Dequeue all items from both queues and verify that they are equal
            while (!customQueue.IsEmpty())
            {
                // Dequeue and save the items from both queues
                int customDequeue = customQueue.Dequeue();
                int systemDequeue = systemQueue.Dequeue();

                // Assert that they are equal
                Assert.Equal(customDequeue, systemDequeue);
            }
        }
    }
}