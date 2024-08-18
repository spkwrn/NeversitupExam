// See https://aka.ms/new-console-template for more information
using Exam2;
 
Console.WriteLine("Permutations result " + string.Join(",",Permutations.Shufflings("a")) );
Console.WriteLine("Permutations result " + string.Join(",", Permutations.Shufflings("ab")));
Console.WriteLine("Permutations result " + string.Join(",", Permutations.Shufflings("abc")));
Console.WriteLine("Permutations result " + string.Join(",", Permutations.Shufflings("aabb")));

Console.WriteLine("FinfOddUnit result " + OddUnit.FinfOddUnit(new int[] { 7 }));
Console.WriteLine("FinfOddUnit result " + OddUnit.FinfOddUnit(new int[] { 0 }));
Console.WriteLine("FinfOddUnit result " + OddUnit.FinfOddUnit(new int[] { 1, 1, 2 }));
Console.WriteLine("FinfOddUnit result " + OddUnit.FinfOddUnit(new int[] { 0, 1, 0, 1, 0 }));
Console.WriteLine("FinfOddUnit result " + OddUnit.FinfOddUnit(new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }));


Console.WriteLine("Count Smily Face result " + SmilyFaces.CountSmilyFaces(new string[] { ":)", ";(", ";}", ":-D" }));
Console.WriteLine("Count Smily Face result " + SmilyFaces.CountSmilyFaces(new string[] { ";D", ":-(", ":-)", ";~)" }));
Console.WriteLine("Count Smily Face result " + SmilyFaces.CountSmilyFaces(new string[] { ";]", ":[", ";* ", ":$", ";-D" }));
