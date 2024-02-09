import React, { useEffect, useState } from 'react';
import "../views/viewsCss/LatestPost.css";
import sampleImg from "../../assets/sampleImg.png";
import latestOpinions from "../../assets/latestOpinions.png";
import Rectangle from "../../assets/Rectangle.jpg";

import { getPosts } from '../../managers/PostManager';
import PostListOpinion from '../post/PostListOpinion';
import PostListOpinionSecondary from '../post/PostListOpinionSecondary';

export const OpinionView = () => {
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
                    {/* <div className="dateBox">date</div> */}
                </div>
                <div className="titleBox">
                    <p>T I T L E</p>
                </div>
                {/* <div className="description">
                    jklknlnl
                </div> */}
            </div>




            <div className="right-side">
                        <div className="about_header_style">
                            <div className="about_header-category">
                                
                                <img className="aboutimg" src={latestOpinions} alt="logo" />
                                
                            </div>
                        </div>
                        <div className="about-image-box">
                    
                            <PostListOpinion />
                        </div>

                
                        </div>
                        </div>
    

    
        
                        <div className="splitImgHeaderBox-rectangle">
                    <img className="aboutImg-Header" src={Rectangle} alt="logo" />
                </div>

                 
 {/* <div className="about-image-box-secondary" ><PostListSecondary /></div> */}

         
 <div className="about-image-box-secondary" ><PostListOpinionSecondary /></div>



    </div>
    );
}
