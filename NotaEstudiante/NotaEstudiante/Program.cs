using NotaEstudiante.DAO;
using NotaEstudiante.Models;


Notum nota = new Notum();
Operaciones Clsoperaciones = new Operaciones();

bool Continuar = true;
while (Continuar)
{
    Console.WriteLine("==========================");
    Console.WriteLine("BIENVENIDO AL PORTAL UNAB");
    Console.WriteLine("==========================");

    Console.WriteLine("");

    Console.WriteLine("Preciona 1 para Calcular Notas");

    Console.WriteLine("==========================");

    Console.WriteLine("");

    Console.WriteLine("Preciona 2 para Listar Notas");

    Console.WriteLine("==========================");

    Console.WriteLine("");

    var menu = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    switch (menu)
    {
        case 1:
            Console.WriteLine("Ingrese el nombre de la Materia: ");
            nota.Materia = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ingrese el nombre del Estudiante: ");
            nota.NombreEstudiante = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ingrese la nota del Laboratio 1: ");
            nota.Labo1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese la nota del Parcial 1: ");
            nota.Parcial1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese la nota del Laboratio 2: ");
            nota.Labo2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese la nota del Parcial 2: ");
            nota.Parcial2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese la nota del Laboratio 3: ");
            nota.Labo3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese la nota del Parcial 3: ");
            nota.Parcial3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Su resultado es: " + Clsoperaciones.Periodos(nota));

            Console.WriteLine("");

            Clsoperaciones.AgregarNota(nota);

            Console.WriteLine("");
            Console.WriteLine("Su Registro Ha Sido Guardado Exitosamente...");
            Console.WriteLine("======================================");
            Console.WriteLine("");

            break;
        case 2:
            Console.WriteLine("Lista de Notas");
            var ListarNotas = Clsoperaciones.ListarNotas();
            foreach (var iteracionNota in ListarNotas)
            {
                Console.WriteLine($"{iteracionNota.Notas}, {iteracionNota.Materia}, {iteracionNota.NombreEstudiante},  {iteracionNota.Labo1}, {iteracionNota.Parcial1}, {iteracionNota.Labo2}, {iteracionNota.Parcial2}, {iteracionNota.Labo3}, {iteracionNota.Parcial3},{iteracionNota.Resultado} ");

            }
            break;
    }
    Console.WriteLine("");
    Console.WriteLine("Desea continuar ? Precione S/N");
    var cont = Console.ReadLine();
    if (cont.Equals("N"))
    {
        Continuar = false;
    }
}



