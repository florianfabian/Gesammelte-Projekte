#copyright @learnpython.org
#The target of this exercise is to create two lists called x_list and y_list, 
#which contain 10 instances of the variables x and y, respectively. 
#You are also required to create a list called big_list, which contains the variables x and y, 
#10 times each, by concatenating the two lists you have created.


x = object()
y = object()

x_list = [x] * 10
y_list = [y] * 10
big_list = x_list + y_list

print("Die Variable x_list beinhaltet %d Objekte" % len(x_list))
print("Die Variable y_list beinhaltet %d Objekte" % len(y_list))
print("Die Variable big_list beinhaltet %d Objekte" % len(big_list))


#Code zum Testen

if x_list.count(x) == 10 and y_list.count(y) == 10:
    print("Fast da!")
if big_list.count(x) == 10 and big_list.count(y) == 10:
    print("Großartig!")
