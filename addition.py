#Simple addition
print()
x = int(input("Enter number1: "))
y= int(input("Enter number2: "))
z = x + y

print(f"{x} + {y} = {z}")
print()
#Addition using function
def add():
	x = int(input("Enter number1: "))
	y= int(input("Enter number2: "))
	print(f"{x} + {y} = {x+y}")

add()
print()