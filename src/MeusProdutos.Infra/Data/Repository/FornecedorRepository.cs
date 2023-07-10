﻿using System;
using System.Data.Entity;
using System.Threading.Tasks;
using MeusProdutos.Business.Models.Fornecedores;
using MeusProdutos.Infra.Data.Context;

namespace MeusProdutos.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context){}

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .Include(f=>f.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}