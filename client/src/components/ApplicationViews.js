import React from "react";
import { Route, Routes } from "react-router-dom";
import { AuthorizedRoute } from "./auth/AuthorizedRoute";
import Login from "./auth/Login";
import Register from "./auth/Register";
import { OpinionView } from "./views/OpinionView";
import { PoetryView, WrittenWordView } from "./views/PoetryView";
import { ShortStoryView } from "./views/ShortStoryView";
import { LatestPostView } from "./views/LatestPostView";
import PostDetails from "./views/post/PostDetails";
import EditPost from "./views/post/edit/EditPost";


export default function ApplicationViews({ loggedInUser, setLoggedInUser }) {
  return (
    <Routes>
      <Route
        path=""
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <LatestPostView />
          </AuthorizedRoute>
        }
      />
      <Route
        path="login"
        element={<Login setLoggedInUser={setLoggedInUser} />}
      />
      <Route
        path="register"
        element={<Register setLoggedInUser={setLoggedInUser} />}
      />
      <Route
        path="opinion"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <OpinionView />
          </AuthorizedRoute>
        }
      />
      <Route
        path="poetry"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <PoetryView />
          </AuthorizedRoute>
        }
      />
      <Route
        path="shortStory"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <ShortStoryView />
          </AuthorizedRoute>
        }
      />
      {/* Add the route for post details */}
      <Route
        path="post/:id"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <PostDetails />
            
          </AuthorizedRoute>
        }
      />
       <Route
        path="post/:id/update"
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <EditPost />
          </AuthorizedRoute>
        }
      />
      <Route path="*" element={<p>Whoops, nothing here...</p>} />
    </Routes>
  );
}
