lista=[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

s=""

for i in range(0, len(lista), 2):
   s+=str(lista[i])+ " "
   
print(s)


import random

lista=["Programiranje", "Python", "Mika", "Radan"]

while(len(lista)>0):
    n= random.randint(0, len(lista)-1)
    print(lista[n])
    lista.remove(lista[n])


lista=[1, 2, 3, 4, 5, 6]
        
n=len(lista)

minimum=lista[0]
maksimum=lista[0]
suma=0

for i in lista:
    if(minimum > i): minimum=i
    if(maksimum < i): maksimum=i
    suma+=i
    
print("Minimum: ", minimum)
print("Maksimum: ", maksimum)
print("Prosek: ", suma/n)

def suma_prvih_100(n):
    suma=0
    for i in range(1, n+1):
        suma+=i
    return suma
    

x=suma_prvih_100(100)
print(x)

