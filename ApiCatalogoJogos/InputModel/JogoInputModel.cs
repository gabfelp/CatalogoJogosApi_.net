using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve ter entre 3 e 100 chars")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve ter entre 1 e 100 chars")]
        public string Produtora { get; set; }
        [Required]
        [Range(1,1000, ErrorMessage = "O preço deve ser entre 1 real e 1000 reais")]
        public double Preco { get; set; }

    }
}
