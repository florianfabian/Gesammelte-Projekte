using System;

public class Zahlentheorie
{

    public static int BerechneGGT(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);  
        if (a == 0)
        {
            return b;
        }
        else
        {
            while (b != 0)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
        }
        return a;
    }
    public static int BerechneKGV(int a, int b)
    {
        int kgv = a * b / BerechneGGT(a, b);
        return kgv;
    }

}
