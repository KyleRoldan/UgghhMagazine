import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { login } from "../../managers/AuthManager";
import "../auth/Auth.css";

export default function Login({ setLoggedInUser }) {
  const navigate = useNavigate();
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [failedLogin, setFailedLogin] = useState(false);

  const handleSubmit = (e) => {
    e.preventDefault();
    login(email, password).then((user) => {
      if (!user) {
        setFailedLogin(true);
      } else {
        setLoggedInUser(user);
        navigate("/");
      }
    });
  };

  return (
    <div className="loginContainer">
<div className="login-button">

      <button className="btn btn-primary" onClick={handleSubmit}>
        Login
      </button>
      
      </div>
    <div className="login-circle">
     

      <div className="email-input">
        <input
          className={failedLogin ? "is-invalid" : ""}
          type="text"
          placeholder="Email"
          value={email}
          onChange={(e) => {
            setFailedLogin(false);
            setEmail(e.target.value);
          }}
        />
      </div>


      <div className="password-input">
        <input
          className={failedLogin ? "is-invalid" : ""}
          type="password"
          placeholder="Password"
          value={password}
          onChange={(e) => {
            setFailedLogin(false);
            setPassword(e.target.value);
          }}
        />
        {failedLogin && <div className="invalid-feedback">Login failed.</div>}
      </div>

      

      <div className="login-register-link">
      <Link  to="/register">REGISTER</Link>
      </div>
      
      
      
      
      </div>



    </div>





  );
}
