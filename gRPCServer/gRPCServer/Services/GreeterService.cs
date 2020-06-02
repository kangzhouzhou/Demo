using gRPC;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer.Services
{
    public class GreeterService:Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.Run(() =>
            {
                HelloReply reply = new HelloReply();
                foreach (string item in request.Names)
                {
                    reply.Msgs.Add("hello=" + item);
                }
                return reply;
            });
        }

        public override Task SayGoodbye1(GoodbyeRequest request, IServerStreamWriter<GoodbyeReply> responseStream, ServerCallContext context)
        {
            return base.SayGoodbye1(request, responseStream, context);
        }

        public override Task<GoodbyeReply> SayGoodbye2(IAsyncStreamReader<GoodbyeRequest> requestStream, ServerCallContext context)
        {
            return base.SayGoodbye2(requestStream, context);
        }

        public override Task SayGoodbye3(IAsyncStreamReader<GoodbyeRequest> requestStream, IServerStreamWriter<GoodbyeReply> responseStream, ServerCallContext context)
        {
            return Task.CompletedTask;
        }

    }
}
