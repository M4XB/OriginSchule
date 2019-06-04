#include <iostream>
#include <sstream>
#include <windows.h>
#include <stdio.h>
#include <time.h>
#include <math.h>
#include <limits>

using namespace std;

int main(int argc, char *argv[])
{
    //Eingabe
    system("title Selection Sort");
    int numberOfNumbers;
    cout << "Wie viele Zahlen sollen sortiert werden?" << endl;
    cin >> numberOfNumbers;
    int numbers[100];
    for (int i = 0; i < numberOfNumbers; i++) {
        int value;
        cout << "Nenne eine Zahl" << endl;
        cin >> value;
        numbers[i] = value;
    }
    //Start Liste
    for (int i = 0; i < numberOfNumbers; i++) {
        cout << numbers[i] << " ";
    }
    cout << endl;

    //Sortieren
    int inputIndex = 0;
    int maxIndex = numberOfNumbers-1;
    int minIndex;
    int countOfSwaps=1;
    while (inputIndex < maxIndex){
        minIndex = inputIndex;
        for (int i = inputIndex+1; i <= maxIndex; i++){
            if (numbers[i] < numbers[minIndex]){
                minIndex = i;
            }
        }
        int buffer = numbers[inputIndex];
        numbers[inputIndex] = numbers[minIndex];
        numbers[minIndex] = buffer;
        inputIndex +=1;
        //Output
        cout <<endl;
        cout << countOfSwaps << "Tauschvorgang: ";
        for (int i = 0; i < numberOfNumbers; i++) {
            cout <<numbers[i] << " ";
        }
        cout <<endl;
        countOfSwaps ++;
    }
    return 0;
}
