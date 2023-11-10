using System.ComponentModel.DataAnnotations;

namespace WebApp_10_11_2023.Models
{
    public class ConsultaModel : Paciente
    {
        [Key]

        public int IdConsulta { get; set; }

        public int IdPaciente { get; set; }

        public string dataConsulta { get; set; }

        public string fichaConsulta { get; set; }

        public List<Paciente> ListaPacientes { get; set; }
    }
}
