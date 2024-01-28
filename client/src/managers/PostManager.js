const apiUrl = "/api/post";

export const getPosts = () => {
  return fetch(apiUrl).then((res) => res.json());
};

export const getPostById = (id) => {
  return fetch(`${apiUrl}/${id}`).then((res) => res.json());
};