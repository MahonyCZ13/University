import io

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

print("NSD je:", z)
