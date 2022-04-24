/*
Create a user object which has three properties: username, password, age.
Username and password must not be accessible when accessed with
alert() or console.log(). Age can be publicly accessed.

Requirements:
- Use JavaScript symbols
*/

const username = Symbol("username"); // Symbols generate unique/random identifiers for variables. They can be used to emulate private fields.
const password = Symbol("password"); // This is not actually secure though - someone could use Symbol.for() to reveal the values.

const user = {
  [username]: "mattc", // Use [] to access symbols
  [password]: "AppleThumbProtect",
  age: 26,
};

console.log(user.username); // Expected output: undefined