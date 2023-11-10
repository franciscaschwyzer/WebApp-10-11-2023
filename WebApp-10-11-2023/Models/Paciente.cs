using System.ComponentModel.DataAnnotations;

namespace WebApp_10_11_2023.Models
{
    public class Paciente
    {
        [Key]

        public int idPaciente { get; set; }

        public string nomePaciente { get; set; }

        public string sobrenomePaciente { get; set; }
    }
}
