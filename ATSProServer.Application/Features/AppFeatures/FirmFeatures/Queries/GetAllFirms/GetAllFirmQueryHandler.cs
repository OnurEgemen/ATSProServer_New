using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Queries.GetAllFirms;

public sealed class GetAllFirmQueryHandler : IQueryHandler<GetAllFirmQuery, GetAllFirmQueryResponse>
{
    private readonly IFirmService _firmService;

    public GetAllFirmQueryHandler(IFirmService firmService)
    {
        _firmService = firmService;
    }

    public async Task<GetAllFirmQueryResponse> Handle(GetAllFirmQuery request, CancellationToken cancellationToken)
    {
        var result = _firmService.GetAll();
        return new GetAllFirmQueryResponse(await result.ToListAsync());
    }
}
