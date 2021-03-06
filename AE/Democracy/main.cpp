#include <QCoreApplication>
#include <string>
#include <iostream>
#include <sstream>
#include <iomanip>
#include <time.h>
#include <Windows.h>

using namespace std;

//Variablen
const int populationCount = 400;
const int populationArray[populationCount];
const int sleepingTime = 100;
const int outputs = 10000;

//Methodens
void outputGrid();
void convince(int personPosition);
int customMod(int a, int b);
bool isdictatorship(int n);
void outputWinner(int winner, int count);
void outputCounter(int counter);

int main(int argc, char *argv[])
{

    srand(time(NULL));
    //50:50 Bev�lkerung
    for(int i = 0; i < populationCount; i++){
        //populationArray[i] = rand()%2;
        if(i<200){populationArray[i] = 0;}
        else{populationArray[i] = 1;}
    }
    int countOutputs = 1;
    system("title Demokratur");
    outputGrid();
    while (cin.get() != '\n');
    while(1){
        int randomPerson = rand()%400;
        convince(randomPerson);
        if (countOutputs % outputs == 0){
            system("cls");
            outputGrid();
            if(isdictatorship(0)){
                outputWinner(0, countOutputs);
                break;
            }
            else if (isdictatorship(1)) {
                outputWinner(1, countOutputs);
                break;
            }
            outputCounter(countOutputs);
            Sleep(sleepingTime);
        }
        countOutputs +=1;
    }
    return 0;
}
//ermittelt zuf�llig einen Nachbar und versucht diesen zu �berzeugen
void convince(int personPosition) {
    int random = rand() % 4;
    int position;
    switch (random) {
        case 0: {//Links
            position = customMod((personPosition - 1 + 20) % 20, 20) + (((int)personPosition / 20) * 20);
            break;
        }
        case 1: {//Rechts
            position = customMod((personPosition + 1 - 20) % 20, 20) + (((int)personPosition / 20) * 20);
            break;
        }
        case 2: {//Oben
            position = customMod(personPosition - 20, populationCount);
            break;
        }
        case 3: {//Unten
            position = customMod(personPosition + 20, populationCount);
            break;
        }
    }
    if(!populationArray[position] == populationArray[personPosition]){
        if (rand() % 2 == 1) {
            populationArray[position] = populationArray[personPosition];
        }
    }
}
//Das Ergebnis ist immer positiv, auch bei einer negativen Zahl a
int customMod(int a, int b){
    return (a%b+b)%b;
}
//Pr�ft ob nur noch eine Partei vorhanden ist
bool isdictatorship(int party) {
    bool dictator = false;
    for (int var = 0; var < populationCount; var++) {
        if(populationArray[var] == party){
            dictator = true;
        }else{
            return false;
       }
    }
    return dictator;
}
//Gibt das Feld aus
void outputGrid(){
   ostringstream output;
    for(int i=0; i < populationCount; i++){
        output << populationArray[i] << " ";
        if ((i + 1) % 20 == 0)
            output << "\n";
    }
    cout << output.str() << endl;
}

//Gibt die Anzahl der Durchl�ufe aus
void outputCounter(int counter){
    cout << counter << endl;
}

//Gibt den Gewinner aus
void outputWinner(int winner, int outputCounter){
    system("cls");
    cout << winner << " has Won!!!" << endl;
    cout << "Nach insgesamt " << outputCounter << " ueberzeugungen!" << endl;
}
