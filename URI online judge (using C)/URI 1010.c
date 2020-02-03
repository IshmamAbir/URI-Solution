#include <stdio.h>

main()
{
    int p1,p2,q1,q2;
    float t1,t2,b1,b2,total;
    scanf ("%d%d%f",&p1,&q1,&b1);
    scanf ("%d%d%f",&p2,&q2,&b2);
    t1=q1*b1;
    t2=q2*b2;
    total=t1+t2;
    printf("VALOR A PAGAR: R$ %.2f\n",total);


    return 0;
}
