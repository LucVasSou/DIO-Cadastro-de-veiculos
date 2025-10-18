namespace MinimalApi.Infraestrutura.Db
{
    using Microsoft.EntityFrameworkCore;
    using MinimalApi.Dominio.Entidades;

    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configuracaoAppSettings;
        public DbContexto(IConfiguration configuracaoAppSettings)
        {
            _configuracaoAppSettings = configuracaoAppSettings;
        }

        public DbSet<Administrador> Administradores { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if( !optionsBuilder.IsConfigured )
            {
                var stringConexao = _configuracaoAppSettings.GetConnectionString("MySql")?.ToString();

                if (!string.IsNullOrEmpty(stringConexao))
                {
                    optionsBuilder.UseMySql(stringConexao,
                    ServerVersion.AutoDetect(stringConexao));
                }
            }
        }
    }
}