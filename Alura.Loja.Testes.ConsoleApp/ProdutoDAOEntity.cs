using Alura.Loja.Testes.ConsoleApp;
using System.Collections.Generic;
using System;
using System.Linq;

class ProdutoDAOEntity : IProdutoDAO, IDisposable
{
    private LojaContext contexto;
    public void Adicionar(Produto p)
    {
        contexto.Produtos.Add(p);
        contexto.SaveChanges();
    }

    public void Atualizar(Produto p)
    {
        contexto.Produtos.Update(p);
        contexto.SaveChanges();
    }

    public void Dispose()
    {
        contexto.Dispose();
    }

    public IList<Produto> Produtos()
    {
        return contexto.Produtos.ToList();
    }

    public void Remover(Produto p)
    {
        contexto.Produtos.Remove(p);
        contexto.SaveChanges();
    }
}
