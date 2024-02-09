import { useState, useEffect } from "react";
import "../views/viewsCss/LatestPost.css";
import { Link, useParams } from "react-router-dom";
import { getPostById } from "../../managers/PostManager";
import { createLike, deleteLike, getLikeRelationship } from "../../managers/LikeManager";
import editImage from '../../../src/assets/edit.png'
import heartImage from "../../../src/assets/heart.png"
import heartImageTwo from "../../../src/assets/heart2.png"

export default function PostDetails({ loggedInUser }) {
  const { id } = useParams();
  const [post, setPost] = useState(null);
  const [postLike, setPostLike] = useState();
  const [currentlyLiked, setCurrentlyLiked] = useState(false);

  useEffect(() => {
    getLikeRelationship(id, loggedInUser.id).then((likes) => {
      if (likes && likes.length > 0) {
        setPostLike(likes[0]);
        setCurrentlyLiked(true);
      } else {
        setPostLike(null);
        setCurrentlyLiked(false);
      }
    });
  }, [id, loggedInUser.id]);

  console.log(postLike)

  const like = () => {
    if (!postLike) {
      createLike(id, loggedInUser.id)
        .then(() => {
          setCurrentlyLiked(true);
          return getLikeRelationship(id, loggedInUser.id);
        })
        .then((likes) => setPostLike(likes[0]))
        .catch((error) => console.error("Error liking post:", error));
    }
  };
  
  const unlike = () => {
    if (postLike) {
      deleteLike(postLike.postId, postLike.userProfileId)
        .then(() => {
          setCurrentlyLiked(false);
          return getLikeRelationship(id, loggedInUser.id);
        })
        .then((likes) => setPostLike(likes[0]))
        .catch((error) => console.error("Error unliking post:", error));
    }
  };

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

  const isAdmin = loggedInUser && loggedInUser.roles && loggedInUser.roles.includes("Admin");

  return (
    <div className="post-details">
      <div className="imageBox">
        {/* {post.images[1] && ( */}
          {/* <img  alt="no upload yet" className="image_Display" /> */}
          <div className="image_Display"></div>
        {/* )} */}
        {/* {post.images[2] && ( */}
          {/* <img alt="no upload yet" className="image_Display" /> */}
          <div className="image_Display"></div>
        {/* )} */}
        {/* {post.images[3] && ( */}
          {/* <img alt="no upload yet" className="image_Display" /> */}
          <div className="image_Display"></div>
        {/* )} */}
      </div>

      <div className="item-details-info-box">
        <div className="admin-item-details-etsy">
          <div className="admin-buying-favorite-box">
            
             <div>Date: {post.date}</div>
             <div className="likedBox">
        {currentlyLiked ? (
          <button className="icon-button" onClick={() => unlike()}><img className= "nav-Icon" src={heartImage} alt="button" /></button>
        ) : (
          <button className="icon-button" onClick={() => like()}><img className= "nav-Icon" src={heartImageTwo} alt="button" /></button>
        )}
      </div>
            {isAdmin && (
              <div>
                <Link to={`/post/${id}/update`}>
                  <button className="icon-button">
              <img className= "nav-Icon" src={editImage} alt="button" />
               </button>
               </Link>
              </div>
            )}
          </div>
          <h1>{post.title}</h1>
          <p className="opaque-text">{post.category.name}</p>
         
          <p className="item-description">{post.content}</p>
        </div>
        <div className="imageBox_Extra">
          {/* {post.images[4] && ( */}
            {/* <img alt="no upload yet" className="image_Display_Extra" /> */}
            <div className="image_Display_Extra"></div>
          {/* )} */}
          {/* {post.images[5] && ( */}
            {/* <img  alt="no upload yet" className="image_Display_Extra" /> */}
            <div className="image_Display_Extra"></div>
          {/* )} */}
        </div>
      </div>

     
    </div>
  );
}
