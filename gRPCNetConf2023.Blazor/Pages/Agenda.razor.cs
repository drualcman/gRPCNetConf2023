using Grpc.Net.Client;
using gRPCNetConf2023.Client;
using Microsoft.AspNetCore.Components;

namespace gRPCNetConf2023.Blazor.Pages;

public partial class Agenda
{
    [Inject] GrpcChannel Channel { get; set; }

    AgendasResponse Response = new();

    protected override async Task OnInitializedAsync() 
    {
        var client = new Agendas.AgendasClient(Channel);

        Response = await client.GetAgendasAsync(new AgendasRequest { });
    }
}
