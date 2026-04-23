using Trackii.Models.GerenciaLobby;

namespace Trackii.Services.GerenciaLobby;

public class GerenciaLobbyService
{
    public GerenciaLobbyVm BuildLobby()
    {
        return new GerenciaLobbyVm
        {
            Title = "Gerencia",
            Subtitle = "Vista inicial simple y responsiva para comenzar la nueva etapa.",
            Sections =
            [
                new GerenciaLobbySectionVm
                {
                    Heading = "Punto de inicio",
                    Body = "Este lobby reemplaza temporalmente al tablero anterior para construir la nueva gerencia por módulos claros."
                },
                new GerenciaLobbySectionVm
                {
                    Heading = "Siguiente paso",
                    Body = "Aquí iremos agregando accesos y métricas de forma incremental con componentes reutilizables."
                },
                new GerenciaLobbySectionVm
                {
                    Heading = "Arquitectura limpia",
                    Body = "Los cambios nuevos se organizarán por carpetas de servicios, vistas y componentes, evitando lógica mezclada."
                }
            ]
        };
    }
}
