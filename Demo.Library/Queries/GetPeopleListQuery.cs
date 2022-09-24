using Demo.Library.Models;
using MediatR;

namespace Demo.Library.Queries;

public record GetPeopleListQuery() : IRequest<List<Person>>;
