// Task 1 from Paper 1 -> Va*b ?

double a = 16.8;
double b = 12.4;

double c = Math.Sqrt(a * b);
var d = c.ToString("F2");

Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine("End of the 1st task \n");

// Task 2 from Paper 1 -> AC, BC, AC + BC ?

double A = 1.4;
double B = -5.5;
double C = 0.6;

double AC = Math.Abs(A - C);
double BC = Math.Abs(B - C);
double AB = AC + BC;

Console.WriteLine(AC.ToString("F2"));
Console.WriteLine(BC.ToString("F2"));
Console.WriteLine((AC + BC).ToString("F2"));
Console.WriteLine("End of the 2nd task \n");

// Task 3 from Paper 1 -> V((x2 - x1)^2 - (y2 - y1)^2) ?

double[] col1 = { -6.2, 5.2 };
double[] col2 = { 2.1, 9.8 };

double dist = Math.Sqrt(Math.Pow((col2[0]-col1[0]),2) + Math.Pow((col2[1]-col1[1]),2));
Console.WriteLine(dist.ToString("F2"));
Console.WriteLine("End of the 3rd task \n");

// Task 4 from Paper 1 -> make 41 -> 14

int num = 41;

int singleNum = num / 10;
int newNum = num % 10;
Console.WriteLine(newNum * 10 + singleNum);
Console.WriteLine("End of the 4th task \n");

// Task 5 from Paper 1 -> n - integer in seconds. Find full minutes

int n = 10985;

int m = n / 60;
Console.WriteLine(m);
Console.WriteLine("End of the 5th task \n");

/* Task 6 from Paper 1

    0 - Sunday
    1 - Monday
    2 - Tuesday
    3 - Wednesday
    4 - Thursday
    5 - Friday
    6 - Saturday

    Which day of the week is day #202?
*/

/* Given day */
int k = 202;

int weeks = k / 7;
int dayOfWeek = 202 - weeks * 7;

Console.WriteLine(dayOfWeek);
Console.WriteLine("End of the 6th task \n");