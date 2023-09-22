import random
import tkinter

pon = ["guu.png","choki.png","paa.png"]
r = random.randint(0,2)
root.title("じゃんけんゲーム")
def update():
    global r
    r = random.randint(0,2)
    root.after(50,update)
root = tkinter.Tk()
cvs = tkinter.Canvas(width=550,height=200,bg="white")
ken = tkinter.PhotoImage(file = pon[r] )
cvs.create_image(100,100,image=ken)
cvs.pack()
root.mainloop()

