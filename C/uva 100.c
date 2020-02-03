#include<stdio.h>
main()
{
    int i,j,n;
    double count_1=0,count_2=0,x,y,total;
    scanf("%d%d",&i,&j);
    printf("%d %d ",i,j);
    //while (1){
        do{
            if(i%2!=0){
                i=(3*i)+1;
            }
            else{
                i=i/2;
            }
            count_1=count_1+1;
        }
        while(i>1);

        do{
            if(j%2!=0){
                j=(3*j)+1;
            }
            else{
                j=j/2;
            }
            count_2=count_2+1;
        }
        while(j>1);

    }
    total = count_1+count_2;
    printf("%lf\n",total);
     return 0;


}
