using ATSProServer.Domain.AppEntities;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Queries.GetAllFirms;

public sealed record GetAllFirmQueryResponse(
    IList<Firm> Firms );

