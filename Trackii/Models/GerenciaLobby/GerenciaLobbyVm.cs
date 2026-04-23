namespace Trackii.Models.GerenciaLobby;

public class GerenciaLobbyVm
{
    public string Title { get; init; } = "Gerencia";
    public string Subtitle { get; init; } = "Nuevo espacio de gerencia en construcción.";
    public IReadOnlyList<GerenciaLobbySectionVm> Sections { get; init; } = Array.Empty<GerenciaLobbySectionVm>();
}

public class GerenciaLobbySectionVm
{
    public string Heading { get; init; } = string.Empty;
    public string Body { get; init; } = string.Empty;
}
