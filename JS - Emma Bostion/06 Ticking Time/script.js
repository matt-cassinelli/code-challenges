/*
Given "<div id="clock"></div>"", create a clock which displays the current hour, minutes, and seconds.

Requirements:
- Use setInterval
- Use Date()
*/

function updateClock(clockNode) {
  const currentDateTime = new Date();
  clockNode.textContent = currentDateTime.toLocaleTimeString();
}

const myClockElement = document.querySelector("#clock"); // Find DOM element by ID.

// setInterval calls a function (1st arg) every x milliseconds (2nd arg). It continues until a clearInterval().
setInterval(() => {updateClock(myClockElement)}, 1000);