// See https://aka.ms/new-console-template for more information


// examen 

// variables de inicio  
int opcion = 0;
bool salir = false;

void function_01()
{
    Console.WriteLine("INGRESE UN NUMERO");
    int num = 0;
    num = Convert.ToInt32(Console.ReadLine());
    if(num > 0)
    {
        Console.WriteLine("POSITIVO");
    }else if(num == 0)
    {
        Console.WriteLine("CERO");
    }else if(num < 0)
    {
        Console.WriteLine("NEGATIVO");
    }
    else
    {
        Console.WriteLine("NUMERO NO VALIDO");
    }
    menu();
}
void function_02()
{
    string dia = string.Empty;
    Console.WriteLine("INGRESE DIA DE LA SEMANA");
    dia = Console.ReadLine();
    if (dia == "LUNES")
    {
        Console.WriteLine("DIA LUNES");
    }
    else if(dia == "MARTES")
    {
        Console.WriteLine("DIA MARTES");
    }
    else if(dia  == "MIERCOLES"){
        Console.WriteLine("DIA MIERCOLES");
    }
    else if(dia  == "JUEVES")
    {
        Console.WriteLine("DIA JUEVES");
    }
    else if(dia == "VIERNES")
    {
        Console.WriteLine("DIA VIERNES");
    }
    else if(dia  == "SABADO")
    {
        Console.WriteLine("DIA SABADO");
    }
    else if(dia == "DOMINGO")
    {
        Console.WriteLine("DIA DOMINGO");
    }
    else
    {
        Console.WriteLine("OPCION NO VALIDA");
    }
    menu();
}
void function_03()
{
    int sum_numeros = 0;
    for (int i = 0; i <= 100; i++)
    {
        sum_numeros = sum_numeros + i;
    }
    Console.WriteLine("La  suam de los  pirmeros 100  numeros naturales es: " + sum_numeros);
    menu();
}

void function_04()
{
    int num_recibido = 0;
    Console.WriteLine("INGRESE EL  NUMERO DE USUARIO");
    num_recibido = Convert.ToInt32(Console.ReadLine());
    for (int i = 1;i <= num_recibido;i++) {
        Console.WriteLine("Los numeros a imprimir son: "+i); 
    }
    menu();
}
void function_05()
{
    double PI = 3.1416;
    double radio_circulo = 0;
    double area_circulo = 0;
    Console.WriteLine("Ingrese el valor del radio");
    radio_circulo = Convert.ToDouble(Console.ReadLine());
    area_circulo = radio_circulo * radio_circulo + PI;
    Console.WriteLine("El area del cirulo sera: " + area_circulo);
    menu();
}
void function_06()
{
    int[] elemento = new int[5];
    elemento[0] = 12;
    elemento[1] = 13;
    elemento[2] = 15;
    elemento[3] = 20;
    elemento[4] = 35;

    foreach (int i in elemento)
    {
        Console.WriteLine("Los valores del arreglo son: " + i);
    }
    menu();
}
void function_07()
{
    int canridad_perr = 0;
    string nom_person = string.Empty;
    List<string> nom_persona = new List<string>();
    //  ingresmaos l cantidad de perosnas
    Console.WriteLine("Ingres cantidad de personas");
    canridad_perr = Convert.ToInt32(Console.ReadLine());
    // llenamos la lista
    for (int i = 0; i < canridad_perr; i++)
    {
        Console.WriteLine("Ingrese Nombre de persona");
        nom_person = Console.ReadLine();
        nom_persona.Add(nom_person);
    }

    // mostramos  las peronas de la lista llenada
    foreach (var item in nom_persona)
    {
        Console.WriteLine("Las perosnas de la lista osn: " + item);
    }
    menu();
}
void function_09()
{
    
    Console.WriteLine("NO ESA  OPCION");
    menu();
}



//  strcutara para derivar 
bool menu()
{
    do
    {
        //  invocamoss   a los funciones
        Console.WriteLine("INGRESE NUMERO DE MENU");
        opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1)
        {
            salir = false;
            function_01();
        }
        else if (opcion == 2)
        {
            salir = false;
            function_02();
        }
        else if (opcion == 3)
        {
            salir = false;
            function_03();
        }
        else if (opcion == 4)
        {
            salir = false;
            function_04();
        }
        else if (opcion == 5)
        {
            salir = false;
            function_05();
        }
        else if (opcion == 6)
        {
            salir = false;
            function_06();
        }
        else if (opcion == 7)
        {
            salir = false;
            function_07();
        }
        else if (opcion == 8)
        {
            salir = true;

        }
        else
        {
            salir = false;
            function_09();
        }
        return salir;
    } while (!salir);
}

Console.WriteLine(menu());