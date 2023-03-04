using ATSProServer.Application.Messaging;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Queries.GetAllFirms;

public sealed record GetAllFirmQuery() : IQuery<GetAllFirmQueryResponse>;
