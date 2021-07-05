using System;

public static class ResistorColor
{
    private static readonly string[] COLORS = new string[]{ "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static int ColorCode(string color) => Array.FindIndex(COLORS, c => c == color);
    public static string[] Colors() => COLORS;
}