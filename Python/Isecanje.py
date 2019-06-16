rec=input("Unesi rec: ")

start=None

while start!="":
    start=input("\nStart: ")

    if start:
        start=int(start)
        finish=int(input("Finish: "))

        print("rec[", start, ":", finish, "] je", end=" ")
        print(rec[start:finish])

input("\n\nPritisni enter za izlaz")
