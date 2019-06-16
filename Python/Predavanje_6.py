lista= [11, 21, 58, 63, 71, 82, 21]

s=""
for i in range(0, len(lista), 2):
   s+=str(lista[i])+ " "
print(s)

del lista[1]
print(lista)


lista.append(99)
print(lista)

lista.sort()
print(lista)

c=lista.count(21)
print(c)

i=lista.index(21)
print(i)

lista.remove(21)
print(lista)



lista=[]
duzina=int(input("\nUnesi duzinu liste: "))

for i in range(duzina):
    s=input(str(i+1)+ ".clan liste: ")
    lista.append(s)
print(lista)
print(lista[:duzina//2])
print(lista[duzina//2:])




