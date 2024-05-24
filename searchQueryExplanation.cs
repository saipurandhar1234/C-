Certainly! The task you're describing involves parsing a search query to find specific keywords, in this case, "JAVA." Below is a simple C# program that extracts the word "JAVA" from a given search query.

```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Example search query
        string searchQuery = "Which are the resumes contains \"JAVA\" skill";

        // Extract the keyword "JAVA" from the search query
        string keyword = ExtractKeyword(searchQuery);

        // Display the extracted keyword
        if (keyword != null)
        {
            Console.WriteLine("Extracted keyword: " + keyword);
        }
        else
        {
            Console.WriteLine("Keyword not found in the search query.");
        }
    }

    static string ExtractKeyword(string searchQuery)
    {
        // Define the keyword to search for
        string keyword = "JAVA";

        // Use regular expression to find the keyword in the search query
        Regex regex = new Regex(@"\b" + keyword + @"\b", RegexOptions.IgnoreCase);
        Match match = regex.Match(searchQuery);

        // Return the keyword if found, otherwise return null
        return match.Success ? match.Value : null;
    }
}
```

### Explanation:
1. **Search Query:** The `searchQuery` variable contains the input sentence where we need to search for the keyword "JAVA."
2. **ExtractKeyword Method:** This method takes the search query as input and uses a regular expression to find the keyword "JAVA."
    - `Regex` is used with `\b` word boundaries to match the exact word "JAVA" (ignoring case with `RegexOptions.IgnoreCase`).
    - `Match` is used to find if the keyword exists in the search query.
3. **Display the Result:** If the keyword "JAVA" is found, it is printed out; otherwise, a message indicating the keyword was not found is displayed.

### Steps to Run the Program:
1. Open a C# development environment (like Visual Studio or any other IDE of your choice).
2. Copy and paste the above code into a new console application project.
3. Run the program to see the result.

This program can be easily extended to handle multiple keywords or more complex search queries if needed.
