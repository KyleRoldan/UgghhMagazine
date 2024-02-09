const apiUrl = "/api/post";

export const getPosts = () => {
  return fetch(apiUrl).then((res) => res.json());
};

export const getPostById = (id) => {
  return fetch(`${apiUrl}/${id}`).then((res) => res.json());
};

export const getPostsByCategory = (categoryName) => {
    const apiUrl = `/api/post?category=${categoryName}`;
    return fetch(apiUrl).then((res) => res.json());
  };

  export const editPosts = (updatedPost) => {
    return fetch(`${apiUrl}/${updatedPost.id}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(updatedPost),
    })
  };

  export const createPosts = (post) => {
    
    
  
    return fetch(apiUrl, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(post),
    }).then((res) => res.json());
  };



   export const deletePost = (id) => {
   return fetch(`${apiUrl}/${id}`, {
    method: "DELETE",
    headers: {
      "Content-Type": "application/json",
    },
  });
};

export const getPostsWithLikes = () => {
    return fetch(apiUrl + "/withLikes").then((res) => res.json());
  };

  