// факториал числа

int Factorial (int n)
{
// 1! = 1
// 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);

}

System.Console.WriteLine(Factorial(3));