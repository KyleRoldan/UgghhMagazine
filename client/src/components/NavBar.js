import { useState } from "react";
import { Link, Link as RRLink } from "react-router-dom";
import { logout } from "../managers/AuthManager";
import navLogoImage from "../../src/assets/finalLogo.png"
import navIconImage from "../../src/assets/menu_icon.png"

import "./NavBar.css"

export default function MyDiv({ loggedInUser, setLoggedInUser }) {
  const [open, setOpen] = useState(false);

  const toggleDiv = () => setOpen(!open);

  

 

  const toggleDropdown = () => {
    setOpen(!open);
  };

  const handleServiceClick = () => {


    
    setOpen(false);
  };

  
  const isAdmin = loggedInUser && loggedInUser.roles && loggedInUser.roles.includes("Admin");

  

  return (
    
    
    
    <div className="navbar">

    <div className="userSection">

    {/* <div className="userProfilePic-box">
  {loggedInUser ? (
    // Display the username if loggedInUser is not null
    `Hey, ${loggedInUser.userName}`
  ) : (
    // Display a placeholder or handle the case when there is no loggedInUser
    "Hey, Guest"
  )}
</div> */}


        <div className="userBox">  </div>
     </div>


        <Link className="mr-auto" to="/">
        <div className="logoBox">
         <img className= "nav-logo" src={navLogoImage} alt="Dropdown Button" />
       </div>
        </Link>


        
<div className="nav-itemDropDown">
        {loggedInUser ? (

          <>

              <button onClick={toggleDiv} className="dropdown-button">
              <img className= "nav-Icon" src={navIconImage} alt="Dropdown Button" />
              </button>



            {open && (


              <div className = "dropdown-content">
                

            <Link className='link-tag' to="/">
            <div className="dropdown-item" onClick={() => handleServiceClick(1)}>
            H
            O 
            M 
            E
            
            </div>
            </Link>

            <Link className='link-tag' to="/opinion">
            <div className="dropdown-item" onClick={() => handleServiceClick(2)}>
           O
           P
           I
           N
           I
           O
           N
            </div>
            </Link>

            <Link className='link-tag' to="/poetry">
            <div className="dropdown-item" onClick={() => handleServiceClick(1)}>
            P 
            O  
            E
            T 
            R 
            Y 
            </div>
            </Link>


            <Link className='link-tag' to="/shortstory">
            <div className="dropdown-item" onClick={() => handleServiceClick(1)}>
            S  
            H  
            O 
            R 
            T 
            /  
            S 
            T 
            O 
            R 
            Y
            </div>
            </Link>

            {isAdmin && (
            <Link className='link-tag' to="/createPost">
            <div className="dropdown-item" onClick={() => handleServiceClick(1)}>
            C  
            R  
            E 
            A 
            T 
            E  
             
            P 
            O 
            S 
            T
            </div>
            </Link>
            )}





              
            <Link className='link-tag' to="/login"
              onClick={(e) => {
                e.preventDefault();
                setOpen(false);
                logout().then(() => {
                  setLoggedInUser(null);
                  setOpen(false);
                });
              }}
            >
              <div className="dropdown-item">
                
              L
              O 
              G 
              O 
              U 
              T

              </div>
            </Link>



                
              </div>
            )}
         

          </>

        ) : (


          <div>
            <div>
              <RRLink to="/login">
                <button color="primary">Login</button>
              </RRLink>
            </div>
          </div>



              
 
        )}

           </div>
          
      </div>

   


   
  );
}




