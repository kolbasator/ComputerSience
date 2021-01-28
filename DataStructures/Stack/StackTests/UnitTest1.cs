using System;
using  Stack;
using FluentAssertions;
using NUnit.Framework;

namespace StackTests
{
    public class Tests
    {
        [TestFixture]
        public class StackViaArrayTests
        {
            [Test]
            public void Push_Test()
            {
                IStack<char> stack = new StackViaArray<char>(5);
                stack.Push('A');
                stack.Push('B');
                stack.Push('C');
                stack.Push('D');
                stack.Push('E');
                stack.IsEmpty.Should().BeFalse();
                stack.Count.Should().Be(5);
            }

            [Test]
            public void Pop_Test()
            {
                IStack<char> stack = new StackViaArray<char>(5);
                stack.Push('A');
                stack.Push('B');
                stack.Push('C');
                stack.Push('D');
                stack.Push('E');
                stack.IsEmpty.Should().BeFalse();
                stack.Count.Should().Be(5);
                stack.Pop().Should().Be('E');
                stack.Count.Should().Be(4);
                stack.Pop().Should().Be('D');
                stack.Count.Should().Be(3);
                stack.Pop().Should().Be('C');
                stack.Count.Should().Be(2);
                stack.Pop().Should().Be('B');
                stack.Count.Should().Be(1);
                stack.Pop().Should().Be('A');
                stack.Count.Should().Be(0);

                Action act = () => stack.Pop();
                act.Should().Throw<IndexOutOfRangeException>()
                    .WithMessage("Stack is empty.");
            }

            [Test]
            public void Peek_Test()
            {
                IStack<char> stack = new StackViaArray<char>(5);
                stack.Push('A');
                stack.Push('B');
                stack.Push('C');
                stack.Push('D');
                stack.Push('E');
                stack.IsEmpty.Should().BeFalse();
                stack.Count.Should().Be(5);
                stack.Peek().Should().Be('E');
                stack.Peek().Should().Be('E');
                stack.Peek().Should().Be('E');
            }
        }
    }
}