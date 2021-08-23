using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;

namespace CommanderGQL.GraphQLQuery
{
    public interface IQuery
    {
        IQueryable<User> GetUser([ScopedService] AppDbContext context);
        IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context);
    }
}