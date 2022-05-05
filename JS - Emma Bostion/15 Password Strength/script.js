/*
You're building a sign up component and need to validate whether a user's desired password is secure enough.
Given a password (string) return true if the password meets the following criteria and false if it doesn't.
Password criteria: one lowercase letter, one uppercase letter, one special character (!@#\$%^&\*), one number, at least 8 characters long.

Requirements:
- Use regex to test whether the password is valid
- Use a ternary operator to return "Your password is valid" if it meets all requirements and "Your password is not valid, try again" if it doesn't.
*/

function validatePassword(password) {

  var patterns = [ // Create array of regex literals (surrounded by / /)
    /(?=.+[a-z])/, // One lowercase char
    /(?=.+[A-Z])/, // One uppercase char
    /(?=.+[0-9])/, // One digit
    /(?=.+[!@#$%^&*])/, // One special char
    /(?=.{8,})/ // Min 8 chars
  ];

  let isValid = true; // Priming

  patterns.forEach(pattern => {
    if (pattern.test(password) === false) {isValid = false;} // The test() method returns a boolean telling us if the string matches the regex pattern.
  })

  return isValid ? "Your password is valid" : "Your password is invalid, try again";
}

console.log(validatePassword("abc"));
console.log(validatePassword("9Ab!4567"));