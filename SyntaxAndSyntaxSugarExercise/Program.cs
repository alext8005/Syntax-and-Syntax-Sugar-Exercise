namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Inferred Typing, replace int for var
            var answer = 4;
            string response;
            // replace Concatenation with string interpolation
            if (answer < 9) 
            {
                response = $"{answer} is less than nine";
            }
            else
            {
                response = $"{answer} is greater than or equal to nine";
            }
            //changed to ternary operator
            Console.WriteLine(answer < 9 ? " is less than nine" : " is greater than or equal to nine");
            
            
        }
    }
}
