import pgzrun
HEIGHT=900
WIDTH=900
ti=0
tank=Actor('tank_syo',center=(0,0))
def draw():
    screen.fill((255,0,0))
    tank.draw()
def update():
    global ti
    ti+=1
    print(tank.x,tank.y)
def on_mouse_down(pos):
    tank.x+=0.1
pgzrun.go()