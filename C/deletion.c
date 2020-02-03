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
    printf("Enter the position to delete an element: ");
    scanf("%d", &k);

    item = LA[k];

    for(i=k; i < n; i++)
    {
        LA[i] = LA[i+1];
    }
    n--;

    for(i=1; i<=n; i++)
    {
        printf("%d\n", LA[i]);
    }
    return 0;
}
