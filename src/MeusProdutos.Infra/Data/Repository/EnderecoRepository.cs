using System;
using System.Threading.Tasks;
using MeusProdutos.Business.Models.Fornecedores;
using MeusProdutos.Infra.Data.Context;

namespace MeusProdutos.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}