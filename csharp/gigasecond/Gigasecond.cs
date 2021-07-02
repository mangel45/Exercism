using System;

public static class Gigasecond
{    
    private const double GIGASECOND = 1_000_000_000;
    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(GIGASECOND);
    }
}