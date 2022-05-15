const titleElement = document.getElementById('siteTitle');
const colorBtn = document.getElementById('changeColorBtn');

let isRed = false;

colorBtn.addEventListener('click', () => {
    if (isRed) {
        titleElement.classList.remove('red-title');
    } else {
        titleElement.classList.add('red-title');
    }

    isRed = !isRed;
});