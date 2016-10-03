function openHamburger() {
    var x = document.getElementById("hamburger");
    if (x.className === "hamburger-menu") {
        x.className += " responsive";
    } else {
        x.className = "hamburger-menu";
    }
}