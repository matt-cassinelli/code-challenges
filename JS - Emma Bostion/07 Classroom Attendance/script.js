/*
Given an object, classroom, return an array of student names
The classroom object is structured with two values: hasTeachingAssistant (boolean) and classList (array of strings)
The teacher will always be the first item in the classList array.
If 'hasTeachingAssitant' is true, the teaching assistant will be the second item in the classList array.

{
  hasTeachingAssistant: false,
  classList: ["Rashida", "John", "Roman", "Lisa", "Omair", "Lukas"],
}

Requirements
- Use object and array destructuring
*/

function getStudents(classroom) {
  const {hasTeachingAssistant, classList} = classroom; // Get people from classroom (Destructuring properties from an object)
  let teacher, teachingAssitant, students;

  if (hasTeachingAssistant) {
    [teacher, teachingAssitant, ...students] = classList; // Get students from classList (Destructuring values from an array)
  } else {
    [teacher, ...students] = classList; // "..." captures the remaining part of the array.
  }
  return students;
}

// Tests //

console.log(
  getStudents({
    hasTeachingAssistant: false,
    classList: ["Rashida", "John", "Roman", "Lisa", "Omair", "Lukas"],
  })
);

console.log(
  getStudents({
    hasTeachingAssistant: true,
    classList: ["Rashida", "John", "Roman", "Lisa", "Omair", "Lukas"],
  })
);