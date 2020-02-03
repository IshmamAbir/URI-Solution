#include<stdio.h>

int test(int x);

main()
{
    int x=10,y=20,z=30;
    z=test(x);
    printf("%d \n%d \n%d",x,y,z);

    return 0;

}

int test(int x){
    int z=0,y=x;
    x=2*y;
     printf("%d \n%d \n%d\n",x,y,z);
    return (x*y);
}
