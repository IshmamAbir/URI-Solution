#include<stdio.h>
main()
{
int a,b,n,space,k=0;
printf("Enter the number of row = ");
scanf("%d",&n);
for(a=1;a<=n;a++){
for (space=1;space<=n-a;space++){
printf(" ");
}
while(k!=2*a-1){
printf("*");
++k;
}
printf("\n");
}
}
