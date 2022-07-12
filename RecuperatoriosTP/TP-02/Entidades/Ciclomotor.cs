using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor( EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        public new ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(this.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
