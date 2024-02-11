import React, { useState } from "react";
import { register } from "../../managers/AuthManager";
import { Link, useNavigate } from "react-router-dom";
import "../auth/Auth.css";

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
    <div className="registerContainer">
      <div className="innerRegisterContainer">
        <div className="innerRegisterTop">
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
        <div className="innerRegisterBottom">
      <h3>Sign Up</h3>
      <div className="email-input-two">
        <input
          type="text"
          placeholder="First Name"
          value={firstName}
          onChange={(e) => setFirstName(e.target.value)}
        />
      </div>
      <div className="email-input-two">
        <input
          type="text"
          placeholder="Last Name"
          value={lastName}
          onChange={(e) => setLastName(e.target.value)}
        />
      </div>
      <div className="email-input-two">
        <input
          type="email"
          placeholder="Email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
      </div>
      <div className="email-input-two">
        <input
          type="text"
          placeholder="User Name"
          value={userName}
          onChange={(e) => setUserName(e.target.value)}
        />
      </div>
      <div className="email-input-two">
        <input
          type="text"
          placeholder="Address"
          value={address}
          onChange={(e) => setAddress(e.target.value)}
        />
      </div>
      <div className="email-input-two">
        <input
          className={passwordMismatch ? "is-invalid" : ""}
          type="password"
          placeholder="Password"
          value={password}
          onChange={(e) => {
            setPasswordMismatch(false);
            setPassword(e.target.value);
          }}
        />
      </div>
      <div className="email-input-two">
        <input
          className={passwordMismatch ? "is-invalid" : ""}
          placeholder="Confirm Password"
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
        </div>
      </div>
    </div>
  );
}
