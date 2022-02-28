import io

class Color:
   PURPLE = '\033[95m'
   CYAN = '\033[96m'
   DARKCYAN = '\033[36m'
   BLUE = '\033[94m'
   GREEN = '\033[92m'
   YELLOW = '\033[93m'
   RED = '\033[91m'
   BOLD = '\033[1m'
   UNDERLINE = '\033[4m'
   END = '\033[0m'

print(f"\n{Color.BOLD}---------------------{Color.END}")
print(f"{Color.YELLOW}Algoritmus: Euklides{Color.END}")
print(f"{Color.BOLD}---------------------{Color.END}\n")

x = 13400
y = 656
z = 1

while z != 0:
    z = x % y
    print(x, "%", y, "=", z)
    x = y - z
    print(y, "-", z, "=", x)
    if z == 0:
        z = y
        break
    else:
        y = z
    print("y =", y)
    print("--------")

print(f"\n{Color.GREEN}NSD =", z, f"{Color.END}\n")
