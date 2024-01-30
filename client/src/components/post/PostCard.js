// PostCard.js
import React from "react";
import { Link } from "react-router-dom";
import sampleImg from "../../assets/sampleImg.png";


export default function PostCard({ post }) {
  return (
    <div className="aboutSecondary-box">
      <Link to={`/post/${post.id}`}>
        <img className="aboutimg" src={sampleImg} alt="logo" />
      </Link>
      <div className="infoSecondaryBox">
        <div className="categorySecondaryBox">{post.category.name}</div>
      </div>
      <div className="titleSecondaryBox">
        <p>{post.title}</p>
      </div>
    </div>
  );
}
