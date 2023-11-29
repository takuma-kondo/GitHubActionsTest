public class SampleClass
{
    public int AddNumbers(int a, int d)
    {
        var b = 2*a;
        d += b; 
        return a + d;
    }

    public int SubtractNumbers(int a, int b)
    {
        return a - b;
    }

    public string ConcatenateStrings(string str1, string str2)
    {
        return str1 + str2;
    }
}