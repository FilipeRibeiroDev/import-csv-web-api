using Application.Helpers;
using Domain.Entidades;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task Add(IFormFile file)
        {
            var excel = new ExcelHelper<Produtos>(file);
            var produtos = excel.GetValues();

            await _repository.Add(produtos);
        }
    }
}
