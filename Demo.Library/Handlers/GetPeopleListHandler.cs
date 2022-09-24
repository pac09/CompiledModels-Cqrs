using Demo.Library.Data;
using Demo.Library.Models;
using Demo.Library.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Library.Handlers;

public class GetPeopleListHandler : IRequestHandler<GetPeopleListQuery, List<Person>>
{
    private readonly IDataRepository _dataRepository;

    public GetPeopleListHandler(IDataRepository dataRepository)
    {
        this._dataRepository = dataRepository;
    }

    public Task<List<Person>> Handle(GetPeopleListQuery request, CancellationToken cancellationToken) 
        => Task.FromResult(_dataRepository.GetPersons());
}
