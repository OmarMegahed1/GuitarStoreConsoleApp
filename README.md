# Guitar Store Console Application

A C# console application for managing a guitar store inventory with search capabilities based on guitar specifications.

## Overview

This application simulates a guitar store inventory system where customers can search for guitars based on specific criteria. The system matches guitars based on builder, model, type, number of strings, and wood types for both back/sides and top.

## Features

- **Guitar Inventory Management**: Add and retrieve guitars from inventory
- **Specification-based Search**: Find guitars matching specific criteria
- **Multiple Guitar Builders**: Support for Fender, Martin, Gibson, Collings, Olson, Ryan, and PRS
- **Wood Type Specifications**: Various wood types for guitar construction
- **Flexible Matching**: Case-insensitive model matching with partial specification support

## Classes and Components

### Guitar
Represents a guitar with:
- **SerialNumber**: Unique identifier (read-only)
- **Price**: Guitar price (modifiable)
- **Spec**: Guitar specifications (read-only)

### GuitarSpec
Defines guitar specifications including:
- **Builder**: Guitar manufacturer
- **Model**: Guitar model name
- **Type**: Acoustic or Electric
- **NumStrings**: Number of strings (typically 6 or 12)
- **BackWood**: Wood type for back and sides
- **TopWood**: Wood type for the top

### Inventory
Manages the guitar collection with methods to:
- Add guitars to inventory
- Retrieve guitars by serial number
- Search guitars by specifications

### Enumerations

#### Builder
Supported guitar manufacturers:
- Fender
- Martin
- Gibson
- Collings
- Olson
- Ryan
- PRS

#### GuitarType
- Acoustic
- Electric

#### Wood
Supported wood types:
- Indian Rosewood
- Brazilian Rosewood
- Mahogany
- Maple
- Cocobolo
- Cedar
- Adirondack
- Alder
- Sitka

## Getting Started

### Prerequisites
- .NET 8.0 or later
- Visual Studio 2022 or Visual Studio Code (optional)

### Building the Application

1. Clone or download the project
2. Navigate to the project directory
3. Build the application:
   ```bash
   dotnet build
   ```

### Running the Application

```bash
dotnet run
```
