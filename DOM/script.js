let quoteDisplay = document.getElementById('quoteDisplay');
let newQuoteButton = document.getElementById('newQuoteButton');

const quotes = [
    "The best way to predict the future is to invent it. - Alan Kay",
    "Life is 10% what happens to us and 90% how we react to it. - Charles R. Swindoll",
    "The only way to do great work is to love what you do. - Steve Jobs",
    "If you can dream it, you can achieve it. - Zig Ziglar",
    "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill"
];

newQuoteButton.addEventListener('click', () => {
    const randomIndex = Math.floor(Math.random() * quotes.length);
    quoteDisplay.textContent = quotes[randomIndex];
});