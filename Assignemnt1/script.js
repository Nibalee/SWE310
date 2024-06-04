function toggleLabelVisibility() {
    var label = document.getElementById('Label1');
    if (label.innerHTML.trim() === '') {
        label.style.display = 'none';
    } else {
        label.style.display = 'block';
    }
}

document.addEventListener("DOMContentLoaded", function () {
    toggleLabelVisibility();
});