/*
Create a Movie object that takes in five arguments: title, director, genre, releaseYear, rating.
Add a function called getOverview on the Movie prototype which logs the following overview for each film:
"<movie>, a <genre> film directed by <director> was released in <releaseYear>. It received a rating of <rating>."

Requirements:
- Use object prototypes
*/

class Movie {
  constructor(title, director, genre, releaseYear, rating) { // Turn the supplied arguments into properties of the object instance.
    this.title = title;
    this.director = director;
    this.genre = genre;
    this.releaseYear = releaseYear;
    this.rating = rating;
  }

  getOverview() { // If this was not inside a class, it would have to be written as "Movie.prototype.getOverview() = function () {}".
    return `${this.title}, a ${this.genre} film directed by ${this.director} was released in ${this.releaseYear}. It received a rating of ${this.rating}`;
  }
}

const TimeBanditsMovie = new Movie( "Time Bandits", "Terry Gilliam",  "Fantasy", 1981, 96);
const TotalRecallMovie = new Movie( "Total Recall", "Paul Verhoeven", "Action",  1990, 67);
const IdiocracyMovie   = new Movie( "Idiocracy",    "Mike Judge",     "Comedy",  2006, 81);

// How JS Inheritance works:
// Each object has a private property called "prototype" which holds a link to another object.
// This referenced object has a prototype of its own, and so on until an object is reached with null as its prototype.

//console.log(TimeBanditsMovie); // To illustrate "prototype"
console.log(TimeBanditsMovie.getOverview());
console.log(TotalRecallMovie.getOverview());
console.log(IdiocracyMovie.getOverview());