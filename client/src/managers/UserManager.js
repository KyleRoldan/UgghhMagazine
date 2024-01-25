const apiUrl = "/api/users";

export const getUsers = () => {
  return fetch(apiUrl).then((res) => res.json());
};

export const getUserById = (id) => {
  return fetch(`${apiUrl}/${id}`).then((res) => res.json());
};

// export const getBikesInShopCount = () => {
//   return fetch(`${apiUrl}/inventory`).then((res) => res.json());
// };
