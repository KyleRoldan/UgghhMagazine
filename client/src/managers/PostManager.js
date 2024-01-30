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
    return fetch(`${apiUrl}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(updatedPost),
    }).then((res) => res.json());
  };
  