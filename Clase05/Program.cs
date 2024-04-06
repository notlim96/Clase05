// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");


int cantidad = 0;
double promedioArreglo = 0;

Console.WriteLine("INGRESW CANRIDAD  NOTAS");
cantidad = Convert.ToInt32(Console.ReadLine());

int[] notas = new int[cantidad];

for (int i = 0; i < cantidad; i++)
{
    int numeroNota = i + 1;
    Console.WriteLine("Ingrese nota ["+ numeroNota + "]");
    notas[i] = Convert.ToInt32(Console.ReadLine());
}


double calcularPromedio(int[] notas)
{
    int sumaNotas = 0;
   
    int max = notas[0], min = notas[0];

    // editificr menor y mayor
    for (int i = 0; i < cantidad; i++)
    {
        if (notas[i] < min)
        {
            min = notas[i];
        }
        else if (notas[i] > max)
        {
            min = notas[i];
        }

        sumaNotas = sumaNotas + notas[i];
    }

    promedioArreglo = (sumaNotas - max - min) / (cantidad - 2);

    return promedioArreglo;
}


promedioArreglo = calcularPromedio(notas);

Console.WriteLine(promedioArreglo);




