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

print(f"\n{Color.BOLD}---------------------------------{Color.END}")
print(f"{Color.YELLOW}Algoritmus: Euklides - Rozsireny{Color.END}")
print(f"{Color.BOLD}---------------------------------{Color.END}\n")
    
def euklidExt(a, b):
 
    if a == 0 : 
        return b, 0, 1
            
    gcd, x1, y1 = euklidExt(b%a, a)
    
    x = y1 - (b//a) * x1
    y = x1
    
    return gcd, x, y
     

a, b = 35,15
g, x, y = euklidExt(a, b)
print(f"{Color.GREEN}NSD =", g, f"{Color.CYAN} x =", x, " y =", y,f"{Color.END}\n")