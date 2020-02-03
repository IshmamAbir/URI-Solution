#include<stdio.h>

main()
{
    int d,m,y,n,f;
    scanf("%d",&n);

    y=(n/365);
    f=n % 365;
    m=f/30;
    d=f%30;

    printf("%d ano(s)\n%d mes(es)\n%d dia(s)\n",y,m,d);

    return 0;
}
