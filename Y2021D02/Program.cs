// See https://aka.ms/new-console-template for more information

using AdventOfCode.Common;
using Y2021D01;

Console.WriteLine("Hello, World!");
var path = Path.Combine(AppContext.BaseDirectory, "input.txt");
var text = File.ReadAllText(path);

var tomte = new Tomte();
var floor_sum = tomte.CountTomteFloor(text);

Console.WriteLine($"The file contained tomte who is at floor {floor_sum}");
