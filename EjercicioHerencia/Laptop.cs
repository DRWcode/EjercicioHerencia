using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Laptop : Computadora
    {
        public double PesoLB {  get; set; }
        public double TamanioPantalla { get; set; }

        public Laptop(string marca, string modelo, int memoriaRAMGB, double precio, double pesoLB, double tamanoPantalla, int inventario)
     : base(marca, modelo, memoriaRAMGB, precio, inventario)
        {
            PesoLB = pesoLB;
            TamanioPantalla = tamanoPantalla;

        }
        
        // método para mostrar informacion de laptop, se llamara al metodo de la clase padre y luego se le 
        // agregaran los atributos propios
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Peso: {PesoLB} lb, Tamaño de Pantalla: {TamanioPantalla} pulgadas");
        }


    }
}
