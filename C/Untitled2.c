#include<stdio.h>
main()
{
int a=0,b=0;
while (a<25){
if (a%6==0){
b=b+a;
printf("%d\n",a);
}
a++;
}
return 0;
}
