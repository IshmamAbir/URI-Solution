#include<stdio.h>
double convert(double a){
double x;
x=a*2.54;
return x;
}
main()
{
    double a,x;
    printf ("enter scale in inch = ");
    scanf("%lf",&a);
    x= double(a);
    printf ("%lf",x);
    return 0;
}
