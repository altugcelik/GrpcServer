﻿using Grpc.Net.Client;

class Program
{
    static async Task Main(string[] args)
    {
        GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7180");
        GrpcServer.Greeter.GreeterClient client = new GrpcServer.Greeter.GreeterClient(channel);

        var request = new GrpcServer.HelloRequest
        {
            Name = "Altuğ"
        };

        var response = await client.SayHelloAsync(request);

        Console.WriteLine($"Response from server: {response.Message}");

        Console.ReadLine();
    }
}