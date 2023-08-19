from turtle import goto
import pgzrun
from math import sqrt,acos
HEIGHT=900
WIDTH=900
ti=0
go=(0,0)
LOT=(450,450)
tank=Actor('tank_syo',center=(0,0))
def draw():
    screen.draw.line(LOT,go,(255,255,255))
    tank.draw()
def update():
    global ti
    ti+=1
def on_mouse_down(pos):
    global go
    go=pos
    sya=sqrt((LOT[0]-pos[0])**2+(LOT[1]-pos[1])**2)
    seeta=acos((pos[0]-LOT[0])/sya)
    if pos[1]-LOT[1]<0:
        speed_y*=-1
    print(seeta)
pgzrun.go()