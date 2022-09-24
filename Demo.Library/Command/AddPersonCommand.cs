using MediatR;
using Dto = Demo.Library.Dtos;

namespace Demo.Library.Command;

public record AddPersonCommand(Dto.Person model) : IRequest<Dto.Person>;
