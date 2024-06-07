namespace Assignment5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a word");
            string input = Console.ReadLine();
            Console.WriteLine(Palindrome(input,0,input.Length-1));     //assigning leftletter =0 and length-1 = rightLetter
        }
        static bool Palindrome (string s, int leftLetter, int rightLetter)
        {
            if (leftLetter <= rightLetter)
            {          
                if (s[leftLetter] != s[rightLetter])
                {
                    return false;
                }
                Palindrome(s, leftLetter+1, rightLetter-1);  //when we call Palindrome method, we're moving the first index +1 to the right and the last index -1 to the left
            }
            return true;
        }
    }
}
