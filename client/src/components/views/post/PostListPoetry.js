import { useState, useEffect } from "react";
import PostCard from "./PostCard";
import { getPosts } from "../../../managers/PostManager";


export default function PostListPoetry({ detailsPostId }) {
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
      {posts.map((post) => {
        // Check if the post has a category name of "Short Storey"
        if (post.category.name === "Poetry") {
          return (
            <PostCard
              post={post}
              posts={posts}
              detailsPostId={detailsPostId}
              key={`post-${post.id}`}
            ></PostCard>
          );
        }
        // If not, return null (or an empty fragment) to skip rendering
        return null;
      })}
    </>
  );
}
