print("Nikola", "Petrovic")

print("\nNikola",
"Petrovic")

print("""\nNikola
Petrovic""")

print("\nNikola" + " Petrovic")

print("\nProizvod 2 i 3 je: ", 2*3)

ime="Nikola"
prezime="Petrovic"
print("\n", prezime, ime)

ime=" \nNikola"
print(ime *12)

ime=input("\nUnesi ime: ")
print(ime)

ime=input("\nUnesi ime: ")
broj=int(input("Unesi broj: "))
print(ime*broj)

tekst=input("\nUnesi tekst: ")
print("Originalni tekst: ", tekst)
print("Velika slova: ", tekst.upper())
print("Mala slova: ", tekst.lower())

cena1=int(input("\nUnesi cenu: "))
cena2=int(input("Unesi cenu: "))
cena3=int(input("Unesi cenu: "))
cena4=int(input("Unesi cenu: "))
cena5=int(input("Unesi cenu: "))
print("Ukupna cena: ", cena1+cena2+cena3+cena4+cena5)

a=int(input("\nUnesi broj: "))
b=int(input("Unesi broj: "))
print("Ostatak pri deljenju: ", a%b)


godine=int(input("\nUnesi godine: "))
print("Starost u sekundama: ", godine*365*24*60*60)
input("\n\nPritisni enter za izlaz")

a=int(input("\nUnesi broj: "))
b=int(input("Unesi broj: "))
print("Zbir: ", a+b)
print("Razlika: ", a-b)
print("Proizvod: ", a*b)
print("Kolicnik: ", a/b)

tekst=input("\nUnesi tekst: ")
broj=int(input("Ubesu broj: "))
poruka=tekst + ": "+ str(broj)
print(poruka)

ime=input("Unesi ime: ")
prezime=input("Unesi prezime: ")
print(ime, prezime)
print(ime, "\n",prezime)
print(ime*2, prezime*3)
