using Domain.Entidades;
using Domain.Interfaces.Repositories;
using EFCore.BulkExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoDbContext _db;

        public ProdutoRepository(ProdutoDbContext db)
        {
            _db = db;
        }

        public async Task Add(List<Produtos> produtos)
        {
           await _db.BulkInsertAsync(produtos);
        }
    }
}
