using DSAPatterns.SlidingWindow.LongestSubstring;

namespace DSAPatterns.Tests.SlidingWindow.MaximumSumsubarray;

public class SolutionTest
{

    private Solution _solution;

    [SetUp]
    public void Setup()
    {
        _solution =  new Solution();
    }

    [TestCase("abcabcbb", 3)]
    [TestCase("pwwkew", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("", 0)]
    [TestCase("dvdf", 3)]
    [TestCase("ckilbkd", 5)]
    [TestCase("stackoverflow", 11)]

    public void Tests(string input, int expected)
    {
        //Arrange - Already on Params

        //Act
        int result = _solution.LengthOfLongestSubString(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
