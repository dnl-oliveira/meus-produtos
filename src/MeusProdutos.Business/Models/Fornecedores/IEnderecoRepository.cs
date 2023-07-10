using System;
using System.Threading.Tasks;
using MeusProdutos.Business.Core.Data;

namespace MeusProdutos.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}