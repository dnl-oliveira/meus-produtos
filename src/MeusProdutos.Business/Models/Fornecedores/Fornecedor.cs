using System.Collections.Generic;
using MeusProdutos.Business.Core.Models;
using MeusProdutos.Business.Models.Fornecedores.Validations;
using MeusProdutos.Business.Models.Produtos;

namespace MeusProdutos.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public ICollection<Produto> Produtos { get; set; }

    }
}