#include<stdio.h>
main()
{
    int ara[]={1,4,6,8,9,11,14,15,20,25,33,83,87,97,99,100};
    int low_indx=0,high_indx=15,n,mid_indx;
    printf("Enter a number between 1 to 100 :- ");
    scanf("%d",&n);
    while(low_indx<=high_indx){
        mid_indx=(low_indx+high_indx)/2;
        if(n==ara[mid_indx]){
            break;
        }
        if(n<ara[mid_indx]){
            high_indx=mid_indx-1;
        }
        else {
            low_indx=mid_indx+1;
        }
    }
    if(low_indx>high_indx){
        printf("%d is not in the array\n",n);
    }
    else {
        printf("%d is found in the array . It is the %d th element of the array",ara[mid_indx],mid_indx);
        }
    return 0;
}
