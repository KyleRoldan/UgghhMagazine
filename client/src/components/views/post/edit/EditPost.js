// Import other necessary modules

import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { editPosts, getPostById,  } from "../../../../managers/PostManager";
import { getCategories } from "../../../../managers/CategoryManager";
import "../../../views/viewsCss/LatestPost.css";

export default function EditPost() {
  const navigate = useNavigate();
  const { id } = useParams();

  const [post, setPost] = useState({ title: "", author: "", content: "", categoryId: null });
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    getPostById(id).then((data) => {
      setPost(data);
    });
  }, [id]);

  useEffect(() => {
    
    getCategories().then((categories) => setCategories(categories));
  }, []);

  const handleInputChange = (e) => {
    const { name, value } = e.target;

    
   
      setPost((prevPost) => ({
        ...prevPost,
        [name]: value,
      }));
    
  };

  const submit = () => {
    const { title, categoryId, content, author } = post; 
    const updatedPost = {
      
      title,
      categoryId,
      content,
      author,
    };

    console.log(updatedPost);

    editPosts(updatedPost).then(() => {
      navigate(`/post/${id}`);
    });
  };
  

  return (
    <div className="opinion">
      <h4>Update</h4>
      <div>
        {/* Your input fields and select dropdown */}
        <div>
          <label htmlFor="postTitle">Title</label>
          <input
            type="text"
            placeholder="Title"
            name="title"
            value={post.title}
            onChange={handleInputChange}
          />
        </div>

        <div>
          <label htmlFor="author">Author</label>
          <input
            placeholder="Author"
            type="text"
            name="author"
            value={post.author}
            onChange={handleInputChange}
          />
        </div>

        <div>
          <label htmlFor="content">Content</label>
          <input
            placeholder="Content"
            type="text"
            name="content"
            value={post.content}
            onChange={handleInputChange}
          />
        </div>

        <div>
          <label htmlFor="categoryId">Category</label>
          <select
            name="categoryId"
            value={post.categoryId || ""}
            onChange={handleInputChange}
          >
            <option value="">Select a Category</option>
            {categories.map((category) => (
              <option key={category.id} value={category.id}>
                {category.name}
              </option>
            ))}
          </select>
        </div>

        <button onClick={submit}>Submit</button>
      </div>
    </div>
  );
}
