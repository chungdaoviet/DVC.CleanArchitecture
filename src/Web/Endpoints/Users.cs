using DVC.CleanArchitecture.Infrastructure.Identity;

namespace DVC.CleanArchitecture.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapIdentityApi<ApplicationUser>();
    }
}
