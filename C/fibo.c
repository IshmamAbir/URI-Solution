#include<stdio.h>
int fibo(int n){
    if(n=0)
    return n;
    else
    return n=n*fibo(n-1);
}
int main()
{
    int n;
    scanf("%d",&n);
    printf("%d",fibo(n));
}
