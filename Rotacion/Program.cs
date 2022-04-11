int rotacion, numero = 0;
bool c1 = false;

Console.Write("Numer of integers n: ");

while (!c1)
{
    c1 = Int32.TryParse(Console.ReadLine(), out numero);
    if (!c1) Console.Write("Not a valid number try again  ");
}
var arreglo = new int[numero];
var arreglorotado = new int[numero];
Console.Write("Numer of rotations d: ");
do
{
    c1 = Int32.TryParse(Console.ReadLine(), out rotacion);
    if (!c1) Console.Write("Not a valid number try again  ");
} while (!c1);

int control = rotacion % numero;

for (int i = 0; i<numero ; i++) {
    arreglo[i] = i + 1;
    Console.Write($"{arreglo[i]} ");
}
Console.WriteLine(" ");

for (int i = 1; i <= (numero-control); i++) { 
    arreglorotado[i-1] = control + i ;
    Console.Write($"{arreglorotado[i-1]} ");
}

for (int i = 0; i < control; i++)
{
    arreglorotado[numero - control - 1 + i] = i + 1;
    Console.Write($"{arreglorotado[numero - control - 1 + i]} ");
}
