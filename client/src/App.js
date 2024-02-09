import { useEffect, useState } from "react";
import "./App.css";



import NavBar from "./components/NavBar";
import ApplicationViews from "./components/ApplicationViews";
import { tryGetLoggedInUser } from "./managers/AuthManager";
import { useLocation } from "react-router-dom";


function App() {
  const [loggedInUser, setLoggedInUser] = useState();
  const location = useLocation();

  
  useEffect(() => {
    // user will be null if not authenticated
    tryGetLoggedInUser().then((user) => {
      setLoggedInUser(user);
      console.log(user)
    });
  }, []);

  // Wait to get a definite logged-in state before rendering
  if (loggedInUser === undefined) {
    return <p>Loading...</p>;
  }

  const isLoginPage = location.pathname === "/login";

  return (
    <>
      {/* Render NavBar only if it's not the login page */}
      {!isLoginPage && (
        <NavBar loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
      )}
      <ApplicationViews
        loggedInUser={loggedInUser}
        setLoggedInUser={setLoggedInUser}
      />
    </>
  );
}

export default App;

