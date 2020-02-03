#include<stdio.h>
main()
{
    int n,h,m,s;
    scanf("%d",&n);
    m=n/60;
    n=n%60;
    h=m/60;
    m=m%60;
    s=n%60;
    printf("%d:%d:%d\n",h,m,s);

    return 0;

}
