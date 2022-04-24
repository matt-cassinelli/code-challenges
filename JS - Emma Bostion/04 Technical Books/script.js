/*
Expanding on your previous book application you now want to create a class for technical books.
Using the Book class constructed in the last example, extend the functionality to the new TechnicalBook class.
The new TechnicalBook class will take a book edition as a fifth argument.
You should add a getEdition method which prints "The current version of this book is ${version}"".

Requirements:
- Use JavaScript's class notation
*/

class Book {
  constructor(title, author, ISBN, numCopies) {
    this.title = title;
    this.author = author;
    this.ISBN = ISBN;
    this.numCopies = numCopies;
  }

  get availability() {
    return this.getAvailability();
  }

  getAvailability() {
    if (this.numCopies === 0) {
      return "Out of stock";
    } else if (this.numCopies < 10) {
      return "Low stock";
    }
    return "In stock";
  }

  sell(numCopiesSold = 1) {
    this.numCopies -= numCopiesSold;
  }

  restock(numCopiesStocked = 5) {
    this.numCopies += numCopiesStocked;
  }
}


class TechnicalBook extends Book { // "extends" means that this class is a child of Book, and can reuse its members (DRY). It can also be used to add additional methods to built-in objects.
  constructor(title, author, ISBN, numCopies, edition) {
    super(title, author, ISBN, numCopies); // "super" can be used in the constructor method to get access to the parent class' members.
    this.edition = edition;
  }

  getEdition() {
    return `The current version of this book is ${this.edition}`; // Template literal
  }
}

const CleanCodeBook = new TechnicalBook("Clean Code", "Robert C. Martin", 9780132350884, 5, 2);
console.log(CleanCodeBook.availability); // Expected output: "Low stock"
console.log(CleanCodeBook.getEdition()); // Expected output: "The current version of this book is 2"