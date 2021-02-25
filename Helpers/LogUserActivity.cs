using FirepitAPI.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using FirepitAPI.Repositories.Interface;

namespace FirepitAPI.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            var username = resultContext.HttpContext.User.GetUsername();
            if (username == null) return;
            var uow = resultContext.HttpContext.RequestServices.GetService<IUnitOfWork>();
            if (uow == null) return;
            var user = await uow.UserRepository.GetUserByUsernameAsync(username);
            user.LastActive = DateTime.Now;
            await uow.Complete();

            //if (!resultContext.HttpContext.User.Identity.IsAuthenticated) return;

            //var userId = resultContext.HttpContext.User.GetUserId();
            //var repo = resultContext.HttpContext.RequestServices.GetService<IUsersRepository>();
            //var user = await repo.GetUserByIdAsync(userId);
            //user.LastActive = DateTime.Now;
            //await repo.SaveAllAsync();
        }
    }
}
