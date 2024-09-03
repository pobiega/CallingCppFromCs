// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

int a = 10;
int b = 20;
int result = CppFunctions.Add(a, b);
Console.WriteLine($"{a} + {b} = {result}");


public static class CppFunctions
{
    private const string DllPath = @"..\..\..\..\x64\Debug\MyCppCode.dll";

    [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
    public static extern int Add(int a, int b);
}