#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QPushButton>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow();
    void init(QString questionText, QString answer1Text, QString answer2Text, QString answer3Text, QString answer4Text, bool answer1Bool, bool answer2Bool, bool answer3Bool, bool answer4Bool);

private slots:
    void on_pushButton_1_clicked();

    void on_pushButton_2_clicked();

    void on_pushButton_3_clicked();

    void on_pushButton_4_clicked();

private:
    Ui::MainWindow *ui;
    void setLabels(bool answer1Bool, bool answer2Bool, bool answer3Bool, bool answer4Bool);
    bool areAllButtonsLabeled();
    bool isButtonLabeled(int ButtonIndex);
    void getRandomQuestion();
};

#endif // MAINWINDOW_H
