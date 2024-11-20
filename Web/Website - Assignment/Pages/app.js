const navSlide = () => {
	const burger = document.querySelector(".burger");
	const nav = document.querySelector(".nav-links");
	const navLinks = document.querySelectorAll(".nav-links li");

	burger.addEventListener("click", () => {
		nav.classList.toggle("nav-active");
		burger.classList.toggle("toggle");

		navLinks.forEach((link, index) => {
			if (link.style.animation != "") {
				link.style.animation = "";
			} else {
				link.style.animation = `navLinkFade 0.3s ease forwards ${index / 7 +
					0.3}s`;
			}
		});
	});
};

var prevScrollpos = window.pageYOffset;
window.onscroll = function() {
	var currentScrollPos = window.pageYOffset;
	if (currentScrollPos < prevScrollpos) {
		if (currentScrollPos == 0) {
			document.querySelector(".navbar").style.top = "0";
			document.querySelector(".navbar").style.backgroundColor = "transparent";
		} else {
			document.querySelector(".navbar").style.top = "0";
			document.querySelector(".navbar").style.backgroundColor =
				"rgba(143, 190, 219, 0.9)";
		}
	} else {
		document.querySelector(".navbar").style.top = "-8vh";
	}
	prevScrollpos = currentScrollPos;
}; // Window scroll function

navSlide();
