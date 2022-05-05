/*
Create a function called urlify which takes in a blog title and outputs a url-friendly string where
each word is lowercase and spaces are replaced with hyphens. Remember to remove all apostrophes.
("How I Got Into Programming!!!") => "how-i-got-into-programming"

Requirements:
- String manipulation
*/

function urlify(blogTitle) {
  return blogTitle.toLowerCase()
    .replace(/[.,/#!$%^&*;:{}=!\-_`~()'"]/g, "") // "g" in the regex literal means that all occurences will be matched instead of just the first one.
    .trim()
    .replaceAll(" ", "-"); // This comes after the first replace method so that spaces are preserved
}

console.log(urlify("How I Got Into Programming!!!"));
console.log(urlify("I've got a new job :)"));