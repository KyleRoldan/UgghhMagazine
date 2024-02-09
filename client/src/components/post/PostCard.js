// PostCard.js
import React from "react";
import { Link } from "react-router-dom";
import sampleImg from "../../assets/sampleImg.png";


export default function PostCard({ post }) {
  return (
    <div className="about-box">
      <Link to={`/post/${post.id}`}>
        <img className="aboutimg" src={sampleImg} alt="logo" />
      </Link>
      <div className="infoBox">
        <div className="categoryBox">{post.category.name}</div>
      </div>
      <div className="titleBox">
        <p>{post.title}</p>
      </div>
    </div>
  );
}
