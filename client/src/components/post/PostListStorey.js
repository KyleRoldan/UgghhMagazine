import { useState, useEffect } from "react";
import PostCard from "./PostCard";
import { getPosts } from "../../managers/PostManager";


export default function PostListStorey({ detailsPostId }) {
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
    .filter(post => post.category.name === "Short Story")
    .slice(0, 4)
    .map(post => (
    <PostCard
      post={post}
      posts={posts}
      detailsPostId={detailsPostId}
      key={`post-${post.id}`}
    ></PostCard>
  ))}

    </>
  );
}
