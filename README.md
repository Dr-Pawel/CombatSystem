First playable version of the Combat System project — a simple turn-based console battle system written in C#.
This version showcases the core mechanics of player/enemy combat, basic attacks, and status effects.

✅ Player and Enemy classes with shared Character base

✅ Physical and Magical attacks (Attack abstraction)

✅ Dynamic attack creation using AttackFactory

✅ Status Effects system (e.g. Burn, Poison)

✅ Basic console-based UI for choosing attacks

✅ Randomized enemy attacks

✅ Health and healing system

✅ Basic win/lose conditions

🖼️ Screenshots

Player's Turn

<img width="302" height="209" alt="Zrzut ekranu 2025-10-17 014330" src="https://github.com/user-attachments/assets/988e48ed-9a1d-462b-8d38-582929e83217" />

Effect's status

<img width="404" height="89" alt="obraz_2025-10-17_015406874" src="https://github.com/user-attachments/assets/0a23ce20-b630-426e-978a-539ef826bcca" />

Enemy's turn

<img width="458" height="106" alt="Zrzut ekranu 2025-10-17 014409" src="https://github.com/user-attachments/assets/6479eb79-610a-4327-8e26-a89a39ac8079" />

🕹️ How to Run
1.Download or clone the repository
2.Open in Visual Studio
3.run the project

💡 Quick guide for modifying the code

You can use existing effects or create new ones — every effect is a separate class that inherits from the IEffect interface.

To create new attacks, open AttackFactory.cs — specify:

name

damage

(optional) an Effect

Both Player and Enemy classes inherit from Character.cs.
You can define which attacks each of them should have.
During gameplay, the Player can manually choose which attack to perform,
while the Enemy selects a random attack from its attack list.

If you donwloaded the .zip form this release, simply extract it and run:
CombatSystem.exe

🐛 Bugs & Notes

If you encounter any bugs, feel free to let me know!
I don’t plan to develop this app further, since it was mainly a programming exercise,
but I might reuse this system in a future text-based adventure game or another project.

Developed by Paweł 'DrPawel' Turek
