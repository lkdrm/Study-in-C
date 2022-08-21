using ComplexNumbers;

Complex c1 = new (1, 1);
Complex c2 = new (1, 2);

Complex result = c1.Plus(c2);
Console.WriteLine($"The result is Real={result.Real}; Is Imaginary={result.Imaginary}");

Complex result_2 = c1.Minus(c2);
Console.WriteLine($"The result is Real={result.Real}; Is Imaginary={result.Imaginary}");
