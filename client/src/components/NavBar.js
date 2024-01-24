import React, { useEffect, useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { getAllUsers } from "../../services/FetchCalls";

import navIconImage from "../../assets/menu_icon.png";
import navLogoImage from "../../assets/ramblingsvintagelogo.png";
import "./NavBar.css";

export default function NavBar({ loggedInUser, setLoggedInUser }) {
  const navigate = useNavigate();
  const [isDropdownOpen, setIsDropdownOpen] = useState(false);
  const [allUsers, setAllUsers] = useState([]);

  useEffect(() => {
    getAllUsers().then((usersArray) => {
      setAllUsers(usersArray);
    });
  }, []);

  const toggleDropdown = () => {
    setIsDropdownOpen(!isDropdownOpen);
  };

  const handleServiceClick = () => {
    // Optionally, you can close the dropdown by setting isDropdownOpen to false
    setIsDropdownOpen(false);
  };

  const userEmail = allUsers
    .filter((user) => user.id === loggedInUser.id) // Use loggedInUser instead of currentUser
    .map((user) => user.fullName);

  return (
    <div className="navbar">
      <div className="userSection">
        <div className="userProfilePic-box">
          {/* <img className="userProfilePic" alt="User Profile Pic" src={navIconImage}/> */}
          Hey,
        </div>
        <div className="userBox">{userEmail}</div>
      </div>

      <div className="logoBox">
        <img className="nav-logo" src={navLogoImage} alt="Dropdown Button" />
      </div>

      <div className="nav-itemDropDown">
        <button onClick={toggleDropdown} className="dropdown-button">
          <img className="nav-Icon" src={navIconImage} alt="Dropdown Button" />
        </button>
        {isDropdownOpen && (
          <div className="dropdown-content">
            <Link className="link-tag" to="/items">
              <div className="dropdown-item" onClick={() => handleServiceClick(1)}>
                Home
              </div>
            </Link>
            <Link className="link-tag" to="/addItem">
              <div className="dropdown-item" onClick={() => handleServiceClick(2)}>
                Add Item
              </div>
            </Link>
            {localStorage.getItem("ramblings_user") ? (
              <Link
                className="link-tag"
                to=""
                onClick={() => {
                  localStorage.removeItem("ramblings_user");
                  navigate("/", { replace: true });
                }}
              >
                <div className="dropdown-item">Logout</div>
              </Link>
            ) : (
              ""
            )}
          </div>
        )}
      </div>
    </div>
  );
}
