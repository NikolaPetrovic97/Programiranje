import random
broj=random.randint(1,100)

while(True):
    pokusaj=int(input("Pokusaj: "))
    if(pokusaj >0 and pokusaj <100):
        if(broj==pokusaj):
            print("Cestitam! ")
            break
        else:
            print("Pokusaj ponovo! ")
    elif(pokusaj==-1):
        print("Odustali ste! ")
    else:
        print("Broj mora biti u ospegu od 1 do 100")

    

broj=int(input("Unesi broj: "))
brojac=1
promenljiva=0

while(brojac<=broj):
    promenljiva+=brojac
    print(brojac)
    brojac+=1

print(promenljiva)    



brojac=0
glava=0
pismo=0
while (brojac<100):
    broj=random.randint(1,2)
    if(broj==1):
        glava+=1
    else:
        pismo+=1
         
    brojac+=1
print("Glava: "+ str(glava)+ "Pismo: "+str(pismo))

import random

while(True):
    broj=int(input("Broj od 1 do 100: "))
    if(broj <=100 and broj>=1):
        break
    else:
        print("Broj mora biti u opsegu od 1 do 100! ")

while(True):
    pokusaj=random.randint(1,100)
    if(broj==pokusaj):
        print("Cestitam! ")
        break



while(True):
    print("""
    Izaberite neku od sledecih opcija:
    Za +: 1
    Za -: 2
    Za *: 3
    Za /: 4
    Za izlaz 0
    """)

    opcija=int(input("Opcija: "))
    if(opcija ==0):
        print("Izabrali ste izlaz iz programa! ")
    else:
        a=int(input("Broj a:"))
        b=int(input("Broj b:"))

    if(opcija ==1):
        print(a+b)
    elif(opcija==2):
        print(a-b)
    elif(opcija==3):
        print(a*b)
    elif(ocija==4):
        print(a/b)
