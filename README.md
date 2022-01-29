# cse210_hilo
FILES:
program.cs
Director.cs
Card.cs

DOC:

Appendix: Designing Together
Hilo Specification
Abstraction: Teach One Another
DISCORD:

https://discord.gg/htj2yhe2

Object: Director
Responsibility
Directing the game, and displaying the game, and holding score
Behaviors
-Starts game
-Does updates (Receive user input)
-Does outputs (Displays information and announces the card)
-State
-Game continue? [y/n]
-Guess next card [h/l]

Class Director
-DoUpdate(): void
-StartGame(): void
-GetGuess(): void
-GetPlayAgain(): bool
-DoOutput(): void
-HasLoser(): bool




Object: Card
Responsibility:
modifies player's score, and card value
Behaviors:
-Picks random card value
-Determine score
-Determine if higher or lower
State:
-first Card Number
-second card number

Class: Card
-DrawCard(): int
-CorrectGuess(): bool
-GetScore(): int
