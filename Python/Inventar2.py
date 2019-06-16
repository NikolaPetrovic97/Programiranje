inventar=[]

if not inventar:
    print("Nemas nista")

input("\nPritisni enter za nastavak")

inventar=["mac",
           "sekira",
           "stit",
           "oklop",
           "kaciga",
           "konj",
           "napitak"]

print("\nTvoj inventar je: ")
print(inventar)


for element in inventar:
    print("\n",element)

print("\nImas", len(inventar), "elemenata u svom inventaru")

if "mac" in inventar:
    print("\nImas mac u svom inventaru")
else:
    print("\nNemas mac u svom inventaru")

index=int(input("\nUnesi broj indeksa za element u inventaru: "))
print("\nNa indeksu: ", index, "je: ", inventar[index])

start=int(input("\nStart: "))
finish=int(input("Finish: "))

print("\nInventar[", start, ":", finish, "] je", end="")
print(inventar[start:finish])

kovceg=["zlato", "dragulji"]
print("\nPronasao si kovceg. On sadrzi: ")
print(kovceg)

for element in kovceg:
    print("\n",element)

print("\nSadrzaj kovcega je dodat tvom inventaru")

inventar+=kovceg
print("Tvoj inventar je sad: ")
print(inventar)

for element in inventar:
    print("\n",element)




input("\n\nPritisni enter za izlaz")    
