import { useEffect, useState } from "react";
import "./App.css";



import NavBar from "./components/NavBar";
import ApplicationViews from "./components/ApplicationViews";
import { tryGetLoggedInUser } from "./managers/AuthManager";


function App() {
  const [loggedInUser, setLoggedInUser] = useState();

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


  return (
    <>
      <NavBar loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
      <ApplicationViews
        loggedInUser={loggedInUser}
        setLoggedInUser={setLoggedInUser}
      />
    </>
  );
}

export default App;

