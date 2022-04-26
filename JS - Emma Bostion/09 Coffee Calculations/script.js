/*
You and a group of friends have spent all day hanging out at a coffee shop.
Each person has ordered some number of coffees, and you want to pay the entire bill.
Given an array of integers > 0 representing the number of coffees each friend ordered, calculate the total price of all coffees.
Each coffee costs £1.25.

Requirements:
- Use array.reduce()
- Use template literals
*/

function calculateTotal(myArray) {
  let total = myArray.reduce( // The reduce method runs a function once for each item in an array and returns a single value.
    (prev, current) => (prev += current)
  );
  return `The total bill is £${total * 1.25}`;
}

console.log(calculateTotal([2, 5, 7, 1, 4]));