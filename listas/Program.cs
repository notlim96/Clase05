// See https://aka.ms/new-console-template for more information

// VAMOS A VER  LISTAS.
List<string> asistentes = new List<string>();

string nombre = string.Empty;
bool salir = false;
string letra = string.Empty;

do
{
    Console.WriteLine("Ingrese nombre del asistente");
    nombre = Console.ReadLine();
    asistentes.Add(nombre);

    Console.WriteLine("Presiona la S para salir");
    letra = Console.ReadLine();

    if (letra.ToUpper() == "S")
        salir = true;
} while (!salir);

Console.WriteLine("La lista  de Asistentes es:");
foreach(var item in asistentes)
{
    Console.WriteLine(item);
}

