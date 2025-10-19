using MinimalApi.Dominio.Entidades;
using MinimalApi.Dtos;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDto loginDto);
}