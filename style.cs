/* General Reset */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    scroll-behavior: smooth;
}

body {
    font-family: 'Helvetica Neue', Arial, sans-serif;
    background-color: #141414;
    color: white;
    overflow-x: hidden;
}

/* Custom Scrollbar */
::-webkit-scrollbar {
    width: 8px;
}

::-webkit-scrollbar-thumb {
    background: #555;
    border-radius: 10px;
}

::-webkit-scrollbar-thumb:hover {
    background: #e50914;
}

/* Header Styling */
header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 15px 50px;
    background-color: rgba(0, 0, 0, 0.8);
    position: sticky;
    top: 0;
    z-index: 1000;
    transition: background-color 0.5s ease;
}

header.scrolled {
    background-color: black;
}

.logo img {
    height: 40px;
    transition: transform 0.3s ease;
}

.logo img:hover {
    transform: scale(1.1);
}

.nav-links {
    list-style-type: none;
    display: flex;
    gap: 20px;
}

.nav-links a {
    color: white;
    text-decoration: none;
    font-weight: bold;
    padding: 5px 10px;
    transition: background-color 0.3s ease, color 0.3s ease;
}

.nav-links a:hover {
    color: #e50914;
    background-color: rgba(255, 255, 255, 0.1);
    border-radius: 5px;
}

.header-right {
    display: flex;
    align-items: center;
    gap: 20px;
}

.search-icon, .notification-icon {
    color: white;
    font-size: 20px;
    cursor: pointer;
    transition: transform 0.3s ease;
}

.search-icon:hover, .notification-icon:hover {
    transform: scale(1.2);
}

.profile-icon {
    height: 30px;
    border-radius: 50%;
    cursor: pointer;
    transition: box-shadow 0.3s ease;
}

.profile-icon:hover {
    box-shadow: 0 0 10px rgba(255, 255, 255, 0.5);
}

/* Hero Section */
.hero {
    position: relative;
    height: 80vh;
    background-image: linear-gradient(to top, rgba(0, 0, 0, 0.8), rgba(0, 0, 0, 0.1)), url('https://wallpapercave.com/wp/wp10615928.jpg');
    background-size: cover;
    background-position: center;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    text-align: center;
}

.hero-content {
    max-width: 700px;
    padding: 20px;
    background-color: rgba(0, 0, 0, 0.5);
    border-radius: 10px;
    animation: fadeIn 1s ease-in-out;
}

.hero-content h1 {
    font-size: 3rem;
    margin-bottom: 20px;
}

.hero-content p {
    font-size: 1.2rem;
    margin-bottom: 20px;
}

.hero-buttons a {
    margin: 10px;
    padding: 10px 25px;
    color: white;
    font-size: 1rem;
    text-decoration: none;
    background-color: rgba(51, 51, 51, 0.8);
    border-radius: 5px;
    display: inline-block;
    transition: background-color 0.3s ease, transform 0.3s ease;
}

.hero-buttons .play-btn {
    background-color: #e50914;
}

.hero-buttons a:hover {
    transform: scale(1.05);
}

.hero-buttons a i {
    margin-right: 5px;
}

/* Fade-in Animation for Hero Section */
@keyframes fadeIn {
    from {
        opacity: 0;
    }
    to {
        opacity: 1;
    }
}

/* Categories Styling */
.categories {
    padding: 50px;
}

h2 {
    margin-top: 20px;
    margin-bottom: 10px;
    font-size: 1.8rem;
}

.trend {
    display: flex;
    gap: 15px;
    overflow-x: auto;
    padding-bottom: 20px;
}

.trend img {
    width: 200px;
    border-radius: 5px;
    transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.trend img:hover {
    transform: scale(1.1);
    box-shadow: 0 0 20px rgba(255, 255, 255, 0.5);
}

/* Responsive Design */
@media (max-width: 768px) {
    .hero-content h1 {
        font-size: 2rem;
    }

    .hero-content p {
        font-size: 1rem;
    }

    .trend img {
        width: 150px;
    }

    .nav-links {
        display: none;
    }

    .header-right {
        gap: 10px;
    }

    header {
        padding: 15px 20px;
    }

    .hero {
        height: 60vh;
      
    }

    .categories {
        padding: 20px;
    }
}

/* Footer Styling */
footer {
    text-align: center;
    padding: 20px;
    background-color: black;
    color: white;
}

.footer-columns {
    display: flex;
    justify-content: center;
    gap: 20px;
}

.footer-links {
    list-style: none;
}

.footer-links a {
    color: white;
    text-decoration: none;
    margin-bottom: 10px;
    transition: color 0.3s ease;
}

.footer-links a:hover {
    color: #e50914;
}

footer p {
    margin-top: 10px;
}

/* Authentication Icon and Form */
.auth-icon {
    position: relative;
    color: white;
    font-size: 30px;
    cursor: pointer;
}

.auth-icon i:hover {
    color: #e50914;
}

.auth-form {
    display: none;
    position: absolute;
    top: 40px;
    right: 0;
    background-color: white;
    color: black;
    width: 250px;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 0 15px rgba(0, 0, 0, 0.3);
    z-index: 10;
}

.auth-form p {
    margin-top: 10px;
    text-align: center;
}

.auth-form a {
    color: #e50914;
    text-decoration: none;
}

/* Show form when hovering over auth icon */
.auth-icon:hover .auth-form {
    display: block;
}

@media(max-width: 768px) {
    .auth-form {
        right: -20px;
    }
}
