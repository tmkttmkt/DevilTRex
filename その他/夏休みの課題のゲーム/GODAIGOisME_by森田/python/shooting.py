import pgzrun
import random

WIDTH=700
HEIGHT=500
TITLE='CAT SHOOTING'

enemys = []
tamas = []

ship = Actor('ship.png',topleft =(0,0))

gamecount = 0
score = 0

damagetime = 0

damagedship = Actor('damagedship.png',topleft =(0,0))

playtime = 5000

def draw():
    global score,damagetime

    screen.fill((128,128,255))

    if damagetime > 0:
        damagedship.y = ship.y
        damagedship.draw()
    else:
        ship.draw()

    for i,obj in enumerate(enemys):
        obj.draw()
        #screen.draw.text(str(i),(obj.x,obj.y))

    for obj in tamas:
        obj.draw()
        screen.draw.text("SCORE:"+str(score),(0,0),owidth=1.5,ocolor="BLACK",color="YELLOW",fontsize=50)

    if playtime == 0:
        screen.draw.text("GAME OVERA"(120,200),owidth=1.5,ocolor="BLACK",color="RED",fontsize=100)
        
def update():
    global gamecount,score,damagetime,playtime

    if playtime > 0:
        playtime -= 10
    
        if gamecount % 10 == 0:
            enemys.append(Actor('ironball.png',(WIDTH,random.randrange(HEIGHT))))

        if keyboard.down:
            if ship.y < HEIGHT - 35:
                ship.y += 15
        if keyboard.up:
            if ship.y > 35:
                ship.y -= 15

        for obj in enemys:
            obj.x -= 30

        for obj in tamas:
            obj.x += 30
        
        gamecount +=1
        #print(gamecount)  

        for enemy in enemys:
            for tama in tamas:
                if enemy.colliderect(tama):
                    enemys.remove(enemy)
                    tamas.remove(tama)
                    score += 1

        for obj in enemys:
            if ship.colliderect(obj):
                damagetime = 120

            if damagetime > 0:
                damagetime -= 1

def on_key_down(key):
    global damagetime
    if key == keys.SPACE:
        tamas.append(Actor('smallball.png',(70,ship.y)))
pgzrun.go()
