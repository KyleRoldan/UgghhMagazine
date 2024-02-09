import { useState, useEffect } from "react";
import { getPosts } from "../../managers/PostManager";
import PostCardSecondary from "./PostCardSecondary";


export default function PostListSecondary({ detailsPostId }) {
  const [posts, setPosts] = useState([]);

  const getAllPosts = () => {
    getPosts().then(setPosts);
  };

  console.log(posts)

  useEffect(() => {
    getAllPosts();
  }, []);
  return (

    <>
      
      {posts
      .slice(4)
      .map((post) => (

        <PostCardSecondary
          post={post}
          posts={posts}
          detailsPostId={detailsPostId}
          key={`post-${post.id}`}
        ></PostCardSecondary>

      ))}
    </>
  );
}
