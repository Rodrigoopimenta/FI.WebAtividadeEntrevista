using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Beneficiários
    /// </summary>
    public class BeneficiáriosModel
    {
        public long Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// CPF do cliente
        /// </summary>
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CPF deve estar no formato 000.000.000-00.")]
        public string CPF { get; set; }

        /// <summary>
        /// Id do cliente
        /// </summary>
        [Required]
        public long IdCliente { get; set; }

    }    
}