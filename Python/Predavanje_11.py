try:
    broj=int(input("Unesi broj: "))
    lista=[1, 2, 3, 4, 5]
    print(lista[10])
    print(broj/0)  
except ValueError:
    print("Pogresan unos")
except ZeroDivisionError:
    print("Greska zbog deljenja sa nulom")
except IndexError:
    print("Pogresan indeks u listi")
except:
    print("Ostale greske")
else:
    print("Kraj")


print("\nKraj!")
