using Grpc.Core;
using PB_Server;

namespace PB_Server.Services;

public class SumService : PB_Server.SumService.SumServiceBase
{
    private readonly ILogger<SumService> _logger;
    public SumService(ILogger<SumService> logger)
    {
        _logger = logger;
    }

    public override Task<NumbersResponse> Summing(NumbersRequest request, ServerCallContext context)
    {
        return Task.FromResult(new NumbersResponse
        {
            Sum = request.Number1+request.Number2
        });
    }
}
