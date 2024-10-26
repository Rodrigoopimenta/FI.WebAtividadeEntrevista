using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.DML
{
    /// <summary>
    /// Classe de Beneficiários que representa o registo na tabela Beneficiários do Banco de Dados
    /// </summary>
    public class Beneficiários
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// CPF do cliente
        /// </summary>
        public string CPF { get; set; }
        /// <summary>
        /// Id do cliente
        /// </summary>
        public long IdCliente { get; set; }
    }    
}
