/*
You're organizing a food truck festival with many different vendors.
Each vendor has a menu and some vendors might be serving the same item.
Given an array of food truck menus, return one master menu which contains all food items to be served, without duplicates.

Input: [['Tacos', 'Burgers'], ['Pizza'], ['Burgers', 'Fries']]
Output: Tacos, Burgers, Pizza, Fries

Requirements:
- Use Sets
- Dynamically generate list items containing the unique menu items
- Use the spread operator
*/

function getUniqueMenuItems(menus) {
  let menuItems = menus.flat(); // Flatten arrays into one array.
  let uniqueMenuItems = new Set();
  menuItems.forEach((item) => {
    uniqueMenuItems.add(item);
  });

  // Add to DOM element
  const menuElement = document.querySelector("#combined-menu");
  for (let item of uniqueMenuItems) {
    let listItemElement = document.createElement("li");
    listItemElement.innerText = item;
    menuElement.appendChild(listItemElement);
  }
}

// Tests //
getUniqueMenuItems([["Tacos", "Burgers"], ["Pizza"], ["Burgers", "Fries"]]);