using Xunit;

public class LikeSystemTests
{
    [Fact]
    public void TestEmptyAndSingleName()
    {
        LikeSystem likeSystem = new LikeSystem();

        // Case 1: Empty array
        string resultEmpty = likeSystem.getLikes(new string[] { });
        Assert.Equal("no one likes this", resultEmpty);

        // Case 2: Array with one name
        string resultSingle = likeSystem.getLikes(new string[] { "Peter" });
        Assert.Equal("Peter likes this", resultSingle);
    }

    [Fact]
    public void TestTwoThreeAndMoreNames()
    {
        LikeSystem likeSystem = new LikeSystem();

        // Case 3: Array with two names
        string resultTwo = likeSystem.getLikes(new string[] { "Jacob", "Alex" });
        Assert.Equal("Jacob and Alex like this", resultTwo);

        // Case 4: Array with four names
        string resultMore = likeSystem.getLikes(new string[] { "Alex", "Jacob", "Mark", "Max" });
        Assert.Equal("Alex, Jacob and 2 others like this", resultMore);
    }
}
