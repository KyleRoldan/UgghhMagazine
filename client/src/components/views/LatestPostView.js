import React, { useState } from 'react';
import "../views/viewsCss/LatestPost.css";
import sampleImg from "../../assets/sampleImg.png";
import PostList from './post/PostList';

export const LatestPostView = () => {
    // const [detailsPostId, setDetailsPostId] = useState(null);

    return (
        <>
            <div className="mainBox">
                <div className="splitImgHeaderBox">
                    {/* <img className="aboutImg-Header" src={sampleImg} alt="logo" /> */}
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
                                LATEST POST'S
                            </div>
                        </div>
                        <div className="about-image-box">
                            {/* Pass setDetailsPostId to PostList */}
                            <PostList />
                        </div>
                        
                    </div>
                </div>
            </div>
        </>
    );
}
