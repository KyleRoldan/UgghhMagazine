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
    <div className="container" style={{ maxWidth: "500px" }}>
      <h3>Login</h3>
      <div>
        <label>Email</label>
        <input
          className={failedLogin ? "is-invalid" : ""}
          type="text"
          value={email}
          onChange={(e) => {
            setFailedLogin(false);
            setEmail(e.target.value);
          }}
        />
      </div>
      <div>
        <label>Password</label>
        <input
          className={failedLogin ? "is-invalid" : ""}
          type="password"
          value={password}
          onChange={(e) => {
            setFailedLogin(false);
            setPassword(e.target.value);
          }}
        />
        {failedLogin && <div className="invalid-feedback">Login failed.</div>}
      </div>

      <button className="btn btn-primary" onClick={handleSubmit}>
        Login
      </button>
      <p>
        Not signed up? Register <Link to="/register">here</Link>
      </p>
    </div>
  );
}
