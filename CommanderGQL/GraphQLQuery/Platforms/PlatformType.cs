using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace CommanderGQL.GraphQLQuery.Platforms
{
    public class PlatformType : ObjectType<Platform>
    {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            descriptor.Description("Representa qualquer tipo de software ou serviço que tenha linha de comando.");
            descriptor.Field(p => p.LicenseKey).Ignore();
            descriptor.Field(p => p.Commands)
                      .ResolveWith<Resolvers>(p => p.GetCommands(default!, default!))
                      .UseDbContext<AppDbContext>()
                      .Description("Essa é a lista de comandos disponíveis para esta plataforma");
        }

        private class Resolvers
        {           
            public IQueryable<Command> GetCommands(Platform platform, [ScopedService] AppDbContext context)
            {
                return context.Commands.Where(p => p.PlatformId == platform.Id);
            }
        }
    }
}