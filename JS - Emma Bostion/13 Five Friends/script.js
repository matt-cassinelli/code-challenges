/*
You're working on a new component for "Your Space", a brand new social media application for finding friends. This component displays a user's top five friends.
Given some JSON, dynamically generate thumbnails for the top five friends. You can append these thumbnails to the "<div id="timeline"></div>"".

Requirements:
- Use the random user API: https://randomuser.me/api/?results=5
- Use async/await
- Use fetch()
- Use DOM manipulation to dynamically generate five medium-sized images for each person
*/

async function getUsers() {
  let people = await fetch("https://randomuser.me/api/?results=5"); // Make an API request. Await means that the code will pause until the data is received.
  let data = await people.json(); // Convert response to JSON.
  const timelineNode = document.querySelector("#timeline"); // Find the div element
  data.results.forEach((person) => { // Add photos to the div element
    let imageNode = document.createElement("img");
    imageNode.src = person.picture.medium;
    timelineNode.appendChild(imageNode);
  });
}

getUsers();