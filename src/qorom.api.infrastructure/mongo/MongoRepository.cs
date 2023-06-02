using Microsoft.Extensions.Configuration;
using qorom.api.infrastructure.mongo.dataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using AutoMapper;
using ApiModel = qorom.api.model;

namespace qorom.api.infrastructure.mongo
{
    public class MongoRepository
    {
        private IMapper mapper { get; set; }
        private IMongoClient client { get; set; }

        public MongoRepository(IMapper _mapper, IMongoClient _client) 
        {
            client = _client;
            mapper = _mapper;
        }

        public ApiModel.Forum[] GetForums()
        {
            var collection = client.GetDatabase("qorom").GetCollection<Forum>("Forums").AsQueryable();

            return mapper.Map<Forum[], ApiModel.Forum[]>(collection.ToArray());
        }

        public void CreateForum(ApiModel.Forum forum)
        {
            var collection = client.GetDatabase("qorom").GetCollection<Forum>("Forums");
            collection.InsertOne(mapper.Map<ApiModel.Forum, Forum>(forum));
        }
    }
}
