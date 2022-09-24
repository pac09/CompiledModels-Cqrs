using Demo.Library.Command;
using Demo.Library.Data;
using Demo.Library.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto = Demo.Library.Dtos;

namespace Demo.Library.Handlers;

public class AddPersonHandler : IRequestHandler<AddPersonCommand, Dto.Person>
{
    private readonly IDataRepository _dataRepository;

    public AddPersonHandler(IDataRepository dataRepository) 
    {
        this._dataRepository = dataRepository;
    }

    public Task<Person> Handle(AddPersonCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_dataRepository.AddPerson(request.model));
    }
}
