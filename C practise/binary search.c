
#include<stdio.h>

main()
{
    int n=2,i,ara[16]={1,4,6,8,9,11,14,15,20,25,33,83,87,97,99,100},low_index=0,high_index=15,mid_index=0;

    while(low_index<=high_index){

        mid_index=(low_index+high_index)/2;

        if(ara[mid_index]==n)
            break;

        if(n < ara[mid_index])
            high_index=mid_index-1;

        else{
            low_index=mid_index+1;
        }

    }

    if(low_index >high_index)
        printf("%d is not in the array",n);

    else
        printf("%d found in the array .It is the %dth position",ara[mid_index],mid_index+1);



    return 0;

}
