using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Computadora
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public int MemoriaRAMGB { get; set; }
        public double Precio {  get; set; }
        public int Inventario { get; set; }


        public Computadora(string marca, string modelo, int memoriaRAMGB, double precio, int inventario)
        {
            Marca = marca;
            Modelo = modelo;
            MemoriaRAMGB = memoriaRAMGB;
            Precio = precio;
            Inventario = inventario;

        }

        public virtual void Info()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Memoria RAM: {MemoriaRAMGB}GB, Precio: ${Precio}");

        }

        public int ObetenerInvetario()

        {
            return Inventario;
        }
            
    }
}
