using System.ComponentModel.DataAnnotations;

namespace EquiposFutbol.Modelos
{
    public class Equipo
    {   
        public int Id { get; set; }
        public string nombreEquipo { get; set; }
        public string DT { get; set; }
        public int numeroJugadores { get; set; }

        //relacion 
        public List<Jugador>? Jugadores { get; set; }
    }
}