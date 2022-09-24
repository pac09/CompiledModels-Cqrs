using System;
using Demo.Library.Models;
using Dto = Demo.Library.Dtos;

namespace Demo.Library.Data;

public interface IDataRepository
{
    List<Person> GetPersons();

    Dto.Person AddPerson(Dto.Person person);
}
