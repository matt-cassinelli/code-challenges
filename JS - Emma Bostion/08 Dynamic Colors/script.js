/*
Create three buttons: blue, pink, and green.
When each button is clicked, you should set the background of the document body to the selected color.

Requirements:
- Use closures
*/

function changeColor(color) {
  return function () { // Return a function.
    document.body.style.background = color;
  };
}

const bgColorBlue = changeColor("#0f62fe");
const bgColorPink = changeColor("#ff7eb6");
const bgColorGreen = changeColor("#42be65");

document.querySelector("#blue").addEventListener("click", bgColorBlue);
document.querySelector("#pink").addEventListener("click", bgColorPink);
document.querySelector("#green").addEventListener("click", bgColorGreen);

// In JS, all functions have access to the scope above them.
// We can use a nested function to access data from the parent function.
// These functions ('closures') have access to the parent scope, even after the parent function has closed.
// This challenge is a bad illustration. Read here instead: https://www.w3schools.com/js/js_function_closures.asp