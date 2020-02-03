#include<stdio.h>
#include<math.h>
#define pi 3.14159
main()
{
    double n,r;
    scanf("%lf",&r);
    n=(4.0/3)*pi*pow(r,3);
    printf("VOLUME = %.3lf\n",n);
    return 0;

}
