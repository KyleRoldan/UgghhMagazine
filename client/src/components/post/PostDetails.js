import { useState, useEffect } from "react";
import "../views/viewsCss/LatestPost.css";
import { Link, useParams } from "react-router-dom";
import { getPostById } from "../../managers/PostManager";


export default function PostDetails({ loggedInUser }) {
  const { id } = useParams();
  const [post, setPost] = useState(null);

  useEffect(() => {
    getPostById(id).then(setPost);
  }, [id]);

  if (!post) {
    return (
      <div className="opinion">
        <h2>Post Details</h2>
        <div>No Post Detected</div>
      </div>
    );
  }

  // Check if the loggedInUser is the author of the post
  const isAuthor = loggedInUser && loggedInUser.id === post.userProfile.identityUserId;

  // Check if the loggedInUser has the "Admin" role
  const isAdmin = loggedInUser && loggedInUser.roles && loggedInUser.roles.includes("Admin");

  return (
    <div className="opinion">
      <h2>Post Details</h2>

      {!isAuthor && isAdmin && (
        <div>
          <Link to={`/post/${id}/update`}>
            <button>Edit</button>
          </Link>
        </div>
      )}

      <div>
        <div>
          <div>{post.title}</div>
          <div>Author: {post.author}</div>
          <div>Category: {post.category.name}</div>
          <div>Date: {post.date}</div>
        </div>
      </div>

      <h4>Body of Text</h4>
      <div>Content: {post.content}</div>

      
      <button>Like</button>




      
    
    </div>
  );
}
