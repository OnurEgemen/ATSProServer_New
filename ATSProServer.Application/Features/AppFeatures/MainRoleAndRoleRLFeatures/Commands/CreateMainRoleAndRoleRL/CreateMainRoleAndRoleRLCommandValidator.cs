using FluentValidation;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;

public sealed class CreateMainRoleAndRoleRLCommandValidator : AbstractValidator<CreateMainRoleAndRoleRLCommand>
{
	public CreateMainRoleAndRoleRLCommandValidator()
	{
		RuleFor(x=>x.RoleId).NotEmpty().WithMessage("Rol Seçilmelidir!");
		RuleFor(x=>x.RoleId).NotNull().WithMessage("Rol Seçilmelidir!");
		RuleFor(x=>x.RoleId).NotEmpty().WithMessage("Ana Rol Seçilmelidir!");
		RuleFor(x=>x.RoleId).NotNull().WithMessage("Ana Rol Seçilmelidir!");
	}
}
