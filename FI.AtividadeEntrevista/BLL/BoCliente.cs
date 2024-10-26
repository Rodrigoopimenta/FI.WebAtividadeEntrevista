using FI.AtividadeEntrevista.DAL;
using FI.AtividadeEntrevista.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoCliente
    {
        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public long Incluir(DML.Cliente cliente)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            DAL.DaoBeneficiários daoBeneficiários = new DAL.DaoBeneficiários();
            var cpfValido = ValidarCPF(cliente.CPF);
            var existeCPF = VerificarExistencia(cliente.CPF);
            if (cpfValido && !existeCPF)
            {
                var newCliente = cli.Incluir(cliente);
                var beneficiarios = new Beneficiários();
                beneficiarios.IdCliente = newCliente;
                beneficiarios.CPF = cliente.CPF; 
                beneficiarios.Nome = cliente.Nome;
                daoBeneficiários.Incluir(beneficiarios);
                return newCliente;
            }
            else throw new Exception("O CPF informado é inválido ou já está cadastrado.");
        }

        /// <summary>
        /// Altera um cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public void Alterar(DML.Cliente cliente)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            DAL.DaoBeneficiários daoBeneficiários = new DAL.DaoBeneficiários();
            var cpfValido = ValidarCPF(cliente.CPF);
            var existeCPF = VerificarExistencia(cliente.CPF);
            if (cpfValido && !existeCPF) 
            {
                cli.Alterar(cliente);
                var beneficiarios = new Beneficiários();
                beneficiarios.IdCliente = cliente.Id;
                beneficiarios.CPF = cliente.CPF;
                beneficiarios.Nome = cliente.Nome;
                daoBeneficiários.Incluir(beneficiarios);
            }
            else
            {
                throw new Exception("O CPF informado é inválido ou já está cadastrado.");
            }
        }

        /// <summary>
        /// Consulta o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public DML.Cliente Consultar(long id)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.Consultar(id);
        }

        /// <summary>
        /// Excluir o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public void Excluir(long id)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            cli.Excluir(id);
        }

        /// <summary>
        /// Lista os clientes
        /// </summary>
        public List<DML.Cliente> Listar()
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.Listar();
        }

        /// <summary>
        /// Lista os clientes
        /// </summary>
        public List<DML.Cliente> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.Pesquisa(iniciarEm,  quantidade, campoOrdenacao, crescente, out qtd);
        }

        /// <summary>
        /// VerificaExistencia
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool VerificarExistencia(string CPF)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.VerificarExistencia(CPF);
        }
        /// <summary>
        /// Função para Validar o código do CPF
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns>Retornar verdadeiro ou falso na função</returns>
        public bool ValidarCPF(string CPF)
        {
            DAL.DaoCliente cli = new DAL.DaoCliente();
            return cli.ValidarCPF(CPF);
        }
    }
}
