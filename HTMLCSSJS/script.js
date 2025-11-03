// Wait for the entire HTML document to be loaded before running the script
document.addEventListener('DOMContentLoaded', () => {

    // Step 3: Hamburger Menu Interactivity
    const hamburger = document.querySelector('.hamburger-menu');
    const navLinks = document.querySelector('#nav-links');

    hamburger.addEventListener('click', () => {
        // Toggle the 'active' class to show/hide the menu
        navLinks.classList.toggle('active');
    });

    // Step 3: Smooth Scrolling for navigation links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function(e) {
            e.preventDefault(); // Prevent the default jump-to-anchor behavior

            document.querySelector(this.getAttribute('href')).scrollIntoView({
                behavior: 'smooth' // This creates the smooth scroll effect
            });
        });
    });

    // Step 4: Project Filtering
    const filterButtons = document.querySelectorAll('.filter-btn');
    const projectItems = document.querySelectorAll('.project-item');

    filterButtons.forEach(button => {
        button.addEventListener('click', () => {
            // Manage the active state for the clicked button
            filterButtons.forEach(btn => btn.classList.remove('active'));
            button.classList.add('active');
            
            const filter = button.getAttribute('data-filter');

            // Show or hide projects based on the selected category
            projectItems.forEach(item => {
                if (filter === 'all' || item.getAttribute('data-category') === filter) {
                    item.style.display = 'block'; // Or 'flex', depending on your layout
                } else {
                    item.style.display = 'none';
                }
            });
        });
    });

    // Step 4: Lightbox Effect for Project Images
    const projectImages = document.querySelectorAll('.project-image');
    const lightbox = document.getElementById('lightbox-modal');
    const lightboxImage = document.getElementById('lightbox-image');
    const closeBtn = document.querySelector('.lightbox-close');

    projectImages.forEach(image => {
        image.addEventListener('click', () => {
            lightbox.style.display = 'flex'; // Show the modal
            lightboxImage.src = image.src; // Set the image source
        });
    });

    // Close the lightbox when the close button is clicked
    closeBtn.addEventListener('click', () => {
        lightbox.style.display = 'none';
    });
    
    // Close lightbox when clicking outside the image
    lightbox.addEventListener('click', (e) => {
        if (e.target !== lightboxImage) {
            lightbox.style.display = 'none';
        }
    });

    // Step 5: Form Validation
    const contactForm = document.getElementById('contact-form');
    const nameInput = document.getElementById('name');
    const emailInput = document.getElementById('email');
    const messageInput = document.getElementById('message');

    contactForm.addEventListener('submit', (e) => {
        e.preventDefault(); // Prevent the form from submitting by default
        
        let isValid = true; // Assume the form is valid initially

        // Validate Name
        if (nameInput.value.trim() === '') {
            showError(nameInput, 'Name is required.');
            isValid = false;
        } else {
            clearError(nameInput);
        }

        // Validate Email
        if (emailInput.value.trim() === '') {
            showError(emailInput, 'Email is required.');
            isValid = false;
        } else if (!isValidEmail(emailInput.value)) {
            showError(emailInput, 'Please enter a valid email address.');
            isValid = false;
        } else {
            clearError(emailInput);
        }
        
        // Validate Message
        if (messageInput.value.trim() === '') {
            showError(messageInput, 'Message is required.');
            isValid = false;
        } else {
            clearError(messageInput);
        }

        if (isValid) {
            // Step 6: For debugging and confirmation
            console.log('Form is valid. Submitting...');
            alert('Thank you for your message!');
            contactForm.reset(); // Clear the form after submission
        } else {
            console.log('Form has errors. Please correct them.');
        }
    });

    // Helper functions for showing/clearing form errors
    function showError(input, message) {
        const formGroup = input.parentElement;
        const errorDisplay = formGroup.querySelector('.error-message');
        errorDisplay.innerText = message;
        input.classList.add('invalid');
    }

    function clearError(input) {
        const formGroup = input.parentElement;
        const errorDisplay = formGroup.querySelector('.error-message');
        errorDisplay.innerText = '';
        input.classList.remove('invalid');
    }

    // Helper function to validate email format using a simple regex
    function isValidEmail(email) {
        const regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return regex.test(email);
    }
});