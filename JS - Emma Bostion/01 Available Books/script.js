/*
You're developing an inventory application for a bookstore.
You need to create a JavaScript class, "Book", that accepts a title, author,
ISBN (International Standard Book Number), and the number of available copies.

You should provide a getter function called 'availability' that checks the number of available copies
and returns "Out of stock" if it's zero, "Low stock" if it's less than 10, and "In stock" if it's 10 or greater.

You should add a "sell" method which accepts the number of copies to sell and subtracts it from the number of copies.
The number of copies to sell should have a default value of one.
You should add a "restock" method which accepts the number of copies to restock and adds it to the number of total copies.
The number of copies to restock should have a default value of five.

Requirements:
- Use JavaScript's class notation
- Use JavaScript getters
*/

class Book { // It's better to have classes with encapsulated methods instead of seperate functions.
  constructor(title, author, ISBN, numCopies) { // This is called when instantiating just like in C#. Must be named "constructor".
    this.title = title;
    this.author = author;
    this.ISBN = ISBN;
    this.numCopies = numCopies;
  }

  get availability() { // Getter. Allows us to write MyBook.availability instead of MyBook.getAvailability().
    if (this.numCopies === 0) {return "Out of stock";}
    else if (this.numCopies < 10) {return "Low stock";}
    else {return "In stock";}
  }

  sell(numCopiesSold = 1) { // In JS, people place { on the same line.
    this.numCopies -= numCopiesSold;
  }

  restock(numCopiesStocked = 5) {
    this.numCopies += numCopiesStocked;
  }
}

const CleanCodeBook = new Book("Clean Code", "Robert C. Martin", 9780132350884, 5);
console.log(CleanCodeBook.availability); // Expected output - "Low stock"
CleanCodeBook.restock(12);
console.log(CleanCodeBook.availability); // Expected output - "In stock"
CleanCodeBook.sell(17);
console.log(CleanCodeBook.availability); // Expected output - "Out of stock" // TODO: Research testing frameworks.

// Archive:

// function Book(title, author, ISBN, numCopies) {
//   this.title = title;
//   this.author = author;
//   this.ISBN = USBN;
//   this.numCopies = numCopies;
// }

// Book.prototype.getAvailability = function() { // The function is declared on the prototype so that we don't have to create a new one each time we make a new object.
//   if (this.numCopies === 0) { // === seems to be better than == https://stackoverflow.com/questions/359494/which-equals-operator-vs-should-be-used-in-javascript-comparisons
//     return "Out of stock";
//   } else if (this.numCopies < 10) {
//     return "Low stock";
//   }
// }

// Book.prototype.sell = function(numCopiesSold = 1) { // Default to 1 if not supplied
//   this.numCopies -= numCopiesSold;
// }

// Book.prototype.restock = function(numCopiesStocked = 5) {
//   this.numCopies += numCopiesStocked;
// }