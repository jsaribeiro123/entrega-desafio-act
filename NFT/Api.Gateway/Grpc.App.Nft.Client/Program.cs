﻿using System.Threading.Tasks;
using Grpc.Net.Client;
using Grpc.App.Nft.Client;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7269");

var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "10 USD pela venda do NFT Garden Abstract" });

Console.WriteLine("Quando : " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();