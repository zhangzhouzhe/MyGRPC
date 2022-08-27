// See https://aka.ms/new-console-template for more information


using Grpc.Net.Client;
using MyGrpc;
using static MyGrpc.Greeter;

GrpcChannel grpcChannel = GrpcChannel.ForAddress("https://localhost:7150");
GreeterClient greeterClient = new GreeterClient(grpcChannel);

HelloReply helloReply = greeterClient.SayHello(new HelloRequest
{
    Name = "张三"
});


Console.WriteLine(helloReply.Message);
Console.ReadLine();
