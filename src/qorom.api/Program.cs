using qorom.api;
using qorom.api.manager.interfaces;

var app = new AppBuilder().Build(args);

app.MapGet("/", () => "Hello World!");
app.MapGet("/forums", (IForumManager manager) => manager.GetForums());
app.MapGet("/forum/{forumId}", (int forumId, IForumManager manager) => manager.GetForum(forumId));
app.MapGet("/forum/{forumId}/post", (int forumId, int? pageNum, int? pageSize, IPostManager manager) => manager.GetPostsForForum(forumId, pageNum, pageSize));
app.MapGet("/post/{postId}", (int postId, int? pageNum, int? pageSize, IPostManager manager) => manager.GetPost(postId, pageNum, pageSize));

app.Run();

