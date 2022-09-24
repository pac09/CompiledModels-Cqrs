using Demo.Library.CompiledModels;
using Demo.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Library.Data;

public class DataRepository : IDataRepository
{
    private readonly FinanceContext _context = new FinanceContext();
    private readonly FinanceContextModel _compiledContext = new FinanceContextModel();

    public Dtos.Person AddPerson(Dtos.Person person)
    {
        var personToInsert = new Person()
        {
            FirstName = person.FirstName,
            LastName = person.LastName, 
            Id = person.Id,
            Address = person.Address,
            CreationDate = DateTime.Now
        };
        _context.People.Add(personToInsert);

        return person;
    }

    public List<Models.Person> GetPersons()
    {
        var persons = _compiledQuery.Invoke(_context);
        var values = persons.ToListAsync();

        return values.Result;
    }

    #region PrivateMethods

    private static readonly Func<FinanceContext, IAsyncEnumerable<Person>> _compiledQuery
        = EF.CompileAsyncQuery(
            (FinanceContext _compiledContext) => _compiledContext.People);

    #endregion
}
