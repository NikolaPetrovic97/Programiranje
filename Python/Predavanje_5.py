while True:
    rec=input("Unesi rec: ")
    if "a" in rec:
        print("Ima slovo a")
        break
    else:
        print("Nema slova a")
      
while True:
    rec=input("Unesi rec: ")
    if (len(rec)>5):
        print(rec[4])
        break
    elif (len(rec)>0):
        print(rec[0])
        break
    else:
        print("Unesi rec: ")


for i in range (5, 0, -1):
    print("\n",i)

    
rec=input("\nUnesi rec: ")
print(rec, end=" ")

for i in range(len(rec) -1, -1, -1):
    print(rec[i], end="")

            

rec=input("\nUnesi rec: ")

polovina= int(len(rec)/2)
print(rec[:polovina])
print(rec[polovina])


recenica=input("Unesi recenicu: ")

for i in range (len(recenica)):
    if recenica[i]== "a":
        print(i)




