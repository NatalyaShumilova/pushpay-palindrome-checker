
namespace pushpay_palindrome_checker;

class Program
{
    // Implement a palindrome checker to make the following test cases pass. This starter code is in C# but you are welcome to write your solution in any language
 
    static bool IsPalindrome(string s){
        string lowercase = s.ToLower().Replace(" ", "");
        string reverse = new(lowercase.Reverse().ToArray());
        return lowercase == reverse;
    }
    
    static void Check(string s, bool shouldBePalindrome){
        Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");   
    }
    
    static void Main()
    {
        Check("abcba", true);
        Check("abcde", false);
        Check("Mr owl ate my metal worm", true);
        Check("Never Odd Or Even", true);
        Check("Never Even Or Odd", false);
    }
}
