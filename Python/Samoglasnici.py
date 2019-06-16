poruka=input("Unesi poruku: ")
nova_poruka=""

SAMOGLASNICI="aeiou"
print()
for slova in poruka:
    if slova.lower() not in SAMOGLASNICI:
        nova_poruka+=slova
        print("Kreirana je nova poruka: ", nova_poruka)


print("\nTvoja poruka bez samoglasnika je: ", nova_poruka)

input("\n\nPritisni enter za izlaz")
