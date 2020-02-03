#include<stdio.h>

main()
{
    int i,j,ara[]={10,20,30,40,50,60,70,80,90,100},temp;

    for(i=0,j=9;i<10;i++,j--){
        temp=ara[j];
        ara[j]=ara[i];
        ara[i]=temp;

        if(i>j)
            break;


    }

    for(i=0;i<10;i++){
        printf("%d\n",ara[i]);
    }

}
