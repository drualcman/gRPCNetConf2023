using Grpc.Net.Client;
using gRPCNetConf2023.Client;
using Microsoft.AspNetCore.Components;

namespace gRPCNetConf2023.Blazor.Pages;

public partial class Greet
{
    [Inject] GrpcChannel Channel { get; set; }

    HelloReply Response = new();

    protected override async Task OnInitializedAsync() 
    {
        var client = new Greeter.GreeterClient(Channel);

        Response = await client.SayHelloAsync(new HelloRequest {  Name = "Sergi" });
    }

}
