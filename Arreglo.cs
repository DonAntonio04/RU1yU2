using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion1y2
{
    public class Arreglo
    {
        Producto[] productos = new Producto[3];
        public void Insertar(Producto valor,int posicion)
        {
            if(posicion < -1 || posicion> productos.Length)
            {
                Console.WriteLine("Ingrese un número valido");
            }
            Console.WriteLine($"El nombre {valor.Nombre} y precio {valor.Precio} se ha ingresado correctamente");
            productos[posicion] = valor;
        }
        public void Mostrar()
        {
           for(int i = 0; i < productos.Length; i++)
           {
                Console.WriteLine($"Posicion {i}: {productos[i]}");
           }
        }

        public void OrderCreciente()
        {
            for(int i=0; i < productos.Length - 1; i++)
            {
                for(int j=0; j < productos.Length - j + 1; j++)
                {
                    if (productos[j]?.Precio > productos[j+1]?.Precio)
                    {
                        Producto temp = productos[j];
                        productos[j] = productos[j+1];
                        productos[j+1] = temp;
                    } 
                }
            }
        }
        public void BuscarPrecio(int buscarPrecio)
        {
            bool encontrar = false;

           
                for (int i = 0; i < productos.Length; i++)
                {
                    if (productos[i].Precio == buscarPrecio)
                    {
                        Console.WriteLine($"El precion buscado {buscarPrecio} se ha encontrado");
                        encontrar = true;
                    }
                    
                }
                if(encontrar == false)
                {
                Console.WriteLine("No se encuentra");
               }
           
            


        }
    }
}
