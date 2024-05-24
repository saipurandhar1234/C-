// Method 1
// The goal is to highlight and display the keyword "JAVA" automatically when the user searches in various ways. 
//Here's a C# console application that will search for the keyword "JAVA" in the provided query and then highlight (by displaying) the keyword if found.

,,,,,,,,,,,
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Example search queries from the end user
        string[] searchQueries = {
            "Which are the resumes contains Java skill",
            "Show me resumes with java experience",
            "Looking for candidates with JAVA knowledge",
            "Do any resumes mention java skills?",
            "Which resumes list Java?"
        };

        foreach (var searchQuery in searchQueries)
        {
            // Extract and highlight the keyword "JAVA" from the search query
            string highlightedKeyword = HighlightKeyword(searchQuery);

            // Display the highlighted keyword if found
            if (highlightedKeyword != null)
            {
                Console.WriteLine("Highlighted keyword: " + highlightedKeyword);
            }
            else
            {
                Console.WriteLine("Keyword not found in the search query: " + searchQuery);
            }
        }
    }

    static string HighlightKeyword(string searchQuery)
    {
        // Define the keyword to search for
        string keyword = "JAVA";

        // Use regular expression to find the keyword in the search query
        Regex regex = new Regex(@"\b" + keyword + @"\b", RegexOptions.IgnoreCase);
        Match match = regex.Match(searchQuery);

        // Return the keyword in uppercase if found, otherwise return null
        return match.Success ? keyword.ToUpper() : null;
    }
}






// Method 2
// To create a more dynamic solution where the application can identify and highlight a specific skill from a user's search query without explicitly setting the keyword, 
// you could use a list of predefined skills. The application will search for any of these skills in the user's query and highlight them if found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // List of predefined skills
        List<string> skills = new List<string> { "JAVA", "C#", "PYTHON", "JAVASCRIPT", "HTML", "CSS" };

        // Example search queries from the end user
        string[] searchQueries = {
            "Which are the resumes contains Java skill",
            "Show me resumes with python experience",
            "Looking for candidates with C# knowledge",
            "Do any resumes mention JavaScript skills?",
            "Which resumes list HTML?",
            "I need someone proficient in CSS."
        };

        foreach (var searchQuery in searchQueries)
        {
            // Extract and highlight the skill from the search query
            string highlightedSkill = HighlightSkill(searchQuery, skills);

            // Display the highlighted skill if found
            if (highlightedSkill != null)
            {
                Console.WriteLine("Highlighted skill: " + highlightedSkill);
            }
            else
            {
                Console.WriteLine("No skill found in the search query: " + searchQuery);
            }
        }
    }

    static string HighlightSkill(string searchQuery, List<string> skills)
    {
        foreach (var skill in skills)
        {
            // Use regular expression to find the skill in the search query
            Regex regex = new Regex(@"\b" + skill + @"\b", RegexOptions.IgnoreCase);
            Match match = regex.Match(searchQuery);

            // Return the skill in uppercase if found
            if (match.Success)
            {
                return skill.ToUpper();
            }
        }

        // Return null if no skill is found
        return null;
    }
}

  













