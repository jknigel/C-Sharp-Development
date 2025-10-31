fetch("https://jsonplaceholder.typicode.com/users")
.then(response => response.json())
.then(data => {
    const container = document.getElementById('users-container');
    data.forEach(user => {
        const userElement = document.createElement('p');
        userElement.textContent = `${user.name} - ${user.email}`;
        container.appendChild(userElement);
    });
})
.catch(error => console.error('Error fetching data', error));

//Parse JSON String
const jsonString = '[{"name": "Alice", "age": 25}, {"name": "Bob", "age": 30}]';
const users = JSON.parse(jsonString);
console.log(users[0].name)
console.log(users[1].age)

//Stringify
const newUser1 = {name: "Charlie", age: 28, isActive: true};
jsonNewUser1 = JSON.stringify(newUser1);
console.log(jsonNewUser1);

//Local Storage
const settings = {theme: "dark", language: "en"}
localStorage.setItem('userSettings', JSON.stringify(settings));
const storedSettings = JSON.parse(localStorage.getItem('userSettings'));
console.log(storedSettings.theme);
console.log(storedSettings.language);

