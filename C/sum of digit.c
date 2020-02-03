#include <stdio.h>

void main()
{
    long num, temp, digit, sum = 0;

    printf("Enter the number \n");
    scanf("%ld", &num);
    while (num > 0)
    {
        digit = num % 10;
        sum  = sum + digit;
        num /= 10;
    }
    printf("Sum %ld\n", sum);
}
