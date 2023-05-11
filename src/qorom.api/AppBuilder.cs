using qorom.api.manager;
using qorom.api.manager.interfaces;

namespace qorom.api
{
    public class AppBuilder
    {
        public WebApplication Build(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            AddServices(builder);

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            return app;
        }

        private void AddServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IForumManager, ForumManager>();
            builder.Services.AddScoped<IPostManager, PostManager>();
        }
    }
}
