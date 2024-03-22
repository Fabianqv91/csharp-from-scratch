var circ = new Circulo();
 
circ.radio = 20;
var resultado_area = circ.Area();
var resultado_perimetro = circ.Perimetro();
 
Console.WriteLine($"el area es es:{resultado_area} el perimetro  es :{resultado_perimetro} el nuevo radio es {circ.Add10()}");
 
int prev = 0, next = 1, suma;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    suma = prev + next;
    prev = next;
    next = suma;
}
 
//ecepxiones
 
try
{
    Console.WriteLine("numero a dividir");
    double num = double.Parse(Console.ReadLine());
    Console.WriteLine("numero divisor");
    double div = double.Parse(Console.ReadLine());
    if (div == 0)
    {
        throw new DivideByZeroException();
    
    }
 
 
    Console.WriteLine($"el resultado  es:{num / div} ");
}
catch (DivideByZeroException)
{
    Console.WriteLine($"no se puede dividir por cero ");
}
catch (Exception)
{
    Console.WriteLine($"Error ");
 
}
 
 
 
/*class Figura{
 
public abstract Area();
public abstract Perimetro ();
}*/
 
interface IExtraCalculations
{
    public double Add10();
}
 
 
interface IFigura
{
    public double Area();
    public double Perimetro();
}
 
class Circulo : IFigura, IExtraCalculations
{
 
    public double radio { get; set; }
    public double Area() => Math.PI * radio * radio;
    public double Perimetro() => 2 * Math.PI * radio;
 
    public double Add10()
    {
        return radio + 10;
    }
 
 
}
