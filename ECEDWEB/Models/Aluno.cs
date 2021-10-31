using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECEDWEB.Models
{
    public class Aluno
    {
        [Key]
        public int idAluno { get; set; }
      
        public string NomeAluno { get; set; }
        
        public string Sexo { get; set; }
        
        public string NomeMae { get; set; }
      
        public string NomePai { get; set; }
       
        public string Responsavel { get; set; }
       
        public int TelefoneMae { get; set; }
      
        public string CorERaca { get; set; }
     
        public string DataNascimento { get; set; }
        
        public string EstadoCivil { get; set; }
       
        public string nacionalidade { get; set; }
        
        public string naturalidade { get; set; }
       
        public string UF { get; set; }
       
        public string Tipo { get; set; }

    }
}
