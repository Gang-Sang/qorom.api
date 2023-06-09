﻿using qorom.api.model;

namespace qorom.api.infrastructure.interfaces
{
    public interface IForumDataRepository
    {
        IReadOnlyList<Forum> GetForums();
        Forum GetForum(int id);
        void CreateForum(Forum forum);

        IReadOnlyList<Post> GetPostsForForum(int forumId);
        void CreatePost(int forumId, Post post);
        Post GetPost(int postId);
    }
}
