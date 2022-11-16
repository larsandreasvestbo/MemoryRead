// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.Write("Process Id: ");
var idString = Console.ReadLine();

if (int.TryParse(idString, out var id))
{
    var process = Process.GetProcessById(id);
    process.MainModule.
}
