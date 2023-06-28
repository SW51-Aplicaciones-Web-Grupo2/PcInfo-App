const express = require('express');
const fs = require('fs');
const path = require('path');
const cors = require('cors');

const app = express();
app.use(cors());
app.use(express.json());

app.post('/saveUser', (req, res) => {
    const newUser = req.body;

    let dbPath = path.join(__dirname, './db.json');

    fs.readFile(dbPath, 'utf8', (err, data) => {
        if (err) {
            console.error('Error reading the file:', err);
            res.status(500).send('Error reading the file');
            return;
        }

        let users = JSON.parse(data);
        users.push(newUser);

        fs.writeFile(dbPath, JSON.stringify(users), (err) => {
            if (err) {
                console.error('Error writing the file:', err);
                res.status(500).send('Error writing the file');
            } else {
                res.send('User saved');
            }
        });
    });
});

app.listen(3000, () => {
    console.log('Server is running on port 3000');
});
