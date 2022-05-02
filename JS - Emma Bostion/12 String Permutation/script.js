/*
Given a string, calculate the number of all possible letter combinations.

Requirements:
- Use recursion
*/

// Use recursion to calculate a factorial. n! = n * n-1 * n-2 * n-3 ... * 2 * 1
function getLetterCombinationCount(letters) {
  //console.log(letters.length);
  if (letters.length === 1) {return 1;} // Stop when there's only 1 letter remaining. A 'base case' like this is needed to prevent an infinite loop.
  return letters.length * getLetterCombinationCount(letters.substring(1)); // If there is more than 1 letter left, multiply self * (self - 1 letter).
}

// Tests //
console.log(getLetterCombinationCount("hello"));