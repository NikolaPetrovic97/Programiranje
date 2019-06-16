import random
broj=random.randint(1, 100)
print(broj)

sifra=input("\nUnesi sifru: ")
if sifra=="3479":
    print("Pristup odobren")
else:
    print("Pogresna sifra")

import random
broj=random.randint(1, 100)
pokusaj=int(input("\nPokusaj: "))
while pokusaj!=broj:
    pokusaj=int(input("Pokusaj: "))
    if pokusaj<100 and pokusaj>0:
        if pokusaj==broj:
            print("Cestitam, pogodio si!")
        else:
            print("Niste pogodili dati broj!")
    elif pokusaj==-1:
        print("Odustali ste!")
        break
    else:
        print("Broj je van opsega!")

        
while True:
    opcija=int(input("\nUnesi opciju: "))
    if opcija==1:
        print("Odabrali ste prvu opciju")
    elif opcija==2:
        print("Odabrali ste drugu opciju")
    elif opcija==3:
        print("Odabrali ste trecu opciju")
    elif opcija==4:
        print("Odabrali ste cetvrtu opciju")
    elif opcija==5:
        print("Odabrali ste petu opciju")
    elif opcija==0:
        print("Odabrali ste izlaz iz programa")
        break
    else:
        ("Odabrali ste nepostojecu opciju")

broj=int(input("\nUnesi broj: "))
brojac=1
while brojac<=broj:
    print(brojac)
    brojac+=1

broj=int(input("\nUnesi broj: "))
brojac=1
suma=0
while brojac<=broj:
    suma+=brojac
    brojac+=1
    print(suma)


    
