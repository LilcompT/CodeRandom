using System;

class DoubleArray
{
    static void Main()
    {
        int[] A1 = {1,2,3,4};
        int[] A2 = {2,3,1,5};

        for(int i = 0; i < A1.Length; ++i)
        {
            for(int j = 0; j < A2.Length; ++j)
            {
                if(A1[i] == A2[j])
                {
                    Console.WriteLine("Matched Value: " + A1[j]);
                }
            }
        }
    }
}