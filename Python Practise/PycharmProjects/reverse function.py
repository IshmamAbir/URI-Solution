def reverse_list(l):
    new_list = []

    for i in range(len(l)):
        popped= l.pop()
        new_list.append(popped)

    return new_list

number = [1,2,3,4,5,6,7,8,9]
print(number)
print(reverse_list(number))


  #  return[::-1]

