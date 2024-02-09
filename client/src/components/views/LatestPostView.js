import React, { useState } from 'react';
import "../views/viewsCss/LatestPost.css";
import sampleImg from "../../assets/sampleImg.png";
import mainHeader from "../../assets/mainHeader.jpg";

import PostList from '../post/PostList';

import latestPosts from "../../assets/latestPosts.png"
import PostListSecondary from '../post/PostListSecondary';
import Rectangle from "../../assets/Rectangle.jpg"




export const LatestPostView = () => {
    // const [detailsPostId, setDetailsPostId] = useState(null);

    return (
        <>
            <div className="mainBox">
                <div className="splitImgHeaderBox">
                    <img className="aboutImg-Header" src={mainHeader} alt="logo" />
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
                            <div className="about_header">
                                
                                <img className="aboutimg" src={latestPosts} alt="logo" />
                                
                            </div>
                        </div>
                        <div className="about-image-box">
                    
                            <PostList />
                        </div>

                
                        </div>

                            
                </div>
            

            
                
                <div className="splitImgHeaderBox-rectangle">
                    <img className="aboutImg-Header" src={Rectangle} alt="logo" />
                </div>

                 
 <div className="about-image-box-secondary" ><PostListSecondary /></div>



            </div>
        </>
    );
}
