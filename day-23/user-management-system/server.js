const express = require("express");
const cors = require("cors");

const app = express();
app.use(cors());
app.use(express.json());

let users = [
    { id: 1, name: "Harsh" },
    { id: 2, name: "Jenish" }
];

// GET users
app.get("/users", (req, res) => {
    res.json(users);
});

// POST user
app.post("/users", (req, res) => {
    const newUser = {
        id: users.length + 1,
        name: req.body.name
    };

    users.push(newUser);
    res.json(newUser);
});

app.listen(5000, () => {
    console.log("Server running on port 5000");
});