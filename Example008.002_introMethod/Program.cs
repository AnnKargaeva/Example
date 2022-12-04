int Max(int arq1, int arq2, int arq3)
{
    int result = arq1;
    if(arq2 > result) result = arq2;
    if(arq3 > result) result = arq3;
    return result;
}
//              0 1 2 3 4 5 6 7 8 
int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
array[0] = 12;
Console.WriteLine(array[4]);

