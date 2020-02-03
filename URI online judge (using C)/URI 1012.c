#include<stdio.h>
#define pi 3.14159
main()
{
    double a,b,c,area,square,circle,trapizium,rectengular;
    scanf("%lf%lf%lf",&a,&b,&c);
    area=.5*a*c;
    circle=pi*c*c;
    trapizium=.5*(a+b)*c;
    square=b*b;
    rectengular=a*b;
    printf("TRIANGULO: %.3lf\nCIRCULO: %.3lf\nTRAPEZIO: %.3lf\nQUADRADO: %.3lf\nRETANGULO: %.3lf\n",area,circle,trapizium,square,rectengular);
    return 0;
    }
