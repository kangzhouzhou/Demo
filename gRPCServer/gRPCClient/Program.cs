using gRPC;
using Grpc.Core;
using Grpc.Net.Client;
using System;

namespace gRPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GrpcChannel channel = GrpcChannel.ForAddress("https://127.0.0.1:9999");
            Greeter.GreeterClient client = new Greeter.GreeterClient(channel);
            HelloRequest request = new HelloRequest();
            request.Names.Add("1");
            request.Names.Add("2");
            request.Names.Add("3");


        }
    }
}
