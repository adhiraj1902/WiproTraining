import { useState } from "react";
import axios from "axios";

function UserForm({ addUser }) {

  const [name, setName] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();

    const res = await axios.post("http://localhost:5000/users", {
      name: name
    });

    addUser(res.data);
    setName("");
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        type="text"
        placeholder="Enter name"
        value={name}
        onChange={(e) => setName(e.target.value)}
      />

      <button type="submit">Add User</button>
    </form>
  );
}

export default UserForm;