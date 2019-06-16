rec=input("Unesi rec: ")
for slovo in rec:
    print(slovo)
    
for i in range(0, 101, 5):
    print(i)
    
broj=int(input("\nUnesi broj: "))
for i in range(broj, 0, -1):
    print(i)
    
od=int(input("\nUnesi od: "))
do=int(input("Unesi do: "))
korak=int(input("Unesi korak: "))
for i in range(od, do, korak):
    print(i)

broj=int(input("\nUnesi broj: "))
zbir=0
for i in range(broj+1):
    zbir+=i
    print(zbir)

rec=input("\nUnesi rec: ")
if "a" in rec:
    print("U datoj reci se nalazi slovo a")
else:
    print("U datoj reci nema slova a")

rec=input("\nUnesi rec: ")
if len(rec)>5:
    print(rec[4])
else:
    print(rec[0])

rec=input("\nUnesi rec: ")
for slovo in range(len(rec)-1, -1, -1):
    print(rec[slovo])

rec=input("\nUnesi rec: ")
polovina=int(len(rec)/2)
prva_polovina=rec[:polovina]
druga_polovina=rec[polovina:]
print("Prva polovina reci", rec, "je: ", prva_polovina)
print("A druga polovina reci", rec, "je: ", druga_polovina)

rec=input("\nUnesi rec: ")
for i in range(len(rec)):
    print(i)

