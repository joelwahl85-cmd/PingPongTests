// See https://aka.ms/new-console-template for more information

using AdventOfCode.Common;
using Y2021D02;

Console.WriteLine("Hello, World!");
var path = Path.Combine(AppContext.BaseDirectory, "input.txt");
var text = File.ReadAllText(path);

var tomte = new Tomte();
var floor_sum = tomte.CountTomteFloor(text);
var first_negative_floor = tomte.FindFirstNegativeFloor(text);

Console.WriteLine($"The file contained tomte who is at floor {floor_sum}");
Console.WriteLine($"The first negative floor is at position {first_negative_floor}");
