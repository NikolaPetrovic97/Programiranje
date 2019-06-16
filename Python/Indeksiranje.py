import random

rec=input("Unesi rec: ")
print("Rec je: ", rec, "\n")

high=len(rec)
low=-len(rec)

for i in range(10):
    pozicija=random.randrange(low, high)
    print("rec[", pozicija, "]\t", rec[pozicija])


input("\n\nPritisni enter za izlaz")    
