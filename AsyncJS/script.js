// Mock data representing what we would get from a server
const mockData = ['Alice', 'Bob', 'Charlie', 'Diana'];

/**
 * 1. Callback Function
 * This function simulates fetching data with a 1-second delay and
 * then executes a callback with the data.
 */
function fetchDataWithCallback(callback) {
    setTimeout(() => {
        // Call the callback with null for the error and the data
        callback(null, mockData);
    }, 1000);
}

/**
 * 2. Promises
 * This function returns a Promise that resolves with the mock data
 * after a 1-second delay.
 */
function fetchDataWithPromise() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            // Resolve the Promise with the data
            resolve(mockData);
        }, 1000);
    });
}

/**
 * 3. Async/Await
 * This async function handles the Promise using await and updates the DOM.
 * It also includes error handling.
 */
async function displayData() {
    const dataContainer = document.getElementById('data-container');
    try {
        // Wait for the Promise to resolve
        const data = await fetchDataWithPromise();

        // Create the HTML string to display the names
        let namesHtml = '';
        for (const name of data) {
            namesHtml += `<p>${name}</p>`;
        }

        // Update the DOM
        dataContainer.innerHTML = namesHtml;
    } catch (error) {
        /**
         * 4. Error Handling
         * If the Promise is rejected, the catch block will execute.
         */
        console.error('An error occurred while fetching data:', error);
        dataContainer.innerHTML = '<p>Could not fetch data. Please try again later.</p>';
    }
}

// Call the main function to start the process
displayData();