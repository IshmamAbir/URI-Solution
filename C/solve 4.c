
#include <stdio.h>
int main()
{
    int LA[1000];
    int n, i, k, item;
    printf("how many numbers: ");
    scanf("%d",&n);
    printf("Enter the numbers: ");
    for(i=1; i<=n; i++)
    {
        scanf("%d", &LA[i]);
    }
    printf("Enter the position to insert an element: ");
    scanf("%d", &k);
    printf("Enter the number you want to insert: ");
    scanf("%d", &item);
    for(i=n;i>=k;i--)
    {
        LA[i+1] = LA[i];
    }
    LA[k] = item;
    n++;

    for(i=1; i<=n; i++)
    {
        printf("%d\n", LA[i]);
    }
    return 0;
}
