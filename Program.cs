namespace Recuperacion1y2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Arreglo arreglo = new Arreglo();
           
            for(int i =0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese el nombre del producto {i + 1}");
                string producto1 = Console.ReadLine();

                Console.WriteLine($"Ingrese el precio de producto {i + 1}");
                int precio1 = Convert.ToInt32( Console.ReadLine() );

                Producto InsertarProducto = new Producto(producto1, precio1);

                Console.WriteLine("Ingrese la posición");
                int posicion = Convert.ToInt32( Console.ReadLine() );

                arreglo.Insertar(InsertarProducto,posicion);
                
            }
            arreglo.Mostrar();

            arreglo.OrderCreciente();
            Console.WriteLine("La lista de los precios en creciente");
            arreglo.Mostrar();

            Console.WriteLine("Ingrese el precio a buscar");
            int precioBuscar = Convert.ToInt32( Console.ReadLine() );

            arreglo.BuscarPrecio(precioBuscar);

        }
    }
}