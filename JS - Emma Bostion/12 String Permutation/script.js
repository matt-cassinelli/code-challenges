/*
Given a string, calculate the number of all possible letter combinations.

Requirements:
- Use recursion
*/


function getLetterCombinationCount(letters) {
  function recurse(letterCount) { // Use recursion to calculate a factorial (n * n-1 * n-2 * n-3 ... * 2 * 1).
    if (letterCount === 1) {return 1;} // If there is only 1 letter left then stop. A 'base case' like this is needed to prevent an infinite loop.
    return letterCount * recurse(letterCount - 1); // If there is more than 1 letter left, multiply self * (self - 1 letter).
  }

  return recurse(letters.length);
}

// Tests //
console.log(getLetterCombinationCount("hello"));