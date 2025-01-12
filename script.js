document.querySelector('#show-signin').addEventListener('click', function(e) {
    e.preventDefault();
    document.getElementById('signup-form').style.display = 'none';
    document.getElementById('signin-form').style.display = 'block';
});

document.querySelector('#show-signup').addEventListener('click', function(e) {
    e.preventDefault();
    document.getElementById('signin-form').style.display = 'none';
    document.getElementById('signup-form').style.display = 'block';
});
const movies = document.querySelectorAll('.movie');

movies.forEach(movie => {
    let timeout;
    const trailerUrl = movie.getAttribute('data-trailer');
    const iframe = movie.querySelector('.trailer');

    // On mouse enter (hover)
    movie.addEventListener('mouseenter', () => {
        timeout = setTimeout(() => {
            iframe.src = trailerUrl; // Load the trailer with autoplay after the delay
            iframe.style.display = 'block'; // Show the trailer iframe
        }, 500); // Delay of 1 second (1000 ms)
    });

    // On mouse leave (stop hover)
    movie.addEventListener('mouseleave', () => {
        clearTimeout(timeout); // Cancel the delayed action if the mouse leaves
        iframe.src = ''; // Remove the trailer src to stop playback
        iframe.style.display = 'none'; // Hide the iframe again
    });
});