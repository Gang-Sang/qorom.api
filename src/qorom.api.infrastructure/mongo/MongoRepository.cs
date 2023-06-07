using AutoMapper;
using MongoDB.Driver;
using ApiModel = qorom.api.model;
using qorom.api.infrastructure.mongo.dataModel;
using qorom.api.infrastructure.interfaces;

namespace qorom.api.infrastructure.mongo
{
    public class MongoRepository : IForumDataRepository
    {
        private IMapper mapper { get; set; }
        private IMongoClient client { get; set; }

        public MongoRepository(IMapper _mapper, IMongoClient _client) 
        {
            client = _client;
            mapper = _mapper;
        }

        public IReadOnlyList<ApiModel.Forum> GetForums()
        {
            var collection = client.GetDatabase("qorom").GetCollection<Forum>("Forums").AsQueryable();
            return mapper.Map<List<Forum>, List<ApiModel.Forum>>(collection.ToList());
        }

        public void CreateForum(ApiModel.Forum forum)
        {
            var collection = client.GetDatabase("qorom").GetCollection<Forum>("Forums");
            collection.InsertOne(mapper.Map<ApiModel.Forum, Forum>(forum));
        }

        public void CreatePost(int forumId, ApiModel.Post post)
        {
            var collection = client.GetDatabase("qorom").GetCollection<Post>("Posts");
            collection.InsertOne(mapper.Map<ApiModel.Post, Post>(post));
        }

        public IReadOnlyList<ApiModel.Post> GetPostsForForum(int forumId)
        {
            var collection = client.GetDatabase("qorom").GetCollection<Post>("Posts");
            return mapper.Map<List<Post>, List<ApiModel.Post>>(collection.Find(x => x.ForumId == forumId).SortByDescending(x => x.Updated).ToList());
        }

        public ApiModel.Post GetPost(int postId)
        {
            var collection = client.GetDatabase("qorom").GetCollection<Post>("Posts");
            return mapper.Map<Post, ApiModel.Post>(collection.Find(x => x.PostId == postId).FirstOrDefault());
        }
    }
}
