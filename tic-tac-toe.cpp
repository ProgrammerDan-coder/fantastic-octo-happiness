#include <iostream>
#include <ctime>
#define EMPTY ' '
char mas[3][3] = { 
{EMPTY, EMPTY, EMPTY},
{EMPTY, EMPTY, EMPTY},
{EMPTY, EMPTY, EMPTY}
};

int Move; // если 1 - то ходит игрок
int Win = -1; // если 1 - то игрок выиграл

// отображение игровой доски 
void field()
{
	for (int i = 0; i < 3; ++i)
	{
		std::cout << mas[i][0] << " |" << mas[i][1] << " |" << mas[i][2] << std::endl;
		if (i != 2)
			std::cout << "__|__|__" << std::endl;
	}
}

// ввод хода игрока 
void move_player()
{
	int x;
	int y;
	int _cheak = 0;
	for (int i = 0; i < 3; ++i)
	{
		for (int j = 0; j < 3; ++j)
		{
			if (mas[i][j] == EMPTY)
				++_cheak;
		}
	}
	if (_cheak == 0)
	{
		std::cout << "Draw, you can't move anywhere";
		exit(0);
	}
	std::cout << "Enter coordinates " << std::endl;
	std::cout << "Row: " << std::endl;
	std::cin>>x;
	std::cout << "Column: " << std::endl;
	std::cin >> y;
	x--; 
	y--;
	if (x < 0 || y < 0 || x > 2 || y > 2 || mas[x][y] != EMPTY)
	{
		std::cout << "Error. Incorrect values" << std::endl;
		move_player();
	}
	else 
	{
		if (Move == 1)
			mas[x][y] = 'X';
		else
			mas[x][y] = '0';
	}
		
}

// ход компьютера 
void move_ii()
{
	srand(time(0));
	int i = 0;
	int x;
	int y;
	char* p;
	p = (char*) mas;
	for ( i; *p != EMPTY && i < 9; ++i) // проверка, есть ли еще место для хода 
		p++;
	if (i == 9)
	{
		std::cout << "Draw";
		exit(0); 
	}
	else 
	{
		for (;;)
		{
			x = rand() % 3;
			y = rand() % 3;
			if (mas[x][y] == EMPTY)
			{
				if (Move == 1)
					mas[x][y] = '0';
				else if (Move == 0)
					mas[x][y] = 'X';
				break;
			}
					
		}
	}

}

// проверка на победу 
char check()
{
	int t;
	char* p;
	for (t = 0; t < 3; t++) // проверка строк 
	{ 
		p = &mas[t][0];
		if ((*p == *(p + 1) && *(p + 1) == *(p + 2))  && (*p != EMPTY))
		{
			if ((*p == 'X' && Move == 1) || (*p =='0' && Move ==0))
				Win = 1;
			else
				Win = 0;
		}
	}
	for (t = 0; t < 3; t++) //проверка столбцов 
	{ 
		p = &mas[0][t];
		if (*p == *(p + 3) && *(p + 3) == *(p + 6) && (*p != EMPTY))
		{
			if (*p == 'X' && Move == 1 || (*p == '0' && Move == 0))
				Win = 1;
			else
				Win = 0;
		}
	}

	// проверка диагоналей 
	if (mas[0][0] == mas[1][1] && mas[1][1] == mas[2][2] && (mas[0][0] != EMPTY))
	{
		if ((mas[0][0] == 'X' && Move == 1) || (mas[0][0] == '0' && Move == 0))
			Win = 1;
		else
			Win = 0;
			
		
	}
	if (mas[0][2] == mas[1][1] && mas[1][1] == mas[2][0] && (mas[0][2] != EMPTY))
	{
		if ((mas[0][2] == 'X' && Move == 1) || (mas[0][2] =='0' && Move == 0))
			Win = 1;
		else
			Win = 0;
		
	}
	return EMPTY;
}

int main()
{
	srand(time(0));
	int choice; // чтобы узнать кто первый ходит
	std::cout << "You/II" << std::endl;
	for (;;)
	{
		std::cout << "Who goes first?(1- You; 2 -II; 3 - Random will choose )" << std::endl;
		std::cin >> choice;
		if (choice == 1)
		{
			Move = 1;
			break;
		}
		else if (choice == 2)
		{
			Move = 0;
			break;
		}
		else if (choice == 3)
		{
			Move = rand() % 2;
			break;
		}
		else
			std::cout << "ERROR" << std::endl;
	}
	if (Move == 1)
	{
		std::cout << "You first move" << std::endl;

		for (;;)
		{
			std::cout << "Field" << std::endl;
			field();
			move_player();
			check();
			if (Win == 1 || Win == 0)
				break;
			move_ii();
			check();
			if (Win == 1 || Win == 0)
				break;
		}
	}
	else
	{
		std::cout << "First move II" << std::endl;
		for (;;)
		{
			move_ii();
			check();
			if (Win == 1 || Win == 0)
				break;
			field();
			move_player();
			check();
			if (Win == 1 || Win == 0)
				break;
		}
	}
	field();
	if (Win == 1)
	{
		std::cout << "~~~~~~~~~~~~~~~~~~~~" << std::endl;
		std::cout << "   - You WON!!!-   " << std::endl;
		std::cout << " ~~~~~~~~~~~~~~~~~~~" << std::endl;
	
	}
	else if (Win == 0)
		std::cout << "You LOSE!!!";
	 

}
