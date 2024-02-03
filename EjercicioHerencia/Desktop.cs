using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Desktop : Computadora
    {

        public string? TipoTorre { get; set; }
        public bool TieneMonitor { get; set; }

        public Desktop(string marca, string modelo, int memoriaRAMGB, double precio, string tipoTorre, bool tieneMonitor, int inventario)
        : base(marca, modelo, memoriaRAMGB, precio, inventario)
        {
            TipoTorre = tipoTorre;
            TieneMonitor = tieneMonitor;

        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Tipo de Torre: {TipoTorre}, Tiene Monitor: {(TieneMonitor ? "Sí" : "No")}");
        }

    }
}