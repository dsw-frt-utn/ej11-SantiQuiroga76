using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using Microsoft.VisualBasic;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList listAlu = new CasoList();

        Alumno alu1 = new Alumno(25 ,"Santiago", 7.5);
        Alumno alu2 = new Alumno(30, "Joaquin", 8.2);
        Alumno alu3 = new Alumno(35, "Pipe", 6.7);

        listAlu.AgregarAlumno(alu1);
        listAlu.AgregarAlumno(alu2);
        listAlu.AgregarAlumno(alu3);

        Console.WriteLine("--- LISTA INCIAL ALUMNOS ---");
        foreach (var a in listAlu.ObtenerLista())
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

        Console.WriteLine("--- BUSQUEDA DE ALUMNOS EN LISTA ---");
        Console.WriteLine(listAlu.BuscarPorNombre("Pipe"));
        var encontrado = listAlu.BuscarPorNombre("Nacho");
        Console.WriteLine( encontrado != null? encontrado.ToString() : "El alumno buscado No existe");
        Console.WriteLine();

        Console.WriteLine("--- ELIMINACION DE ALUMNO Y LISTADO ---");
        listAlu.EliminarAlumno(alu2);
        foreach (var a in listAlu.ObtenerLista())
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

        Console.WriteLine("--- ELIMINACION ALUMNO POR POSICION Y LISTADO");
        listAlu.EliminarPorPosicion(0);
        foreach (var a in listAlu.ObtenerLista())
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary dictAlu = new CasoDictionary();

        Alumno alu1 = new Alumno(258, "Santiago", 7.5);
        Alumno alu2 = new Alumno(307, "Joaquin", 8.2);
        Alumno alu3 = new Alumno(322, "Pipe", 6.7);

        dictAlu.AgregarALumno(alu1.Id, alu1);
        dictAlu.AgregarALumno(alu2.Id, alu2);
        dictAlu.AgregarALumno(alu3.Id, alu3);

        Console.WriteLine("--- DICCIONARIO INCIAL ALUMNOS ---");
        foreach(var item in dictAlu.ObtenerDiccionario())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        Console.WriteLine("--- BUSQUEDA ALUMNO POR CLAVE ---");
        Console.WriteLine(dictAlu.BuscarAlumno(307));
        Console.WriteLine();

        Console.WriteLine("--- BUSQUEDA ALUMNO INEXISTENTE POR CLAVE ---");
        var busqueda = dictAlu.BuscarAlumno(40);
        Console.WriteLine(busqueda != null? busqueda : "El alumno buscado no existe");
        Console.WriteLine();

        Console.WriteLine("--- ELIMINACION DE ALUMNO POR CLAVE Y LISTADO ---");
        dictAlu.EliminarAlumno(322);
        foreach (var item in dictAlu.ObtenerDiccionario())
        {
            Console.WriteLine($"{item.Key} - {item.Value.Nombre} - {item.Value.Promedio}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
