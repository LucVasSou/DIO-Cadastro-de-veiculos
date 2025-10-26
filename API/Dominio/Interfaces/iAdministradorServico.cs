using MinimalApi.Dominio.Entidades;
using MinimalApi.Dtos;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDto loginDto);
    Administrador? Incluir(Administrador administrador);
    Administrador? BuscaPorId(int id);
    List<Administrador> Todos(int? pagina);
}