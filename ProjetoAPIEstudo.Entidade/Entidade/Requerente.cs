using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAPIEstudo.Entidade.Entidade
{
    [Table("tb_Requerente")]
    public class Requerente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRequerente { get; set; }

        public string NomeRequerente { get; set; }

        public string EmailRequerente { get; set; }

        public int Id_Veiculo { get; set; }

        [ForeignKey("Id_Veiculo")]
        public Veiculo Veiculo { get; set; }
    }
}
