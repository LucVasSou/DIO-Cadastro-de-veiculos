using System.Data.Common;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.Dtos;
using MinimalApi.Infraestrutura.Db;

namespace MinimalApi.Dominio.Servicos;

public class VeiculoServico : IVeiculoServico
{
    private readonly DbContexto _contexto;
    public VeiculoServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public void Apagar(Veiculo veiculo)
    {
        _contexto.Veiculos.Remove(veiculo);
        _contexto.SaveChanges();
    }

    public void Atualizar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public Veiculo BuscaPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void Incluir(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public List<Veiculo> Todos(int pagina = 1, string? nome = null, string? marca = null)
    {
        throw new NotImplementedException();
    }
}