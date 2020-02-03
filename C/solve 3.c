#include<stdio.h>
int main()
{
    int n,i,count,ara[100000];
    scanf("%d",&n);
    for(i=1;i<=n;i++){
            count = 0;
        scanf("%d",&ara[i]);
    }
    for(i=1;i<=n;i++){
        if(ara[i]>=40){
            count++;
        }
    }
    printf("Number of student passed : %d\n",count);
    return 0;
}
