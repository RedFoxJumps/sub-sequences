using NUnit.Framework;
using SubSequences.SubArray;

namespace SubSequences.SubArrayTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SubArrayTests
    {
        [Test]
        public void FindSubArrayIndex_WhenArrayDoesNotContainSubarray_ShouldReturnMinusOne()
        {
            // arrange
            var array = new[] { 1, 2, 3, 4, 5, 6, };
            var subArray = new[] { 7, 8, 9, };
            var expected = -1;

            // act
            var result = SubArrayFinder.FindSubArrayIndex(array, subArray);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new int[] { })]
        [TestCase(new int[] { }, new[] { 1, 2, 3, 4, 5, 6, })]
        [TestCase(new int[] { }, new int[] { })]
        public void FindSubArrayIndex_WhenOneOfArraysIsEmpty_ShouldReturnMinusOne(
            int[] array, int[] subArray)
        {
            // arrange
            var expected = -1;

            // act
            var result = SubArrayFinder.FindSubArrayIndex(array, subArray);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 1, 2, 4, })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 2, 3, 4, 10, })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 5, 6, 7, })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 6, 7, })]
        public void FindSubArrayIndex_WhenPartiallyContainsSubArray_ShouldReturnMinusOne(
            int[] array, int[] subArray)
        {
            // arrange
            var expected = -1;

            // act
            var result = SubArrayFinder.FindSubArrayIndex(array, subArray);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 1, 2, 3, }, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 2, 3, 4, 5, }, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 5, 6, }, 4)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 6, }, 5)]
        public void FindSubArrayIndex_WhenContainsSubArray_ShouldReturnCorrectIndex(
            int[] array, int[] subArray, int expected)
        {
            // arrange

            // act
            var result = SubArrayFinder.FindSubArrayIndex(array, subArray);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}