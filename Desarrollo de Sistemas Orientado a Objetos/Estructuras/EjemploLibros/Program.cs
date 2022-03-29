using System;
namespace source
{
    class Program
    {
        public struct tLibro
        {
            public string titulo;
            public string autor;
            public string editorial;
            public int anio;
        };
        static void Main(string[] args)
        {
            var libroPreferido = new tLibro
            {
                titulo = "El mitico hombre-mes",
                autor = "Frederik P. Brooks, Jr",
                editorial = "Universidad de Carolina del Norte",
                anio = 1975
            };
            var otroLibro = new tLibro
            {
                titulo = "La clave es la servilleta",
                autor = "Dan Roam",
                editorial = "Editorial Norma",
                anio = 2009
            };
            Console.WriteLine("Libro Preferido");
            Console.WriteLine("Titulo del libro:" + libroPreferido.titulo);
            Console.WriteLine("Autor del libro: " + libroPreferido.autor);
            Console.WriteLine("Editado por " + libroPreferido.editorial);
            Console.WriteLine("A~no de Edicion:" + libroPreferido.anio);
            Console.WriteLine();
            Console.WriteLine("Otro buen libro");
            Console.WriteLine("Titulo del libro:" + otroLibro.titulo);
            Console.WriteLine("Autor del libro: " + otroLibro.autor);
            Console.WriteLine("Editado por " + otroLibro.editorial);
            Console.WriteLine("A~no de Edicion:" + otroLibro.anio);
        }
    }
}
