namespace MyLibrary
{
    public class StringUtils
    {
        public string Reverse(string str) => new string(str.Reverse().ToArray());
        public bool IsPalindrome(string str) => str.ToLower() == Reverse(str.ToLower());
        public string ToUpperCase(string str) => str.ToUpper();
    }
}
