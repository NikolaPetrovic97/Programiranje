file=open("Tekst.txt", "r")

fajl=file.read()

print(fajl)

file.close()


file=open("Tekst.txt", "w")

file.write("Mateja Petrovic")

file.close()


file=open("Tekst.txt", "a")

file.write("\nNikola Petrovic")

file.close()


file=open("Tekst.txt", "r")

for red in file:
    print(red)

file.close()


def Brojevi():
    lista=[]
    file=open("Brojevi.txt", "r")
    for red in file:
        lista.append(int(red))
    return lista

def Suma():
    file=open("Brojevi.txt", "r")
    suma=0
    for red in file:
        suma+=int(red)
    return suma
        
  

brojevi=Brojevi()
print(brojevi)

suma=Suma()
print(suma)
