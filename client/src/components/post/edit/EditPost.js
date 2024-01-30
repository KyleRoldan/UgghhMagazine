// Import other necessary modules

import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { deletePost, editPosts, getPostById,  } from "../../../managers/PostManager";
import { getCategories } from "../../../managers/CategoryManager";
import "../../views/viewsCss/LatestPost.css"
import Modal from "./Modal";

export default function EditPost() {
  const navigate = useNavigate();
  const { id } = useParams();

  const [post, setPost] = useState({ title: "", author: "", content: "", categoryId: null });
  const [categories, setCategories] = useState([]);
  const [isDeleteModalOpen, setDeleteModalOpen] = useState(false);


  useEffect(() => {
    getPostById(id).then((data) => {
      setPost(data);
    });
  }, [id]);

  useEffect(() => {
    // Fetch categories and set them
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
    const { id, title, categoryId, content, author } = post; 
    const updatedPost = {
      id,
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



  const handleDelete = () => {
    setDeleteModalOpen(true);
  };


  const handleDeleteConfirm = () => {
      deletePost(id).then(() => {
        setDeleteModalOpen(false);
        navigate("/");
      });
    
  };

  const handleDeleteCancel = () => {
    // Cancel the delete operation
    setDeleteModalOpen(false);
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

        <button onClick={submit}>Submit Edits</button>


        <button onClick={handleDelete}>Delete Post</button>

      {isDeleteModalOpen && (
        <Modal
          title="Confirm Delete"
          message="You are about to delete a post. Are you sure?"
          onConfirm={handleDeleteConfirm}
          onCancel={handleDeleteCancel}
        />
      )}
        

      </div>


      


    </div>
  );
}


