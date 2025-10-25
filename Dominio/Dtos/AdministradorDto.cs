
using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dtos;
public record AdministradorDto
{
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
    public Perfil? Perfil { get; set; } = default!;
}