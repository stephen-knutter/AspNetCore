document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This is the element from fourth.js";
    document.querySelector("body").appendChild(element);
});