import random
broj=random.randint(1, 100)
pokusaj=int(input("Pokusaj: "))
broj_pokusaja=1

while pokusaj!=broj:
    if pokusaj>broj:
        print("Nizi...")
    else:
        print("Veci...")

    pokusaj=int(input("Pokusaj: "))
    broj_pokusaja+=1

print("\nCestitam, pogodio si!")
print("Broj je bio", broj, "i trebalo ti je", broj_pokusaja, "pokusaja")

input("\n\nPritisni enter za kraj")
