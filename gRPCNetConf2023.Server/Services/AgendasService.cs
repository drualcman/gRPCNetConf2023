using Grpc.Core;

namespace gRPCNetConf2023.Server.Services;

public class AgendasService : Agendas.AgendasBase
{
    public override Task<AgendasResponse> GetAgendas(AgendasRequest request, ServerCallContext context)
    {
        AgendasResponse response = new AgendasResponse();
        response.Agendas.Add(new AgendaResponse
        {
            Speaker = "Miguel Muñoz Serafín",
            CountryFlag = "mx",
            Date = "2023-12-04",
            Topic = "Leyendas de .NET"
        });
        response.Agendas.Add(new AgendaResponse
        {
            Speaker = "Josué Ricardo Pérez Altamirano",
            CountryFlag = "mx",
            Date = "2023-12-05",
            Topic = "Benchmark y Performance en .NET"
        });
        response.Agendas.Add(new AgendaResponse
        {
            Speaker = "Bryan Oroxón",
            CountryFlag = "mx",
            Date = "2023-12-06",
            Topic = "Blazor Hybrid Apps con .NET MAUI "
        });
        response.Agendas.Add(new AgendaResponse
        {
            Speaker = "Sergi Ortiz Gómez",
            CountryFlag = "es",
            Date = "2023-12-07",
            Topic = "Mejorando la Experiencia de Usuario en Aplicaciones Blazor"
        });
        response.Agendas.Add(new AgendaResponse
        {
            Speaker = "Víctor Ocharán",
            CountryFlag = "pe",
            Date = "2023-12-08",
            Topic = "Conociendo gRPC con .NET"
        });
        return Task.FromResult(response);
    }
}
