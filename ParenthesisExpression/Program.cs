class program
{
    static void Main(string[] args)
    {
        string staples;
        char openParenthesis = '(';
        char closeParenthesis = ')';
        int openParenthesisCount = 0;
        int closeParenthesisCount = 0;
        int symbolsCount = 3;

        staples = Console.ReadLine();

        foreach (char symbol in staples)
        {
            if (openParenthesis == symbol)
            {
                openParenthesisCount++;
            }
            else if (closeParenthesis == symbol)
            {
                closeParenthesisCount++;
            }
            symbolsCount++;
        }

        if (openParenthesisCount == closeParenthesisCount)
        {
            Console.WriteLine($"Скобочное выражение верное и его максимальная глубина равняется {openParenthesisCount}");
        }
        else
        {
            Console.WriteLine("Выражение не корректно");
        }
    }
}