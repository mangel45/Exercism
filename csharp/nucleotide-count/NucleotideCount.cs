using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    private const string VALID_NUCLEOTIDES = "ACGT";
    private static Dictionary<char, int> dictionary = new Dictionary<char, int>();        
    
    public static IDictionary<char, int> Count(string sequence)
    {       
        dictionary.Clear();
        foreach (char c in VALID_NUCLEOTIDES) {
            dictionary.Add(c, 0);
        }
        
        foreach (char c  in sequence) {
            if(!VALID_NUCLEOTIDES.Contains(c)) throw new ArgumentException();
            dictionary[c]++;            
        }            
        return dictionary;
    }
}