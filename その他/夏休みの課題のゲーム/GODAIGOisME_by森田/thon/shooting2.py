import pgzrun
import random
import math

WIDTH=600
HEIGHT=800
TITLE='SHOOTING'

playership2_blue = Actor('playership2_blue.png',topleft=(WIDTH/2,HEIGHT-75))
playership2_damage3 = Actor('playership2_damage3',topleft =(WIDTH/2,HEIGHT-75))

enemys      = []
tamas       = []
missile     = []
missiles    = []
gamecount   = 0
score       = 0
damagedtime = 0
delaytime   = 0
playtime    = 1800

class chart(Actor):
    def __init__(self,name,angle):
        super().__init__(name)
        self.x = playership2_blue.x
        self.y = playership2_blue.y
        self.angle = angle
    def update(self):
        self.x += math.sin(math.radians(self.angle))*7
        self.y += math.cos(math.radians(self.angle))*7
def draw():
    global score,damagedtime

    screen.fill((0,0,0))

    if damagedtime > 0:
        playership2_damage3.x = playership2_blue.x
        playership2_blue.draw()
        playership2_damage3.draw()
    else:
        playership2_blue.draw()
        
    for i,missile in enumerate(missiles):
        missile.draw()
        screen.draw.text(str(i),(missile.x,missile.y),color="BLACK")

    for i,obj in enumerate(enemys):
        obj.draw()
        #screen.draw.text(str(i),(obj.x,obj.y))

    for obj in tamas:
        obj.draw()
    screen.draw.text("SCORE:"+str(score),(0,0),owidth=1.5,ocolor="BLACK",color="YELLOW",fontsize=50)

    if playtime == 0:
        screen.draw.text("GAME OVER",(80,200),owidth=1.5,ocolor="BLACK",color="RED",fontsize=100)
    if score == 100:
        screen.draw.text("GAME CLEAR",(60,200),owidth=1.5,ocolor="RED",color="YELLOW",fontsize=100)
        
def update():
    global gamecount,score,damagedtime,playtime,delaytime

    if playtime > 0 and score <= 100:
        playtime -= 1

        if gamecount % 20 == 0:
            enemys.append(Actor('enemyblack3.png',(random.randrange(WIDTH),0)))

        if keyboard.RIGHT:
            if playership2_blue.x < WIDTH - 35:
                playership2_blue.x += 15
        if keyboard.LEFT:
            if playership2_blue.x > 35:
                playership2_blue.x -= 15
        for missile in missiles:
            missile.update()

        for obj in enemys:
            obj.y += 8
            if obj.y > HEIGHT:
                enemys.remove(obj)
                del obj
            
 
        for obj in tamas:
            obj.update()
            if obj.y < 0 or obj.x < 0 or obj.x > WIDTH or obj.y > HEIGHT:
                tamas.remove(obj)
                del obj
        
        gamecount +=1

        for enemy in enemys:
            for tama in tamas:
                if enemy.colliderect(tama):
                    try:
                        enemys.remove(enemy)
                        score += 1
                    except:
                        print("error")
                    tamas.remove(tama)

        for obj in enemys:
            if playership2_blue.colliderect(obj):
                    damagedtime = 60

        if damagedtime > 0: 
                damagedtime -= 1
        if delaytime > 0:
            delaytime -= 1

def on_key_down(key):
    global damagedtime,delaytime
    if key == keys.B:
        if damagedtime == 0:
            if delaytime   == 0:
                delaytime = 480
                for i in range(100,265,5):
                        missile = chart("smallball",i)
                        tamas.append(missile)
    if key == keys.SPACE:
        if damagedtime == 0:
            missile = chart("smallball",180)
            tamas.append(missile)

pgzrun.go()
