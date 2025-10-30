const CalculatorModule = (function () {
  let result = 0;  // Initialize the result to 0

  function add(value) {
    result += value;
    displayResult();
  }

  function subtract(value) {
    result -= value;
    displayResult();
  }

  function displayResult() {
    document.getElementById('users-container').textContent = `Result: ${result}`;  // Update the UI
  }

  return {
    add,  // Expose the add function
    subtract   // Expose the subtract function
  };
})();

class Subject {
  constructor() {
    this.observers = [];  // Initialize the observers list
  }

  subscribe(observer) {
    this.observers.push(observer);  // Add an observer
  }

  unsubscribe(observer) {
    this.observers = this.observers.filter(obs => obs !== observer);  // Remove an observer
  }

  notify() {
    this.observers.forEach(observer => observer.update());  // Notify all observers
  }
}

class Observer {
  constructor(name) {
    this.name = name;  // Store the observer's name
  }

  update() {
    console.log(`${this.name} received notification!`);  // Log a notification
  }
}

class Settings {
  constructor() {
    if (Settings.instance) {
      return Settings.instance;  // Return the existing instance
    }

    this.configuration = {};  // Initialize the configuration object
    Settings.instance = this;  // Store the instance
  }

  set(key, value) {
    this.configuration[key] = value;  // Set a configuration value
  }

  get(key) {
    return this.configuration[key];  // Retrieve a configuration value
  }
}

CalculatorModule.add(5);
CalculatorModule.subtract(10);

const observer1 = new Observer(observer1);
const observer2 = new Observer(observer2);

const subject1 = new Subject(observer1);
const subject2 = new Subject(observer2);
subject1.notify();
subject2.notify();