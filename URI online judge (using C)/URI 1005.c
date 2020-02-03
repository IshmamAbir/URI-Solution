#include <stdio.h>

 main() {

    double A=0,B=0,MEDIA;
    scanf("%lf",&A);
    scanf("%lf",&B);
    if (A<=10 && B<=10){
        MEDIA=((A*.055)+(B*.055))/2;
        printf("MEDIA = %.5lf\n",MEDIA);
     }
    else
        printf("no result");
    return 0;
}
