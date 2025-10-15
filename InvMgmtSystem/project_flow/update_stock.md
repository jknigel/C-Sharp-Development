```mermaid
graph TD
    A("Start: Update Stock") --> B("Call 'View Products' to display items with numbers");
    B --> C{"Is `inventory` List empty?"};
    C -- Yes --> Z("End: Return to Main Menu");

    C -- No --> D_LoopStart(Start Selection Loop);
    D_LoopStart --> D[Prompt user to select a product by number];
    D --> E[Get Selection Input];
    E --> F{"Is selection a valid number AND within the list's range?"};
    
    F -- No --> G{"Display 'Invalid selection' Error"};
    G --> D_LoopStart;
    
    F -- Yes --> H_LoopStart(Start Quantity Loop);
    H_LoopStart --> H[Prompt for new stock quantity];
    H --> I[Get Quantity Input];
    I --> J{"Is quantity a valid integer?"};
    
    J -- No --> K{"Display 'Invalid quantity' Error"};
    K --> H_LoopStart;

    J -- Yes --> L{"Update selected product's `Quantity` property"};
    L --> M{"Display 'Stock updated successfully'"};
    M --> Z;
```