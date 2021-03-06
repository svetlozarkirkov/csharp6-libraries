﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArraySetBaseTests.cs" company="">
//   
// </copyright>
// <summary>
//   The array set  tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ML.Set.Tests.Core.Base
{
    using System;
    using FluentAssertions;
    using ML.Set.Core.Base;
    using ML.Set.Core.Exceptions;
    using NUnit.Framework;

    /// <summary>
    /// The array set <see langword="base"/> tests.
    /// </summary>
    [TestFixture]
    public class ArraySetBaseTests
    {
        /// <summary>
        /// Stub class (implementing ArraySetBase) used for testing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <seealso cref="Set.Core.Base.ArraySetBase{T}" />
        private class ArraySetBaseStub<T> : ArraySetBase<T>
        {
            /// <exception cref="InvalidSetCapacityException">Set capacity must be greater than zero.</exception>
            public ArraySetBaseStub() { }

            /// <exception cref="InvalidSetCapacityException">Set <paramref name="capacity"/> must be greater than zero.</exception>
            public ArraySetBaseStub(int capacity) : base(capacity) { }
        }

        /// <summary>
        /// The when set created_ no capacity given_ should not <see langword="throw"/> exception.
        /// </summary>
        /// <exception cref="Exception">
        /// A <see langword="delegate"/> callback throws an exception.
        /// </exception>
        /// <exception cref="InvalidSetCapacityException">
        /// Set capacity must be greater than zero.
        /// </exception>
        [Test]
        public void WhenSetCreated_NoCapacityGiven_ShouldNotThrowException()
        {
            // Arrange
            Action act = () => { new ArraySetBaseStub<object>(); };

            // Act Assert
            act.ShouldNotThrow<InvalidSetCapacityException>();
        }

        /// <summary>
        /// The when set created_ invalid <paramref name="capacity"/> given_ should throw exception.
        /// </summary>
        /// <exception cref="Exception">
        /// A <see langword="delegate"/> callback throws an exception.
        /// </exception>
        /// <exception cref="InvalidSetCapacityException">
        /// Set capacity must be greater than zero.
        /// </exception>
        [Test]
        public void WhenSetCreated_InvalidCapacityGiven_ShouldThrowException
            ([Values(0, -1, -100, -10000, int.MinValue)] int capacity)
        {
            // Arrange
            Action act = () => { new ArraySetBaseStub<object>(capacity); };

            // Act Assert
            act.ShouldThrowExactly<InvalidSetCapacityException>();
        }

        /// <summary>
        /// The when set created_ valid <paramref name="capacity"/> given_ should not throw exception.
        /// </summary>
        /// <exception cref="Exception">
        /// A <see langword="delegate"/> callback throws an exception.
        /// </exception>
        /// <exception cref="InvalidSetCapacityException">
        /// Set capacity must be greater than zero.
        /// </exception>
        [Test]
        public void WhenSetCreated_ValidCapacityGiven_ShouldNotThrowException
            ([Values(1, 100, 1000, 100000)] int capacity)
        {
            // Arrange
            Action act = () => { new ArraySetBaseStub<object>(capacity); };

            // Act Assert
            act.ShouldNotThrow<InvalidSetCapacityException>();
        }

        /// <summary>
        /// The when adding item_ max <paramref name="capacity"/> is reached_ should not throw exception.
        /// </summary>
        /// <param name="capacity">
        /// The capacity.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="body"/> argument is null.
        /// </exception>
        /// <exception cref="AggregateException">
        /// The exception that contains all the individual exceptions thrown on all threads.
        /// </exception>
        /// <exception cref="Exception">
        /// A delegate callback throws an exception.
        /// </exception>
        /// <exception cref="InvalidSetCapacityException">
        /// Set capacity must be greater than zero.
        /// </exception>
        /// <exception cref="OverflowException">
        /// The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue"/> elements.
        /// </exception>
        [Test]
        public void WhenAddingItem_MaxCapacityIsReached_ShouldNotThrowException
            ([Values(1, 10, 100, 10000)] int capacity)
        {
            // Arrange
            var set = new ArraySetBaseStub<string>(capacity);

            for (var i = 0; i < capacity; i++)
            {
                set.Add("Hello World!");
            }

            Action act = () => { set.Add("Hello World"); };

            // Act Assert
            act.ShouldNotThrow<IndexOutOfRangeException>();
        }

        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="InvalidSetCapacityException">Set capacity must be greater than zero.</exception>
        [Test]
        public void WhenContains_IfTheItemExists_ShouldReturnTrue
            ([Values("Hello World!", "Hello Universe!", "Hello Megaverse!")] string item)
        {
            // Arrange
            var set = new ArraySetBaseStub<string>();

            for (var i = 0; i < 10; i++)
            {
                set.Add("Other string");
            }

            set.Add(item);

            // Act
            var contains = set.Contains(item);

            // Assert
            Assert.AreEqual(true, contains);
        }

        /// <exception cref="ArgumentNullException">The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
        /// <exception cref="InvalidSetCapacityException">Set capacity must be greater than zero.</exception>
        [Test]
        public void WhenContains_IfTheItemDoesNotExist_ShouldReturnFalse
            ([Values("Hello World!", "Hello Universe!", "Hello Megaverse!")] string item)
        {
            // Arrange
            var set = new ArraySetBaseStub<string>();

            for (var i = 0; i < 10; i++)
            {
                set.Add("Other string");
            }

            // Act
            var contains = set.Contains(item);

            // Assert
            Assert.AreEqual(false, contains);
        }
    }
}