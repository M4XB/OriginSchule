#include "pch.h"
#include <string>
#include <iostream>
#include <sstream>
#include <iomanip>
#include <time.h>
#include <Windows.h>

using namespace std;
//Variablen
const int populationCount = 400;
int populationArray[populationCount];
const int sleepingTime = 100;
const int outputs = 5000;

//Methoden
void outputGrid();
void convince(int personPosition);
int customMod(int a, int b);
bool isdictatorship(int n);
void outputWinner(int winner, int count);
void outputLog(int outputCounter);

int main(int argc, char *argv[])
{
	srand(time(NULL));
	//50:50 Bevölkerung
	for (int i = 0; i < populationCount; i++) {
		if (i < 200) {
			populationArray[i] = 0;
		}
		else { populationArray[i] = 1; }
	}
	int countOutputs = 1;
	system("title Demokratur");
	outputGrid();
	while(cin.get() != '\n'){}
	while (1)
	{
		convince(rand() % populationCount);
		if (countOutputs % outputs == 0) {
			system("cls");
			outputGrid();
			outputLog(countOutputs);
			if (isdictatorship(0)) {
				outputWinner(0, countOutputs);
				break;
			}
			else if (isdictatorship(1)) {
				outputWinner(1, countOutputs);
				break;
			}
			Sleep(sleepingTime);
		}
		countOutputs += 1;
	}
	return 0;
}
//ermittelt zufällig einen Nachbar und versucht diesen zu überzeugen
void convince(int personPosition) {
	int random = rand() % 4;
	int position;
	switch (random) {
	case 0: {
		position = customMod((personPosition - 1 + 20) % 20, 20) + (((int)personPosition / 20) * 20);
		break;
	}
	case 1: {
		position = customMod((personPosition + 1 - 20) % 20, 20) + (((int)personPosition / 20) * 20);
		break;
	}
	case 2: {
		position = customMod(personPosition - 20, populationCount);
		break;
	}
	case 3: {
		position = customMod(personPosition + 20, populationCount);
		break;
	}
	}
	if (!populationArray[position] == populationArray[personPosition]) {
		if (rand() % 2 == 1) {
			populationArray[position] = populationArray[personPosition];
		}
	}
}

int customMod(int a, int b) {
	return (a%b + b) % b;
}
//Prüft ob nur noch eine Partei vorhanden ist
bool isdictatorship(int party) {
	bool dictator = false;
	for (int var = 0; var < populationCount; var++) {
		if (populationArray[var] == party) {
			dictator = true;
		}
		else {
			return false;
		}
	}
	return dictator;
}
//Gibt das Feld aus
void outputGrid() {
	ostringstream output;
	for (int i = 0; i < populationCount; i++) {
		output << populationArray[i] << " ";
		if ((i + 1) % 20 == 0)
			output << "\n";
	}
	cout << output.str() << endl;
}
void outputLog(int outputCounter) {
	cout << outputCounter << " Durchläufe" << endl;
}
//Gibt den Gewinner aus
void outputWinner(int winner, int outputCounter) {
	system("cls");
	cout << winner << " has Won!!!" << endl;
	cout << "Nach insgesamt " << outputCounter << " ueberzeugungen!" << endl;
}