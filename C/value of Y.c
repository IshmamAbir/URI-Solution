#include<stdio.h>
#include<math.h>
main()
{
    int x,a,y;
    printf("enter the value of x : ");
    scanf("%d",x);
    a=(x-1)/x;
    y=a+(pow(a,2)/2)+(pow(a,3)/3)+(pow(a,4)/4);
    printf("Y = %d",y);
    return 0;
}
