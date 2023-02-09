Console.Clear();
Console.SetCursorPosition(10, 4);
Console.WriteLine("+");

int xa = 1, ya = 30, 
    xb = 80, yb = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");


int x = xa, y = xb;
int count = 10;

while(count < 10000)
{
    int what = new Random().Next(0, 3); //[0;3) 0 1 2
    if(what == 1)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
     Console.SetCursorPosition(x, y);
     Console.WriteLine("+");
     count++;




}