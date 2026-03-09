const form = document.querySelector("form");
const input = document.querySelector("input");
const ul = document.querySelector("ul");
// I canalso use other ways to select the elements like getElementById, getElementsByClassName, querySelectorAll etc.

form.addEventListener("submit", function (event) {
  event.preventDefault(); // Prevent the default form submission behavior
  const task = input.value; // Get the value of the input field
  if (task) {
    // Check if the input is not empty
    const li = document.createElement("li"); // Create a new list item element
    li.textContent = task;
    ul.appendChild(li); // Append the new list item to the unordered list element on the page
    input.value = ""; // Clear the input field after adding the task
  }
});

// add for counter increament\decrement

const countDisplay = document.getElementById("count");
const btnIncrement = document.getElementById("increment");
const btnDecrement = document.getElementById("decrement");

let currentCount = 0;

btnIncrement.addEventListener("click", function () {
  currentCount++;
  countDisplay.textContent = currentCount;
});

btnDecrement.addEventListener("click", function () {
  currentCount--;
  countDisplay.textContent = currentCount;
});