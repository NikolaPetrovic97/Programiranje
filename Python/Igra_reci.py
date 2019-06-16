import random
RECI=("python", "programiranje", "radan", "mika", "odgovor")
rec=random.choice(RECI)
correct=rec
ispreturano=""

while rec:
    pozicija=random.randrange(len(rec))
    ispreturano+=rec[pozicija]
    rec=rec[:pozicija]+ rec[(pozicija +1):]

print("Ispreturana rec je: ", ispreturano)
pokusaj=input("\nPokusaj: ")
while pokusaj !=correct and pokusaj !="":
    pokusaj=input("Pokusaj ponovo :")
if pokusaj==correct:
    print("Pogodio si!")

input("\n\nPritisni enter za izlaz ")
