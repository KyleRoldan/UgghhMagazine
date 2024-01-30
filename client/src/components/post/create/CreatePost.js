import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { createPosts } from "../../../managers/PostManager";
import "../../views/viewsCss/LatestPost.css"
import { getCategories } from "../../../managers/CategoryManager";



export default function CreatePost({ loggedInUser }) {
  const [content, setContent] = useState("");
  const [author, setAuthor] = useState("");
  const [title, setTitle] = useState("");
  const [categoryId, setCategoryId] = useState(0);
  const [selectedCategory, setSelectedCategory] = useState("");
  const [categories, setCategories] = useState([]);

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    const newPost = {
      categoryId,
      content,
      author,
      title,
    };

    // Assuming you have a CreatePost function to create a new post
    createPosts(newPost).then(() => {
      navigate("/");
    });

    console.log(
      `new post submitted: ${newPost.content}, categoryId: ${newPost.categoryId}, author: ${newPost.author}, title: ${newPost.title}`,
    );
  };

  useEffect(() => {
    // Fetch posts and set them
    getCategories().then((category) => setCategories(category));
  }, []); // Make sure to pass an empty dependency array to useEffect

  return (
    <>
    
    <div className="opinion">
      <h2>Create a New Post</h2>
      
        <div>
          <label >Content</label>
          <input
            type="text"
            id="content"
            value={content}
            onChange={(e) => setContent(e.target.value)}
          />
        </div>
        <div>
          <label >Author</label>
          <input
            type="text"
            id="author"
            value={author}
            onChange={(e) => setAuthor(e.target.value)}
          />
        </div>
        <div>
          <label >Title</label>
          <input
            type="text"
            id="title"
            value={title}
            onChange={(e) => setTitle(e.target.value)}
          />
        </div>


        <div>

          <div>

          <div >Category</div>

          <select
            type="select"
            name="categoryId"
            value={categoryId}
            onChange={(e) => setCategoryId(Number(e.target.value))}
            >
            <option value="0">Select a Category</option>
            {categories.map((category) => (
              <option key={category.id} value={category.id}>
                           {category.name} 
              </option>
            ))}
          </select>


        </div>
          
        </div>

        <button onClick={handleSubmit} color="primary">
                            Submit
        </button>
      </div>
    </>
  );
}
