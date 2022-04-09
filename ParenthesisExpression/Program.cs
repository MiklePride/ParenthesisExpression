class program
{
    static void Main(string[] args)
    {
        string parenthesisExpression;
        char openParenthesis = '(';
        char closeParenthesis = ')';
        int parenthesisScore = 0;
        int maximumDepth = 0;
        
        parenthesisExpression = Console.ReadLine();

        foreach (char symbol in parenthesisExpression)
        {
            if(symbol == openParenthesis)
            {
                parenthesisScore++;
                maximumDepth++;
            }
            else if(symbol == closeParenthesis)
            {
                parenthesisScore--;
            }
            
            if (parenthesisScore < 0 && parenthesisScore != 0)
            {
                Console.WriteLine("Выражение не корректно!");
                break;
            }
        }
        Console.WriteLine($"Скобочное выражение корректно и его максимальная вложенность равна {maximumDepth}");
    }
}