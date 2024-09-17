# Unity Subclass Sandbox Pattern

This Unity project demonstrates the **Subclass Sandbox Pattern**, a design pattern that promotes code reuse and separation of responsibilities by defining a shared structure in a base class, while allowing specific behaviors to be implemented in derived classes. This pattern is commonly used in games to create different types of enemies that share common behaviors but differ in their specific implementations.

## Overview

In this project, we have implemented different enemy types using the **Subclass Sandbox Pattern**. Each enemy shares common behaviors like moving towards the player, but each enemy type has its own unique movement logic, encapsulated in its respective subclass.

### Classes

1. **Enemy (Base Class)**:
    - This abstract class defines common behavior for all enemies, such as moving towards the player and handling collisions with the player. Each enemy subclass inherits from this base class and must implement its own movement behavior.

2. **FastEnemy (Subclass)**:
    - Moves quickly towards the player.
    - Speed: 2.5 units per second.

3. **SlowEnemy (Subclass)**:
    - Moves slowly towards the player.
    - Speed: 0.25 units per second.

4. **SmartEnemy (Subclass)**:
    - Moves towards the player in a zig-zag pattern.
    - Speed: 0.5 units per second.

5. **EnemySpawner**:
    - Spawns different types of enemies at random positions on the scene at the start of the game.

6. **PlayerController**:
    - Controls the player’s movement using keyboard input (WASD or arrow keys).
    - The player can collide with enemies and will be destroyed upon contact.

## How It Works

- **Enemy Base Class**: The base `Enemy` class handles common functionality like detecting the player's position, moving towards the player, and reacting to collisions. However, each enemy subclass provides its own unique movement behavior by overriding the `Move()` method.

- **Derived Classes**: The derived classes (`FastEnemy`, `SlowEnemy`, `SmartEnemy`) inherit from the `Enemy` class and override the `Move()` method to provide specific behaviors. This makes it easy to add new enemy types without modifying the base class.

- **Enemy Spawning**: The `EnemySpawner` class instantiates the different types of enemies at random positions when the game starts, adding variety to the gameplay.

## Key Features

- **Subclass Sandbox Pattern**: This project is an excellent example of how to implement the Subclass Sandbox Pattern in Unity, where a base class defines the common behavior and subclasses specialize their behavior.
  
- **Separation of Concerns**: The code adheres to SOLID principles, especially the **Single Responsibility Principle (SRP)**, by clearly separating each enemy's behavior into its own class.

- **Dynamic Player Interaction**: The `PlayerController` allows the player to move around the scene, and enemies dynamically react by moving toward the player's position.

## How to Use

1. **Player Movement**: Use the arrow keys or WASD to move the player around the scene.
2. **Enemy Behavior**: Observe the different enemy types:
    - **FastEnemy**: Moves quickly towards the player.
    - **SlowEnemy**: Moves slowly but steadily towards the player.
    - **SmartEnemy**: Moves in a zig-zag pattern while approaching the player.
3. **Player-Enemy Interaction**: If the player collides with any enemy, the player will be destroyed.


## Design Patterns Used

- **Subclass Sandbox Pattern**: Demonstrates how to create different enemy behaviors using a common base class while allowing subclasses to specialize their actions.
- **Factory Method**: The `EnemySpawner` class indirectly implements a basic factory method by spawning different types of enemies.


## License

This project is open-source and available under the MIT License. Feel free to modify and use it for educational purposes.
