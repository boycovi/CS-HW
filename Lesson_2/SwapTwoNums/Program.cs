﻿int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"before swapping {a} {b}");
(a, b) = (b, a);
Console.WriteLine($"after swapping {a} {b}");
Console.ReadKey();