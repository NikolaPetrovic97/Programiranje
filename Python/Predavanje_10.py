import pickle

lista=["Arandjelovac", "Beograd", "Velika Plana", "Mladenovac"]

file=open("a.txt", "wb")

pickle.dump(lista, file)

file.close()


file=open("a.txt", "rb")

p=pickle.load(file)

file.close()

print(p)



import shelve

gradovi=["Arandjelovac", "Beograd", "Velika Plana", "Mladenovac"]

reke=["Dunav", "Tisa", "Sava", "Morava"]

planine=["Bukulja", "Stara Planina", "Kopaonik", "Zlatibor"]

file=shelve.open("b.dat")

file["Gradovi"]=gradovi

file["Reke"]=reke

file["Planine"]=planine

file.sync()

file.close()


file=shelve.open("b.dat")

g=file["Gradovi"]

r=file["Reke"]

p=file["Planine"]

file.close()

print(g, r, p)
