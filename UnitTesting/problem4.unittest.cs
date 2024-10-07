using Xunit;

public class SearchInArrayTests
{
    [Fact]
    public void TestWithMatchesAndNoMatches()
    {
        SearchInArray searcher = new SearchInArray();
        
        // Case 1: Search with some matches (should find "home" and "Mercury")
        string[] resultWithMatches = searcher.searchParts(new string[] { "home", "milk", "Mercury", "fish" }, "me");
        Assert.Equal(new string[] { "home", "Mercury" }, resultWithMatches);

        // Case 2: No matches found (should return "Empty")
        string[] resultWithNoMatches = searcher.searchParts(new string[] { "apple", "banana", "cherry" }, "xyz");
        Assert.Equal(new string[] { "Empty" }, resultWithNoMatches);
    }

    [Fact]
    public void TestCaseSensitivityAndEmptyInput()
    {
        SearchInArray searcher = new SearchInArray();
        
        // Case 3: Case-insensitive search (should find "Home" and "hOmE")
        string[] resultCaseInsensitive = searcher.searchParts(new string[] { "Home", "hOmE", "MERcury" }, "home");
        Assert.Equal(new string[] { "Home", "hOmE" }, resultCaseInsensitive);

        // Case 4: Empty array input (should return "Empty")
        string[] resultEmptyArray = searcher.searchParts(new string[] { }, "abc");
        Assert.Equal(new string[] { "Empty" }, resultEmptyArray);
    }
}
