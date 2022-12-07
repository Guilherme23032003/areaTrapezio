Console.WriteLine("ola, essa é uma calculadora de area de trapezios, pressione 'enter' para começar ! ");
Console.ReadLine();
double b, B, h, area;

Console.Write("informe o valor da base menor do trapezio: " );

b = double.Parse(Console.ReadLine());

Console.Write("informe o valor da basae maior do trapezio: ");

B = double.Parse(Console.ReadLine());

Console.Write("informe o valor da altura do trapezio do trapezio: ");

h = double.Parse(Console.ReadLine());

area = (b + B) / 2 * h;

Console.WriteLine("a area do trapézio é : " + area);
