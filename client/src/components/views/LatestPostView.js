
import "../views/viewsCss/LatestPost.css"
import sampleImg from "../../assets/sampleImg.png"


export const LatestPostView = () => {




    return  <>

    
    
    
    <div className="mainBox">
    
    <div className="splitImgHeaderBox">
    {/* <img className="aboutImg-Header" src={sampleImg} alt="logo" />
     */}
    
    
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

            
            <div className="aboutSecondary-box">

            <img className="aboutimg" src={sampleImg} alt="logo" />

            <div className="infoSecondaryBox">


            <div className="categorySecondaryBox">C A T E G O R Y</div> 
            
            {/* <div className="dateBox">date</div> */}

            </div>

            <div className="titleSecondaryBox">
               <p>T I T L E</p>
            </div>


            {/* <div className="description">

            jklknlnl

            </div> */}
            
        </div>


            </div>








        </div>
    </div>
    
    
    </div>
</>

    
    
    
    
    
    
    
    }