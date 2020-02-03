#include<stdio.h>

main()
{
    char name[1000];
    double salary,sold,total,bonus;
    gets(name);
    scanf("%lf",&salary);
    scanf("%lf",&sold);
    bonus=(sold * .15);
    total=salary+bonus;
    printf("TOTAL = R$ %.2lf\n",total);
    return 0;
    }
