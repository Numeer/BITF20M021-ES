using System;
using System.Collections.Generic;
using System.Text;

public class EquationSolver
{
    static void Main()
    {
        // Console.WriteLine(Solve("122 + 323"));
        // Console.WriteLine(Solve("1 + 234"));
        // Console.WriteLine(Solve("323 - 121"));
        // Console.WriteLine(Solve("1 - 234"));
        // Console.WriteLine(Solve("22 * 45"));
        // Console.WriteLine(Solve("3 * 9"));
        // Console.WriteLine(Solve("22 / 2"));
        // Console.WriteLine(Solve("3 / 9"));
        // Console.WriteLine(Solve("22 / 2 * 34 - 4"));
        // Console.WriteLine(Solve("3 * 4 / 9 + 4"));
        // Console.WriteLine(Solve("( 1 + 1 ) - 3 * ( 44 * 5 ) / 20"));
        // Console.WriteLine(Solve("1 + 2 + 4 + 6 + 8"));
        // Console.WriteLine(Solve("( 1 + 1 ) - 3 * ( 44 * 5 ) / 20"));
        // Console.WriteLine(Solve("1 + 2 + 3"));
        // Console.WriteLine(Solve("(1 + 1) 3 + 4 * 5"));
        // Console.WriteLine(Solve("(((1 + 1) x 3) + 4 * 5"));
        // Console.WriteLine(Solve("1 + 2 + 3 - - 4"));
        // Console.WriteLine(Solve("1 + 2 + 3 -"));

        Console.Write("Enter an equation:");
        string equation = Console.ReadLine() ?? "";
        Console.WriteLine(equation);

        string result = Solve(equation);

        Console.WriteLine($"Result: {result}");
    }

    public static string Solve(string equation)
    {
        if (!IsValidEquation(equation))
        {
            return "Invalid equation";
        }
        else
        {
            try
            {
                double result = EvaluateExpression(equation);
                return result.ToString();
            }
            catch (InvalidOperationException ex)
            {
                return "Invalid equation " + ex.Message;
            }
        }
    }

    private static double EvaluateExpression(string expression)
    {
        Stack<double> operandStack = new Stack<double>();
        Stack<char> operatorStack = new Stack<char>();

        string[] tokens = expression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < tokens.Length; i++)
        {
            if (Double.TryParse(tokens[i], out double number))
            {
                operandStack.Push(number);
            }
            else if (IsOperator(tokens[i][0]))
            {
                while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) >= Precedence(tokens[i][0]))
                {
                    PerformOperation(operandStack, operatorStack);
                }

                operatorStack.Push(tokens[i][0]);
            }
            else if (tokens[i] == "(")
            {
                operatorStack.Push('(');
            }
            else if (tokens[i] == ")")
            {
                while (operatorStack.Count > 0 && operatorStack.Peek() != '(')
                {
                    PerformOperation(operandStack, operatorStack);
                }

                operatorStack.Pop();
            }
        }

        while (operatorStack.Count > 0)
        {
            PerformOperation(operandStack, operatorStack);
        }

        return operandStack.Pop();
    }

    private static void PerformOperation(Stack<double> operandStack, Stack<char> operatorStack)
    {
        if (operandStack.Count < 2)
        {
            throw new InvalidOperationException("Not enough operands for the operation.");
        }
        char op = operatorStack.Pop();
        double b = operandStack.Pop();
        double a = operandStack.Pop();

        switch (op)
        {
            case '+':
                operandStack.Push(a + b);
                break;
            case '-':
                operandStack.Push(a - b);
                break;
            case '*':
                operandStack.Push(a * b);
                break;
            case '/':
                if (b == 0)
                {
                    throw new InvalidOperationException("Cannot divide by zero.");
                }
                operandStack.Push(a / b);
                break;
        }
    }

    private static int Precedence(char op)
    {
        switch (op)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                return 0;
        }
    }

   private static bool IsValidEquation(string equation)
    {
        equation = equation.Replace(" ", "");
        int operandCount = 0;
        foreach (char c in equation)
        {
            if (Char.IsDigit(c))
            {
                operandCount++;
            }
        }

        if (operandCount < 2)
        {
            return false;
        }

        int openBracketCount = 0;
        int closeBracketCount = 0;
        bool lastWasOperator = false;

        foreach (char c in equation)
        {
            if (c == '(')
            {
                openBracketCount++;
                lastWasOperator = false;
            }
            else if (c == ')')
            {
                closeBracketCount++;
                lastWasOperator = false;
            }
            else if (IsOperator(c))
            {
                if (lastWasOperator )
                {
                    return false;
                }
                lastWasOperator = true;
            }
            else if (Char.IsDigit(c))
            {
                lastWasOperator = false;
            }
            else
            {
                lastWasOperator = false;
            }
        }

        if (IsOperator(equation[equation.Length - 1]))
        {
            return false;
        }

        if (openBracketCount != closeBracketCount)
        {
            return false;
        }

        return true;
    }

    private static bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }
}
