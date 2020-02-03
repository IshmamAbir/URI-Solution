#include<stdio.h>
main()
{
    char country[]={"banGLaDeSh"};
    int i,n,length;
    length=10;
    for(i=0;i<length;i++){
        if(country[i]>=97 && country[i]<=122){
            country[i]='A'+(country[i]-'a');
        }
    }
    printf("%s\n",country);
    return 0;
}
