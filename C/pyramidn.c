#include<stdio.h>
void main()
{
int a,b,n;
printf("Enter the row = ");
scanf("%d",&n);
for(a=1;a<=n;a++){
for(b=1;b<=a;b++){
printf("%d",b);
}
printf("\n");
}
}
