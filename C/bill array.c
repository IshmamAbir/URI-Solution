#include<stdio.h>
main()
{
int client[10];
float per_unit_bill=2.5,total_bill[10],unit[10];
int i=0;
for(i=0;i<10;i++){
printf("Enter the used unit of client %d = ",i+1);
scanf("%f",&unit[i]);
}
printf("\n\n");
for (i=0;i<10;i++){
total_bill[i]=unit[i]*per_unit_bill;
printf("The bill for %d user is %.2f\n",i+1,total_bill[i]);
}
return 0;
}
