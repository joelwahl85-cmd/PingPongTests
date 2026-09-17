namespace Y2021D01;

public class Sonar
{
    public int CountIncreases(int[] depths)
    {
        int increases = 0;

        for (int i = 1; i < depths.Length; i++)
        {
            if (depths[i] > depths[i-1] )
            {
                increases++;
            }
        }

        return increases;
    }

    public int CountingIncreaseSum(int[] depths)
    {
        int latestSum = 0;
        int increases = 0;
        for (int i = 0; i < depths.Length - 2; i++)
        {
            int suma = depths[i] + depths[i + 1] + depths[i + 2];
            if (suma > latestSum && i > 0)
            {
                increases++;
            }

            latestSum = suma;
        }
        return increases;
    }
}