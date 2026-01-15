# OOP Final Assignment
## Scope
A turn-based console RPG battle simulator system in C#. The project focuses on demonstrating core Object-Oriented Programming principles, clean architecture, and design patterns.
## Overview
The application simulates a combat loop between a Hero and randomly generated Enemies. It features an interactive console interface, a combat log system, and an "arcade mode" allowing for infinite replayability.
## OOP designs and principles
The project was built to demonstrate OOP capabilities rather than just syntax.
### Key features
- *Encapsulation:* All unit stats are protected - state modifications are only beign done through specfific methods e.g. `TakeDamage()` or `Heal()`
- *Abstraction:* The `Unit` and `Ability` classes define the contract for all specfifc implementation
- *Inheritance:* `Player` and `Enemy` inherit from `Unit`, sharing common logic while maintaining their specific behaviors.
- Polymorphism: The `Use()` method in abilities behaves differently depending on the specific ability (Attack vs. Heal), allowing the game engine to treat all moves generically.
## Design Patterns
- *Strategy Pattern:* Abilities (`Attack`, `Heal`) are encapsulated as separate objects. This allows dynamic swapping of skills without modifying the `Unit` class (Open/Closed Principle).
- *Factory Pattern:* `EnemyFactory` is used to abstract the creation logic of complex objects. It handles the generation of random enemies with varied weapons and stats.
- *Observer Pattern (Events):* The `BattleLogger` is decoupled from the game logic. Units publish `OnLog` events, which the logger subscribes to. This separates the UI concern from the Business Logic (SRP).
- *Composition:* Units are composed of `Weapon` and a list of `Abilities`, favoring composition over deep inheritance trees.
## How to run
1. Clone the repository
2. Open the solution in Visual Studio or Rider
3. Run the project (F5)
4. Follow the on screen instructions
