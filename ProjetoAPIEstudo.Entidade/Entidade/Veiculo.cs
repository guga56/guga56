using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAPIEstudo.Entidade.Entidade
{
    [Table("tb_Veiculo")]
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVeiculo { get; set; }

        public string NomeVeiculo { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

        public int Id_Cliente { get; set; }

        [ForeignKey("Id_Cliente")]
        public Cliente Cliente { get; set; }
    }
}
