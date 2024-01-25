import React, { useState } from "react";
import { register } from "../../managers/AuthManager";
import { Link, useNavigate } from "react-router-dom";

export default function Register({ setLoggedInUser }) {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [userName, setUserName] = useState("");
  const [email, setEmail] = useState("");
  const [address, setAddress] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");

  const [passwordMismatch, setPasswordMismatch] = useState(false);
  const [registrationFailure, setRegistrationFailure] = useState(false);

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();

    if (password !== confirmPassword) {
      setPasswordMismatch(true);
    } else {
      const newUser = {
        firstName,
        lastName,
        userName,
        email,
        address,
        password,
      };
      register(newUser).then((user) => {
        if (user) {
          setLoggedInUser(user);
          navigate("/");
        } else {
          setRegistrationFailure(true);
        }
      });
    }
  };

  return (
    <div className="container" style={{ maxWidth: "500px" }}>
      <h3>Sign Up</h3>
      <div>
        <label>First Name</label>
        <input
          type="text"
          value={firstName}
          onChange={(e) => setFirstName(e.target.value)}
        />
      </div>
      <div>
        <label>Last Name</label>
        <input
          type="text"
          value={lastName}
          onChange={(e) => setLastName(e.target.value)}
        />
      </div>
      <div>
        <label>Email</label>
        <input
          type="email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
      </div>
      <div>
        <label>User Name</label>
        <input
          type="text"
          value={userName}
          onChange={(e) => setUserName(e.target.value)}
        />
      </div>
      <div>
        <label>Address</label>
        <input
          type="text"
          value={address}
          onChange={(e) => setAddress(e.target.value)}
        />
      </div>
      <div>
        <label>Password</label>
        <input
          className={passwordMismatch ? "is-invalid" : ""}
          type="password"
          value={password}
          onChange={(e) => {
            setPasswordMismatch(false);
            setPassword(e.target.value);
          }}
        />
      </div>
      <div>
        <label>Confirm Password</label>
        <input
          className={passwordMismatch ? "is-invalid" : ""}
          type="password"
          value={confirmPassword}
          onChange={(e) => {
            setPasswordMismatch(false);
            setConfirmPassword(e.target.value);
          }}
        />
        {passwordMismatch && (
          <div style={{ color: "red" }}>Passwords do not match!</div>
        )}
      </div>
      <p style={{ color: "red" }} hidden={!registrationFailure}>
        Registration Failure
      </p>
      <button
        className="btn btn-primary"
        onClick={handleSubmit}
        disabled={passwordMismatch}
      >
        Register
      </button>
      <p>
        Already signed up? Log in <Link to="/login">here</Link>
      </p>
    </div>
  );
}
