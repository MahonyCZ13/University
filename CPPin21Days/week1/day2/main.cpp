#include <iostream>

void mojeFunkce()
{
	std::cout << "Uvnitr funkce 'mojeFunkce'...\n";
}

int soucet(int a, int b)
{
	std::cout << "Prijal jsem cislo 'a': " << a << " a cislo 'b':" << b << "\n";
	return(a + b);
}

int main()
{
	// Misto std::cout muzeme iniciovat jmenny prostor std:
	using namespace std;

	cout << "Nazdar svete!\n";
	mojeFunkce();
	cout << "Zpet v main funkci\n";
	
	int a, b, vysledek;
	cout << "Vlozte dve cisla: ";
	cin >> a;
	cin >> b;
	
	cout << "Dekuji! Scitam..." << endl;
	
	vysledek = soucet(a, b);
	
	cout << "Vysledek je: " << vysledek << endl;
	return 0; 
}
