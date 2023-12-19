let currentSlide = 1;
const totalSlides = 3;

function nextSlide() {
    currentSlide++;
    if (currentSlide > totalSlides) {
        currentSlide = 1;
    }
    updateSlides();
}

function prevSlide() {
    currentSlide--;
    if (currentSlide < 1) {
        currentSlide = totalSlides;
    }
    updateSlides();
}

function updateSlides() {
    const slides = document.getElementsByClassName('slide');
    for (let i = 0; i < slides.length; i++) {
        slides[i].style.transform = `translateX(-${100 * currentSlide}%)`;
    }
}