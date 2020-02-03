def fibo(x):
    a=0
    b=1

    if x==a:
        return a
    elif x==b:
        return b
    else:
        print(a,b,end=" ")
        for i in range(x-2):

            next_number=a+b
            a=b
            b=next_number
            print (next_number, end=" ")

fibo(10)
