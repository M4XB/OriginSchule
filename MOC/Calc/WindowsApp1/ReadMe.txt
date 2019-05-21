ReadMe Document:
Functions of the Calculator:
Addition
Substraction
Multiplication
Division
Mdodulo
Convert Units (of Length, of Money, Money to Beer)
Convert Binary, Decimal and Hexadecimal

Root
Square Root
Exponent
Pi

Der Calc kann nun die Punkt vor Strich Regel
Als nächstes soll die Klammer Regel eingebaut werden:
Wenn Klammern
	Klammern zählen
	Wenn ungerade Fehlermeldung
	Term in innerster Klammer zum Berechnen geben und Ergebnis in den Ursprungsterm einsetzen
Sonst direkt das Berechnen mit ganzem Term aufrufen

--> Es wird eine Sub vor der Sub Calculate benötigt, die die Sachen zu den Klammern macht
--> Beim Klicken des Equals Buttons wird dann zunächst diese Sub aufgerufen

Der Calc kann nun mit Klammern rechnen, wenn sie nacheinander stehen und nicht ineinander
Zudem wird am Anfang geprüft, ob 2 Operatoren direkt aneinander stehen, da dies zu einem harten Fehler führt