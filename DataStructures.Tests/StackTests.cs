using Implementations;
using System;
using Xunit;

namespace Implementations.Tests
{
    public class StaticStackTests
    {
        [Fact]
        public void PushAndPop_ShouldRetrieveSameItem()
        {
            // Arrange
            var stack = new StaticStack<int>(1);
            var item = 42;

            // Act
            stack.Push(item);
            var result = stack.Pop();

            // Assert
            Assert.Equal(item, result);
        }

        [Fact]
        public void Pop_OnEmptyStack_ShouldThrowInvalidOperationException()
        {
            // Arrange
            var stack = new StaticStack<int>(1);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void Peek_ShouldReturnLastItemWithoutRemoving()
        {
            // Arrange
            var stack = new StaticStack<int>(2);
            int number1 = 42;
            int number2 = 100;

            // Push them onto the stack
            stack.Push(number1);
            stack.Push(number2);

            // Act
            var result = stack.Peek();

            // Assert
            Assert.Equal(number2, result);
            Assert.Equal(2, stack.Count()); // Verify that Peek doesn't remove the item
        }

        [Fact]
        public void Pop_OnCustomAndSystem_ShouldEqualTheSame()
        {
            // Arrange
            var customStack = new StaticStack<int>(200); // The keyword "var" decides the datatype during compile time
            var systemStack = new Stack<int>(); // The keyword "var" decides the datatype during compile time

            // Sample 200 random integers in the range [0, 1000]
            var random = new Random();
            for (int i = 0; i < 200; i++)
            {
                var number = random.Next(1000);
                customStack.Push(number);
                systemStack.Push(number);
            }

            // Pop all items from both stacks and verify that they are equal
            while (!customStack.IsEmpty())
            {
                // Pop and save the items from both stacks
                int customPop = customStack.Pop();
                int systemPop = systemStack.Pop();

                // Assert that they are equal
                Assert.Equal(customPop, systemPop);
            }

        }
    }
}
