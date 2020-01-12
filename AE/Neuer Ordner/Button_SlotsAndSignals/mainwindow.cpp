#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <iostream>
#include <time.h>

//Variables
QString question;
QString answer1;
QString answer2;
QString answer3;
QString answer4;
bool button1Bool;
bool button2Bool;
bool button3Bool;
bool button4Bool;
int questionCounter = 1;


MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->progressBar->setValue(0);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::init(QString questionText, QString answer1Text, QString answer2Text, QString answer3Text, QString answer4Text, bool answer1Bool, bool answer2Bool, bool answer3Bool, bool answer4Bool){
    //Frage und Antworten für Durchgang speichern
    question = questionText;
    answer1 = answer1Text;
    answer2 = answer2Text;
    answer3 = answer3Text;
    answer4 = answer4Text;



    setLabels(answer1Bool, answer2Bool, answer3Bool, answer4Bool);

}

void getRandomQuestion(){

}

//Label setzen
#define FOLDINGSTART {
//Setzt das Label der Frage
//Setzt die Label der Anworten und speichert die Richtigkeit der Antworten
void MainWindow::setLabels(bool answer1Bool, bool answer2Bool, bool answer3Bool, bool answer4Bool){
    time_t sec;
    time(&sec);
    srand(sec);
    //Setzt den Text für FrageLabel
    ui->QuestionLabel->setText(question);

    QList<QString> allAnswers = {answer1    , answer2    , answer3    , answer4};
    QList<bool> checkAnswers =  {answer1Bool, answer2Bool, answer3Bool, answer4Bool};
    QList<QString> usedAnswers;

    while(!areAllButtonsLabeled()){
        int randAnswerIndex = rand()%3+0;
        QString randAnswerText = allAnswers.at(randAnswerIndex);
        bool answerBool = checkAnswers.at(randAnswerIndex);
        while (usedAnswers.contains(randAnswerText)){
            randAnswerIndex = rand()%3+0;
            randAnswerText = allAnswers.at(randAnswerIndex);
            answerBool = checkAnswers.at(randAnswerIndex);

            //Sucht das letzte Element aus der Liste aller Antworten
            //Da beim zufälligen Auswählen einer Antwort man in eine Endlosschleife gerät xD
            if (usedAnswers.count() == 3){
                for (int i=0;i<allAnswers.count();i++) {
                    if (!usedAnswers.contains(allAnswers.at(i))){
                        randAnswerText = allAnswers.at(i);
                        answerBool = checkAnswers.at(i);
                    }
                }
            }
        }
        usedAnswers.append(randAnswerText);

        int randButton = rand()%4+1;
        while (isButtonLabeled(randButton)){
            randButton = rand()%4+1;
        }
        if (randButton == 1){
            ui->pushButton_1->setText(randAnswerText);
            button1Bool = answerBool;
        }else if (randButton == 2) {
            ui->pushButton_2->setText(randAnswerText);
            button1Bool = answerBool;
        }else if (randButton == 3) {
            ui->pushButton_3->setText(randAnswerText);
            button1Bool = answerBool;
        }else if (randButton == 4) {
            ui->pushButton_4->setText(randAnswerText);
            button1Bool = answerBool;
        }
    }
}

bool MainWindow::isButtonLabeled(int buttonIndex){
    if (buttonIndex == 1){
        if (ui->pushButton_1->text() != "PushButton"){
            return true;
        }else {
            return false;
        }
    }else if (buttonIndex == 2) {
        if (ui->pushButton_2->text() != "PushButton"){
            return true;
        }else {
            return false;
        }
    }else if (buttonIndex == 3) {
        if (ui->pushButton_3->text() != "PushButton"){
            return true;
        }else {
            return false;
        }
    }else if (buttonIndex == 4) {
        if (ui->pushButton_4->text() != "PushButton"){
            return true;
        }else {
            return false;
        }
    }
}

//Prüft, ob das Label von allen Buttons gesetzt ist
bool MainWindow::areAllButtonsLabeled(){
    if (ui->pushButton_1->text() != "PushButton" && ui->pushButton_2->text() != "PushButton" && ui->pushButton_3->text() != "PushButton" && ui->pushButton_4->text() != "PushButton"){
        return true;
    }else {
        return false;
    }
}
#define FOLDINGEND }
//Buttons
#define FOLDINGSTART {
void MainWindow::on_pushButton_1_clicked(){
    if (button1Bool){
        questionCounter +=1;
        ui->progressBar->setValue(ui->progressBar->value()+100/15);
    }else {

    }
}

void MainWindow::on_pushButton_2_clicked(){
    if (button2Bool){
        questionCounter +=1;
        ui->progressBar->setValue(ui->progressBar->value()+100/15);
    }else{

    }
}

void MainWindow::on_pushButton_3_clicked(){
    if (button3Bool){
        questionCounter +=1;
        ui->progressBar->setValue(ui->progressBar->value()+100/15);
    }else{

    }
}

void MainWindow::on_pushButton_4_clicked(){
    if (button4Bool){
        questionCounter +=1;
        ui->progressBar->setValue(ui->progressBar->value()+100/15);
    }else{

    }
}
#define FOLDINGEND }
