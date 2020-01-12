#include "mainwindow.h"
#include <QApplication>
#include <QPushButton>
#include <iostream>
#include <QWidget>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;

    QString question = "Wie alt bin ich?";
    QString answer1 = "18";
    QString answer2 = "17";
    QString answer3 = "16";
    QString answer4 = "19";
    bool answerBool1 = false;
    bool answerBool2 = false;
    bool answerBool3 = false;
    bool answerBool4 = true;


    w.show();



    w.init(question, answer1, answer2, answer3, answer4, answerBool1, answerBool2, answerBool3, answerBool4);

    return a.exec();
}
