#include<stdio.h>
int factorial(int a){
if(a==0){
return 1;
}
return a*factorial(a-1);
}
int main()
{
int n;
printf(("enter the number = "));
scanf("%d",&n);
if(n<0){
printf("Undefined");
return 0;
}
printf("answer is %d",factorial(n));
}
