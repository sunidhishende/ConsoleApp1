// See https://aka.ms/new-console-template for more information
class CalculatorOps
{
    public double operate(double n1, double n2, char op)
    {
        if (op=='+' || op=='-' || op=='*' || op=='/')
        {
            double ans = double.NaN;
            switch (op)
            {

                case '+':
                    ans = n1 + n2;
                    break;
                case '-':
                    ans = n1 - n2;
                    break;
                case '*':
                    ans = n1 * n2;
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        throw new Exception("divisor should not be 0");
                    }
                    else
                    {
                        ans = n1 / n2;
                        break;
                    }
            }
            return ans; 
        }
        else{
            throw new Exception("not a valid op!");
        }
        

    }
}

class Calculator
{
    public static void Main(string[] args)
    {
        CalculatorOps ops = new CalculatorOps();
        double num1 = double.NaN, num2 = double.NaN, ans = double.NaN;
        char op;
        Console.WriteLine("Enter two numbers");
        num1 = Convert.ToDouble(Console.ReadLine());
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the operation to be performed: +,-,*,/");
        op = Convert.ToChar(Console.Read());
            try{
                ans = ops.operate(num1, num2, op);
                Console.WriteLine("The answer is " + ans);
            }
            catch(Exception err){
                Console.WriteLine(err);
            }
        
        return;
    }
}