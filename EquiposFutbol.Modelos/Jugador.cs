using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposFutbol.Modelos
{
    public class Jugador
    {      
        public int Id { get; set; }
        public string nombreJugador { get; set; }
        public string domicilio { get; set; }
        public String telefono { get; set; }
        public string edad { get; set; }
        //relacion 
        public Equipo? equipo { get; set; }
        public int EquipoId { get; set; }
    }
}
