//Scroll
AOS.init();
window.onscroll = function () { myFunction() };
var header = document.getElementById("myHeader");
var sticky = header.offsetTop;
function myFunction() {
    if (window.pageYOffset > sticky) {
        header.classList.add("solid");
    } else {
        header.classList.remove("solid");
    }
}

