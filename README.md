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
Directing the game, and displaying the game, keeping/changing score
Behaviors
-Starts game
-Does updates (Receive user input)
-Does outputs (Displays information and announces the card)
State
-Game continue? [y/n]
-Guess next card [h/l]
-Determine score
-Determine if higher or lower

Class Director
-DoUpdate(): void
-StartGame(): void
-GetGuess(): void
-GetPlayAgain(): bool
-DoOutput(): void
-HasLoser(): bool




Object: Card
Responsibility:
keeps track of cards
Behaviors:
-Picks random card value
State:
-first Card Number
-second card number

Class: Card
-DrawCard(): int
-CorrectGuess(): bool
-GetScore(): int
