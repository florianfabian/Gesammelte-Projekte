#Copyright @ learnpython.org
#You will need to write a format string which 
#prints out the data using the following syntax: 
#Hello John Doe. Your current balance is $53.44.

data = ("John", "Doe", 53.44)
format_string = "Hello"

print(format_string + " %s" % data[0] + " %s" % data[1] + " your balance is $%d" % data[2])