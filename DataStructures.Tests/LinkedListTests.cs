using Implementations;
using System;
using Xunit;

namespace Implementations.Tests
{
    public class CustomLinkedListTests
    {
        [Fact]
        public void AddAndRemoveThousandsOfItems()
        {
            // Arrange
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            const int itemCount = 100000;
            var random = new Random();

            // Declare array with itemCount numbers
            var numbers = new int[itemCount];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1000);
            }

            // Add items
            for (int i = 0; i < itemCount; i++)
            {
                list.Insert(numbers[i]); // Assuming AddLast method is available
            }

            // Assert
            Assert.Equal(itemCount, list.count);

            for (int i = 0; i < itemCount; i++)
            {
                list.Delete(numbers[i]);
            }
            Assert.True(list.IsEmpty());
        }

    }
}
