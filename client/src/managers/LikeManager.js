const apiUrl = "/api/likes";

export const getLikeRelationship = (postId, userId) => {
    return fetch(`${apiUrl}/${postId}/${userId}`)
      .then((res) => {
        if (res.status === 404) {
          return [];
        }
  
        if (!res.ok) {
          throw new Error(`Failed to fetch like relationship: ${res.statusText}`);
        }
  
        return res.json();
      })
      .then((data) => data)
      .catch((error) => {
        console.error("Error fetching like relationship:", error);
        throw error;
      });
  };

export const createLike = (postId, userId) => {
  return fetch(`${apiUrl}/${postId}/${userId}`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
  })
    .then((res) => {
      if (!res.ok) {
        throw new Error(`Failed to create like: ${res.statusText}`);
      }
      return res.json();
    })
    .then((data) => data)
    .catch((error) => {
      console.error("Error creating like:", error);
    });
};

export const deleteLike = (postId, userId) => {
  return fetch(`${apiUrl}/${postId}/${userId}`, {
    method: "DELETE",
  })
    .then((res) => {
      if (!res.ok) {
        throw new Error(`Failed to delete like: ${res.statusText}`);
      }
    })
    .catch((error) => {
      console.error("Error deleting like:", error);
    });
};
