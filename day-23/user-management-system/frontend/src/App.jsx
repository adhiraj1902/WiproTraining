import { useEffect, useState } from "react";
import axios from "axios";
import UserList from "./components/UserList";
import UserForm from "./components/UserForm";

function App() {

    const [users, setUsers] = useState([]);

    useEffect(() => {
        axios.get("http://localhost:5000/users")
            .then((res) => {
                setUsers(res.data);
            });
    }, []);

    const addUser = (user) => {
        setUsers([...users, user]);
    };

    return ( <
        div >
        <h1 > User Management System </h1>

        <
        UserForm addUser = { addUser }
        />

        <
        UserList users = { users }
        />

        </div>
    );
}

export default App;