using Microsoft.Extensions.DependencyInjection;
using SistemaControleAdvocaticio.Dados;
using SistemaControleAdvocaticio.Dados.Repositorio;
using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Repositorio;
using SistemaControleAdvocaticio.Dominio.Interfaces.Servico;
using SistemaControleAdvocaticioServico.Servico;

namespace SistemaControleAdvocaticio.Apresentacao.InjecaoDependencias
{
    public static class MapeamentoInjecaoDependencia
    {

        public static IServiceCollection MapearDependencias(this IServiceCollection services)
        {
            #region REPOSITORIO
            services.AddScoped<ContextoMySql>();
            services.AddScoped<IRepositorioBase<Agendamento>, RepositorioBase<Agendamento>>();
            services.AddScoped<IRepositorioBase<Cliente>, RepositorioBase<Cliente>>();
            services.AddScoped<IRepositorioBase<Pagamento>, RepositorioBase<Pagamento>>();
            services.AddScoped<IRepositorioBase<Parcela>, RepositorioBase<Parcela>>();
            services.AddScoped<IRepositorioBase<Processo>, RepositorioBase<Processo>>();
            services.AddScoped<IRepositorioBase<TipoAgendamento>, RepositorioBase<TipoAgendamento>>();
            services.AddScoped<IRepositorioAgendamento, RepositorioAgendamento>();
            services.AddScoped<IRepositorioCliente, RepositorioCliente>();
            services.AddScoped<IRepositorioPagamento, RepositorioPagamento>();
            services.AddScoped<IRepositorioParcela, RepositorioParcela>();
            services.AddScoped<IRepositorioProcesso, RepositorioProcesso>();
            services.AddScoped<IRepositorioTipoAgendamento, RepositorioTipoAgendamento>();
            services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();
            #endregion REPOSITORIO

            #region SERVIÇO
            services.AddScoped<IServicoAgendamento, ServicoAgendamento>();
            services.AddScoped<IServicoCliente, ServicoCliente>();
            services.AddScoped<IServicoPagamento, ServicoPagamento>();
            services.AddScoped<IServicoParcela, ServicoParcela>();
            services.AddScoped<IServicoProcesso, ServicoProcesso>();
            services.AddScoped<IServicoTipoAgendamento, ServicoTipoAgendamento>();
            services.AddScoped<IServicoUsuario, ServicoUsuario>();
            #endregion SERVIÇO

            return services;
        }

    }
}
