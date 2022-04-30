/*
Create three buttons: blue, pink, and green.
When each button is clicked, you should set the background of the document body to the selected color.

Requirements:
- Use closures
*/

function makeColourChanger(color) {
  return function () { // Return another function
    document.body.style.background = color;
  };
}

// In JS, all functions have access to the scope above them -- a nested function can reference data from its parent function.
// What's quirky is that this data is still available even after the parent function has completed and returned. This is called a closure.

const changeColourBlue = makeColourChanger("#0f62fe");
const changeColourPink = makeColourChanger("#ff7eb6");
const changeColourGreen = makeColourChanger("#42be65");

// Even though makeColourChanger has been destroyed, the changeColourX closures still have access to the arguments that were passed in.
document.querySelector("#blue").addEventListener("click", changeColourBlue);
document.querySelector("#pink").addEventListener("click", changeColourPink);
document.querySelector("#green").addEventListener("click", changeColourGreen);

