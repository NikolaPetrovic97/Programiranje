lista=[1, 2, 3, 4, 5, "Nikola", "Programiranje"]

print(lista)

for element in lista:
    print(element)



for i in range(0, len(lista), 2):
    print(lista[i])


s=""

for i in range(0, len(lista), 2):
    s+=str(lista[i])+" "

print(s)



duzina=int(input("Unesi duzinu liste: "))

lista=[]

for i in range(duzina):
    clan=input("Unesi " +str(i)+ ". clan liste ")
    lista.append(clan)

lista1=lista[:int (duzina/2)]

lista2=lista[int (duzina/2):]

print(lista1)

print(lista2)



