int num1 = 11;
int num2 = 12;

// operators(+,-,*,/,%)

Console.WriteLine($"Addition:{num1 +num2}");
Console.WriteLine($"Substraction:{num1 - num2}");
Console.WriteLine($"Division:{num1 / num2}");
Console.WriteLine($"Multiplication:{num1 * num2}");
Console.WriteLine($"Modulus:{num1 % num2}");

num1 =num1+ 4;
Console.WriteLine($"New Value for num1:{num1}");
Console.WriteLine($"Addition:{num1 + num2}");
Console.WriteLine($"Substraction:{num1 - num2}");
Console.WriteLine($"Division:{num1 / num2}");
Console.WriteLine($"Multiplication:{num1 * num2}");
Console.WriteLine($"Modulus:{num1 % num2}");

// compound Assignment (+=,-=,*=,/=,%=)
num1 += 4;
Console.WriteLine($"New Value for num1 after +=:{num1}");
num1 -= 4;
Console.WriteLine($"New Value for num1 after -=:{num1}");
num1 *= 4;
Console.WriteLine($"New Value for num1 after *=:{num1}");
num1 /= 4;
Console.WriteLine($"New Value for num1 after /=:{num1}");
num1 %= 4;
Console.WriteLine($"New Value for num1 after %=:{num1}");
