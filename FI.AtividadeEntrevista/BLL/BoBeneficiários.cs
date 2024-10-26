using FI.AtividadeEntrevista.DAL;
using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiários
    {
        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public long Incluir(DML.Beneficiários cliente)
        {
            DAL.DaoBeneficiários cli = new DAL.DaoBeneficiários();
            DAL.DaoBeneficiários daoBeneficiários = new DAL.DaoBeneficiários();
            var newBeneficiários = cli.Incluir(cliente);
            var beneficiarios = new Beneficiários();
            beneficiarios.IdCliente = newBeneficiários;
            beneficiarios.CPF = cliente.CPF; 
            beneficiarios.Nome = cliente.Nome;
            daoBeneficiários.Incluir(beneficiarios);
            return newBeneficiários;

        }

        /// <summary>
        /// Altera um cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public void Alterar(DML.Beneficiários cliente)
        {
            DAL.DaoBeneficiários cli = new DAL.DaoBeneficiários();
            DAL.DaoBeneficiários daoBeneficiários = new DAL.DaoBeneficiários();

                cli.Alterar(cliente);
                var beneficiarios = new Beneficiários();
                beneficiarios.IdCliente = cliente.Id;
                beneficiarios.CPF = cliente.CPF;
                beneficiarios.Nome = cliente.Nome;
                daoBeneficiários.Incluir(beneficiarios);
        }

        /// <summary>
        /// Consulta o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public DML.Beneficiários Consultar(long id)
        {
            DAL.DaoBeneficiários cli = new DAL.DaoBeneficiários();
            return cli.Consultar(id);
        }

        /// <summary>
        /// Excluir o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public void Excluir(long id)
        {
            DAL.DaoBeneficiários cli = new DAL.DaoBeneficiários();
            cli.Excluir(id);
        }

        /// <summary>
        /// Lista os clientes
        /// </summary>
        public List<DML.Beneficiários> Listar()
        {
            DAL.DaoBeneficiários cli = new DAL.DaoBeneficiários();
            return cli.Listar();
        }

    }
}
