rezultati=[]

izbor=None

while izbor !=0:
    print("""
            Izaberi opciju:
            0- Izlaz
            1- Prikazi rezultate
            2- Dodaj rezultat
            3- Izbrisi rezultat
            4- Sortiraj rezultate
            """)

izbor=input("Izbor: ")

print()

if izbor=="0":
    
     break

elif izbor=="1":
    for rezultat in rezultati:
        print(rezultat)


elif izbor=="2":
    rezultat=int(input("Unesi rezultat: "))
    rezultati.append(rezultat)


elif izbor=="3":
    rezultat=int(input("Unesi rezultat koji hoces da izbrises: "))
    if rezultat in rezultati:
        rezultati.remove(rezultat)
    else:
        print(rezultat, "se ne nalazi u listi")

elif izbor=="4":
    rezultati.sort(reserve=True)

else:
    print("izabrali ste nepostojecu opciju")


input("\n\nPritisni enter za izlaz")
