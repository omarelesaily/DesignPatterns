# Decorator Design Pattern

## Overview
The **Decorator Design Pattern** allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class. The pattern provides a flexible alternative to subclassing for extending functionality.

## Use Case
- **Adding behavior at runtime**: You want to add extra features to an object dynamically without modifying its structure.
- **Avoiding subclass explosion**: Instead of creating multiple subclasses for each feature, you use decorators to extend functionality at runtime.

### Key Participants
1. **Component (ICoffee)**: Defines the interface for objects that can have responsibilities added dynamically.
2. **Concrete Component (SimpleCoffee)**: The class to which additional behavior can be added.
3. **Decorator (CoffeeDecorator)**: Implements the same interface as the `Component` and contains a reference to a `Component` object. It adds behavior either before or after delegating the request to the component.
4. **Concrete Decorators (MilkDecorator, SugarDecorator, WhippedCreamDecorator)**: These decorators extend the behavior of the `Component`.

## Example: Coffee Shop

We are modeling a coffee shop where you can start with a simple coffee and dynamically add extras like milk, sugar, and whipped cream. The key is that these additions are made using decorators, not by modifying the original `SimpleCoffee` class.

