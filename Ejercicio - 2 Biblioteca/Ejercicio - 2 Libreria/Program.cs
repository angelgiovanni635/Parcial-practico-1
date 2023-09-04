using System;
using System.Collections.Generic;

class Program
{
    static List<Libro> biblioteca = new List<Libro>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Gestión de Biblioteca");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Agregar un libro");
            Console.WriteLine("2. Mostrar listado de libros");
            Console.WriteLine("3. Buscar libro por código");
            Console.WriteLine("4. Editar información de un libro");
            Console.WriteLine("5. Salir");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarLibro();
                        break;
                    case 2:
                        MostrarLibros();
                        break;
                    case 3:
                        BuscarLibroPorCodigo();
                        break;
                    case 4:
                        EditarLibroPorCodigo();
                        break;
                    case 5:

                        //Finalizacion del programa
                        Console.WriteLine("\nGracias por usar el sistema de libreria");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Presiona una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void AgregarLibro()
    {
        //limpiar pantalla
        Console.Clear();
        Console.WriteLine("Agregar un libro");
        Console.WriteLine("----------------");

        Console.Write("Código del libro: ");
        string codigo = Console.ReadLine();

        Console.Write("Título del libro: ");
        string titulo = Console.ReadLine();

        Console.Write("ISBN del libro: ");
        string isbn = Console.ReadLine();

        Console.Write("Edición del libro: ");
        string edicion = Console.ReadLine();

        Console.Write("Autor del libro: ");
        string autor = Console.ReadLine();

        //Se guarda la data en Libro
        biblioteca.Add
        (new Libro{
            Codigo = codigo,
            Titulo = titulo,
            ISBN = isbn,
            Edicion = edicion,
            Autor = autor
        });

        Console.WriteLine("Libro agregado correctamente. Presiona una tecla para continuar...");
        Console.ReadKey();
    }

    static void MostrarLibros()
    {
        //limpiar pantalla
        Console.Clear();
        Console.WriteLine("Listado de Libros");
        Console.WriteLine("-----------------");

        if (biblioteca.Count > 0) //valida si existen libros para mostrar
        {
            //impresion de data tipo tabla
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-20}", "Código", "Título", "ISBN", "Edición", "Autor");
            Console.WriteLine("--------------------------------------------------------------");

            //se imprimen los datos
            foreach (var libro in biblioteca)
            {
                //impresion de data tipo tabla
                Console.WriteLine("{0,-10} {1,-20} {2,-15} {3,-10} {4,-20}", libro.Codigo, libro.Titulo, libro.ISBN, libro.Edicion, libro.Autor);
            }
        }
        else
        {
            Console.WriteLine("No hay libros en la biblioteca, crea un libro antes");
        }

        Console.WriteLine("\nPresiona una tecla para continuar...\n");
        Console.ReadKey();
    }

    static void BuscarLibroPorCodigo()
    {
        //limpiar pantalla
        Console.Clear();
        Console.WriteLine("Buscar libro por código");
        Console.WriteLine("-----------------------");

        Console.Write("Ingrese el código del libro a buscar: ");
        string codigoBuscado = Console.ReadLine();

        Libro libroEncontrado = biblioteca.Find(libro => libro.Codigo == codigoBuscado);

        if (libroEncontrado != null)
        {
            //impresion de data tipo tabla

            Console.WriteLine("\nLibro encontrado");
            Console.WriteLine("----------------");
            Console.WriteLine("{0,-10} {1,-20} {2,-12} {3,-10} {4,-20}", "Código", "Título", "ISBN", "Edición", "Autor");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("{0, -10} {1, -20} {2, -15} {3, -10} {4, -20}",libroEncontrado.Codigo, libroEncontrado.Titulo, libroEncontrado.ISBN, libroEncontrado.Edicion, libroEncontrado.Autor);

        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }

        Console.WriteLine("\nPresiona una tecla para continuar...");
        Console.ReadKey();
    }

    static void EditarLibroPorCodigo()
    {
        Console.Clear();
        Console.WriteLine("Editar información de un libro");
        Console.WriteLine("------------------------------");

        //se muestra la data
        MostrarLibros();

        //Solicito el codigo de libro para editar
        Console.Write("Ingrese el código del libro a editar: ");
        string codigoEditar = Console.ReadLine();


        //validamos si se encuentra el codigo con la metodo Find
        Libro libroParaEditar = biblioteca.Find(libro => libro.Codigo == codigoEditar);

        if (libroParaEditar != null)
        {

            //se imprime el libro encontrado
            Console.WriteLine("\nLibro encontrado");
            Console.WriteLine("----------------");
            Console.WriteLine("{0,-10} {1,-20} {2,-12} {3,-10} {4,-20}", "Código", "Título", "ISBN", "Edición", "Autor");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("{0, -10} {1,-20} {2, -15} {3, -10} {4, -20}", libroParaEditar.Codigo, libroParaEditar.Titulo, libroParaEditar.ISBN,libroParaEditar.Edicion, libroParaEditar.Autor);


            //se locita la nueva información
            Console.WriteLine("\nIngrese los nuevos datos:");

            Console.Write("Título: ");
            string nuevoTitulo = Console.ReadLine();

            Console.Write("ISBN: ");
            string nuevoISBN = Console.ReadLine();

            Console.Write("Edición: ");
            string nuevaEdicion = Console.ReadLine();

            Console.Write("Autor: ");
            string nuevoAutor = Console.ReadLine();

            libroParaEditar.Titulo = nuevoTitulo;
            libroParaEditar.ISBN = nuevoISBN;
            libroParaEditar.Edicion = nuevaEdicion;
            libroParaEditar.Autor = nuevoAutor;

            Console.WriteLine("Libro editado correctamente. Presiona una tecla para continuar...");
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }

        Console.ReadKey();
    }
}

class Libro
{
    public string Codigo { get; set; }
    public string Titulo { get; set; }
    public string ISBN { get; set; }
    public string Edicion { get; set; }
    public string Autor { get; set; }
}
