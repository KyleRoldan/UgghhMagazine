import React, { useEffect, useState } from 'react';
import "../views/viewsCss/LatestPost.css";
import sampleImg from "../../assets/sampleImg.png";

import { getPosts } from '../../managers/PostManager';
import PostListStorey from './post/PostListStorey';





export const ShortStoryView = () => {
    const [posts, setPosts] = useState(null);

    useEffect(() => {
        getPosts().then(setPosts);
    }, []);

   

    return (
        <div className="mainBox">
            <div className="about-whole-box">
                <div className="about-box">
                    <img className="aboutimg" src={sampleImg} alt="logo" />
                    <div className="infoBox">
                        <div className="categoryBox">C A T E G O R Y</div>
                    </div>
                    <div className="titleBox">
                        <p>T I T L E</p>
                    </div>
                </div>
                <div className="right-side">
                    <div className="about_header_style">
                        <div className="about_header">
                            Short Story
                        </div>
                    </div>
                    <div className="about-image-box">
                        {/* Pass opinionPosts to the PostList component */}
                       <PostListStorey />
                    </div>
                </div>
            </div>
        </div>
    );
}
