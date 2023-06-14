using qorom.api;
using qorom.api.model;
using qorom.api.manager.interfaces;

var app = new AppBuilder().Build(args);

app.MapGet("/", () => "Hello World!");
app.MapGet("/forum", (IForumManager manager) => manager.GetForums());
app.MapGet("/forum/{forumId}", (int forumId, IForumManager manager) => manager.GetForum(forumId));
app.MapPost("/forum", (Forum forum, IForumManager manager) => manager.CreateForum(forum));

app.MapGet("/forum/{forumId}/post/{pageNum}/{pageSize}", (int forumId, int? pageNum, int? pageSize, IPostManager manager) => manager.GetPostsForForum(forumId, pageNum, pageSize));
app.MapPost("/forum/{forumId}/post", (int forumId, Post post, IPostManager manager) => manager.CreatePost(forumId, post));

app.MapGet("/post/{postId}/{pageNum}/{pageSize}", (int postId, int? pageNum, int? pageSize, IPostManager manager) => manager.GetPost(postId,pageNum, pageSize));

app.Run();

