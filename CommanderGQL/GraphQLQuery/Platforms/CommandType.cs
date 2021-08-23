using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace CommanderGQL.GraphQLQuery.Platforms
{
    public class CommandType : ObjectType<Command>
    {
         protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            descriptor.Description("Representa um comando para uma plataforma específica.");
            // descriptor.Field(p => p.LicenseKey).Ignore();
            descriptor.Field(p => p.Platform)
                      .ResolveWith<Resolvers>(p => p.GetPlatforms(default!, default!))
                      .UseDbContext<AppDbContext>()
                      .Description("Esta é a plataforma no qual o comando atual pode ser utilizado.");
        }
        
        private class Resolvers
        {           
            public Platform GetPlatforms(Command command, [ScopedService] AppDbContext context)
            {
                return context.Platforms.FirstOrDefault(p => p.Id == command.PlatformId);
            }
        }
    }
}