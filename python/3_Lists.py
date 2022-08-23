#copyright @learnpython.org
#In this exercise, you will need to add numbers and strings to the correct lists 
#using the "append" list method. 
# ou must add the numbers 1,2, and 3 to the "numbers" list, and the words 
#'hello' and 'world' to the strings variable.
#You will also have to fill in the variable second_name with the second name in the names list, 
#sing the brackets operator []. 
#Note that the index is zero-based, so if you want to access the second item in the list, 
#its index will be 1.


nummern  = []
strings = []
namen   = ["John", "Eric", "Jessica"]

#hier folgt der Code:
zweiter_name = namen[1]
nummern.append(1)
nummern.append(2)
nummern.append(3)

strings.append("Hallo")
strings.append("Welt")

#folgender Code soll die selbst-ausgefüllten Arrays und den zweiten Namen der Liste ausgeben
print(nummern)
print(strings)
print("Der zweite Name auf der Liste ist %s" % zweiter_name)


