#include <stdio.h>

main()
{

    int i,list[100],no_of_team,temp=0,count= 0;
    printf("How many Team");
    scanf("%d",&no_of_team);

    for(i=1;i<=no_of_team;i++){
        scanf ("%d",list[i]);
    }

    temp=list[1];
    for(i=2;i<=no_of_team;i++){

        if(list[i]>temp){
            temp=list[i];
            count++;
        }
    }
    printf("Highest number = %d",temp);

    printf ("%d Champion",count);





    return 0;
}







