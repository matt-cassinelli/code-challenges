/*
Create a generator function called "getStop" which yields different stops on a trainline.
The stops are as follows: Poughkeepsie, Newburgh, Peekskill, Yonkers, Bronx, Grand Central
You will have a button with an id of "next-stop" that, when clicked, should console log the next stop or if the end of the line has been reached should console log "We made it!"

Requirements:
- Use a generator function
*/

function* generateStops() { // Generators are declared with an asterix.
  yield "Poughkeepsie";
  yield "Newburgh";
  yield "Peekskill";
  yield "Yonkers";
  yield "Bronx";
  yield "Grand Central";
}

// Generators are functions that can be exited and re-entered whilst retaining its state, as if 'pausing' the function.
// They can be used to achieve asyncronous programming, (but async/await may be more convenient).

const myStopGenerator = generateStops(); // When a generator function is called, it does not execute its code. Instead it returns an object that you can call .next() on.

button = document.querySelector("#next-stop"); // Select DOM element by id.
button.addEventListener("click", () => { // Add an event handler to it. The 1st argument is the event, and the 2nd is what will be triggered, in this case an anonymous/arrow function.
  let stop = myStopGenerator.next(); // The .next() method resumes execution in the generator until the next 'yield' is hit.
  if (stop.done) { // When there are no more yields left, .done becomes true.
    console.log("We made it!");
    button.setAttribute("disabled", true);
  } else {
    console.log(stop.value);
  }
});