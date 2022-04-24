/*
Given an array of Italian dinner dishes, create a menu which contains only the vegetarian options.
Each menu array index contains a dish object. A dish object contains the dish name and a boolean value indicating whether the dish is vegetarian.

const menu = [
    {name:"Chicken parmesan", isVegetarian:false}
  , {name:"Penne a la vodka", isVegetarian:true }
  , {name:"Mushroom risotto", isVegetarian:true }
  , {name:"Veal saltambuca" , isVegetarian:false}
  , {name:"Filet mignon"    , isVegetarian:false}
];

Requirements:
- Use the `array.filter()` method to differentiate dishes which are vegetarian
- Dynamically generate each DOM node for the vegetarian dishes to append it as a list item to an unordered list
*/

const menu = [
    {name:"Chicken parmesan", isVegetarian:false}
  , {name:"Penne a la vodka", isVegetarian:true }
  , {name:"Mushroom risotto", isVegetarian:true }
  , {name:"Veal saltambuca" , isVegetarian:false}
  , {name:"Filet mignon"    , isVegetarian:false}
];

const menuNode = document.querySelector("#menu"); // Find the HTML list element by ID.

const filteredMenu = menu.filter( // .filter() returns array items that pass the tests we provide.
  (meal) => meal.isVegetarian === true
);

filteredMenu.forEach((meal) => {
  let mealListItem = document.createElement("li"); // Create list item.
  mealListItem.textContent = meal.name; // Set its text.
  menuNode.appendChild(mealListItem); // Add to the list.
});