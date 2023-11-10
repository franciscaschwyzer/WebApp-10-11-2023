using System.ComponentModel.DataAnnotations;

namespace WebApp_10_11_2023.Models
{
    public class Consulta
    {
        [Key]

        public int IdConsulta { get; set; }

        public int IdPaciente { get; set; }

        public string dataConsulta { get; set; }

        public string fichaConsulta { get; set; }
    }
}
