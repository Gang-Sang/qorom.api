using AutoMapper;
using qorom.api.infrastructure.mongo.dataModel;
using ApiModel = qorom.api.model;

namespace qorom.api.infrastructure.mongo
{
    public class MongoMapperProfile : Profile
    {
        public MongoMapperProfile()
        {
            CreateMap<Forum, ApiModel.Forum>();
            CreateMap<ApiModel.Forum, Forum>();
        }
    }
}
