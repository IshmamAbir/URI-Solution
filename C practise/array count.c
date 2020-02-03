#include<stdio.h>

 main()
 {
    int i,count[100],mark[]={67,89,97,82,100,64,64,83,83,50,57,69,78,67,67,54,51,71,67,62,73,73,82,62,68,89,86,67,68,89,84,84,64,64,64,64,71,73,83,98};


    for(i=0;i<100;i++)
        count[i]=0;

    for(i=0;i<40;i++)
        count[mark[i]-1]++;


    for(i=49;i<100;i++)
        printf("mark= %d\t count=%d\n",i+1,count[i]);




    return 0;
 }
