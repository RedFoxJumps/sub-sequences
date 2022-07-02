using NUnit.Framework;
using SubSequences.SubArray;

namespace SubArrayTests
{
    [TestFixture]
    public class AdditionalSubArrayTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 3, 2, 1, }, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 5, 4, 3, 2, }, 4)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 6, 5, }, 5)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 6, }, 5)]
        public void FindSubArrayIndex_WhenContainsReversedSubArray_ShouldReturnCorrectIndex(
            int[] array, int[] subArray, int expected)
        {
            // arrange

            // act
            var result = SubArrayFinder.FindSubArrayIndex(array, subArray);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 1, 2, 4, 6, }, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 1, 6, }, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 1, 5, }, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, }, new[] { 4, 6, }, 3)]
        public void FindSubArrayIndex_WhenContainsGapsBetweenSubArrayItems_ShouldReturnCorrectIndex(
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
