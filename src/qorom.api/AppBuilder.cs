using AutoMapper;
using MongoDB.Driver;
using qorom.api.infrastructure.interfaces;
using qorom.api.infrastructure.mongo;
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
            var mongoClientBuilder = new MongoClientBuilder(builder.Configuration);
            var client = mongoClientBuilder.SetupMongoDb();

            
            builder.Services.AddSingleton<IMongoClient>(client);
            builder.Services.AddAutoMapper(typeof(MongoMapperProfile));

            builder.Services.AddScoped<IForumDataRepository, MongoRepository>();
            builder.Services.AddScoped<IForumManager, ForumManager>();
            builder.Services.AddScoped<IPostManager, PostManager>();
        }

        
    }
}
