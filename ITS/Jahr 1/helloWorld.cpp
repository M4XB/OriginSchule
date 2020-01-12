#include <iostream>
int a = 5; 
int b = 5;
int main()
{
	add();
}

int add()
{
	std::cout << a;
	std::cout << "*";
	std::cout << b;
	std::cout << "=";
	std::cout << a*b;
}