#include<stdio.h>
main()
{
    int a,b,c,d,e,f,g,h,i,j,k,l,n;
    double m;
    scanf("%lf",&m);
    printf("NOTAS:\n");
    n=m*100;
    a=n/10000;
    n=n%10000;
    b=n/5000;
    n=n%5000;
    c=n/2000;
    n=n%2000;
    d=n/1000;
    n=n%1000;
    e=n/500;
    n=n%500;
    f=n/200;
    n=n%200;

    printf("%d nota(s) de R$ 100.00\n%d nota(s) de R$ 50.00\n%d nota(s) de R$ 20.00\n%d nota(s) de R$ 10.00\n%d nota(s) de R$ 5.00\n%d nota(s) de R$ 2.00\n",a,b,c,d,e,f);

    printf("MOEDAS:\n");
    g=n/100;
    n=n%100;
    h=n/50;
    n=n%50;
    i=n/25;
    n=n%25;
    j=n/10;
    n=n%10;
    k=n/5;
    n=n%5;
    l=n/1;


    printf("%d moeda(s) de R$ 1.00\n%d moeda(s) de R$ 0.50\n%d moeda(s) de R$ 0.25\n%d moeda(s) de R$ 0.10\n%d moeda(s) de R$ 0.05\n%d moeda(s) de R$ 0.01\n",g,h,i,j,k,l);
    return 0;

    }
