using System;

class AddTwoPolinoms
{
    //Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
    //    x2 + 5 = 1x2 + 0x + 5 

    public static int[] AddPolynomals(int[] first, int[] second)
    {
        int[] result;

        if (first.Length < second.Length)
        {
            result = new int[second.Length];
            for (int i = 0; i < second.Length; i++)
            {
                if (i >= first.Length)
                {
                    result[i] = second[i];
                    continue;
                }
                result[i] = first[i] + second[i];
            }
        }

        else
        {
            result = new int[first.Length];
            for (int i = 0; i < first.Length; i++)
            {
                if (i >= second.Length)
                {
                    result[i] = first[i];
                    continue;
                }
                result[i] = first[i] + second[i];
            }
        }
        return result;
    }


    static void Main()
    {
        int[] coefsFirst = { 4, 0, 4 };
        int[] coefsSecond = { 0, 3, 5, 5, 2 };

        int[] result = AddPolynomals(coefsFirst, coefsSecond);

        Console.Write("Resulting polynomal: ");

        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(result[i]);
                break;
            }

            if (result[i] != 0) Console.Write(result[i] + "x" + i + " + ");

        }
    }
}

