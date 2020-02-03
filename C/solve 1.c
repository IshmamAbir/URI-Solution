#include<stdio.h>
int main()
{
    int i,n,largest,ara[100000];
    scanf("%d",&n);
    for(i=0;i<n;i++){
        scanf("%d",&ara[i]);
    }
    largest = ara[0];
    for(i=0;i<n;i++){
        if(largest<ara[i]){
            largest=ara[i];
        }
    }
    printf("The largest number is : %d\n",largest);
    return 0;
}
