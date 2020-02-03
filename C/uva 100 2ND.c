
#include<stdio.h>
main()
{
    int i,j,n;
    double count_1=0,count_2=0,x,y,total;
    scanf("%d%d",&i,&j);
    printf("%d %d ",i,j);
    for(x=i;x>1;){
        if(i%2!=0){
                i=(3*i)+1;
            }
            else{
                i=i/2;
            }
            count_1=count_1+1;
            if(i==1)
                break;
    }
    for (y=j;y>1;){
        if(j%2!=0){
                j=(3*j)+1;
            }
            else{
                j=j/2;
            }
            count_2=count_2+1;
            if(jaa\==1)
                break;
    }
    total = count_1+count_2;
    printf("%lf\n",total);
     return 0;
}
