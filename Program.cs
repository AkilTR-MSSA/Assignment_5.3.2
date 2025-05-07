Console.WriteLine(ClimbStairs(2));
Console.WriteLine(ClimbStairs(3));
Console.WriteLine(ClimbStairs(5));

int ClimbStairs(int n)
{
    int a = 1;
    int b = 1;
    for (int i = 0; i < n - 1; i++)
    {
        int temp = a + b;
        a = b;
        b = temp;
    }
    return b;
}