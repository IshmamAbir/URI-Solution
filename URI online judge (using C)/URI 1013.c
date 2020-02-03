#include<stdio.h>
main()
{
    int a,b,c,s,n;
    scanf("%d%d%d",&a,&b,&c);
    s=(a+b+abs(a-b))/2;
    n=(s+c+abs(s-c))/2;
    printf("%d eh o maior\n",n);
    return 0;
}
