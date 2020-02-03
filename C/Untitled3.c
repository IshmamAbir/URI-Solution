#include<stdio.h>
main()
{
int i=0,b=0;
for(i=1;i<9;i++){
if (i%2==1){
b=b+i;
}
else
b--;
printf("%d\n",b);
continue;
}
return 0;
}
