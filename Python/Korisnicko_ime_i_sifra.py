username=""
while not username:
    username=input("Username: ")

password=""
while not password:
    password=input("Password: ")

if username=="Nikola Petrovic" and password=="3479":
    print("Zdravo, Nikola")
elif username=="Mateja Petrovic" and password=="matko":
    print("Zdravo, Mateja")
elif username=="Radan" or password=="retard":
    print("Zdravo, Radane")
else:
    print("Login failed")


input("\n\nPritisni enter za izlaz")    
