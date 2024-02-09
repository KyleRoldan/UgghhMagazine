import React, { useEffect, useState } from 'react';
import "../views/viewsCss/LatestPost.css";
import sampleImg from "../../assets/sampleImg.png";
import Shortstories from "../../assets/Short-stories.png";
import Rectangle from "../../assets/Rectangle.jpg";

import { getPosts } from '../../managers/PostManager';
import PostListStorey from '../post/PostListStorey';
import PostListShortStorySecondary from '../post/PostListShortStorySecondary';





export const ShortStoryView = () => {
    const [posts, setPosts] = useState(null);

    useEffect(() => {
        getPosts().then(setPosts);
    }, []);

   

    return (
        <div className="mainBox">
            <div className="splitImgHeaderBox-opinion">
                   
                   </div>
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
                    <div className="about_header-category">
                                
                                <img className="aboutimg" src={Shortstories} alt="logo" />
                                
                            </div>
                    </div>
                    <div className="about-image-box">
                        {/* Pass opinionPosts to the PostList component */}
                       <PostListStorey />
                    </div>
                </div>
            </div>
            <div className="splitImgHeaderBox-rectangle">
                    <img className="aboutImg-Header" src={Rectangle} alt="logo" />
                </div>

                 
 <div className="about-image-box-secondary" ><PostListShortStorySecondary /></div>
        </div>
    );
}
