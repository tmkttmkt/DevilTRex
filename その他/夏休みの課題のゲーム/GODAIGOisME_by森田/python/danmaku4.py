import pgzrun
import winsound
import random
from pgzhelper import *
TITLE = "DANMAKU"
WIDTH = 770
HEIGHT = 770
boxlist=[]
mapdate = [[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1],
           [1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1]]

class color256(Actor):
    def sp_draw(self):
        screen.draw.filled_rect(Rect((35*self.x,35*self.y),(70,70)),color=(0,0,0))
for y,obj in enumerate(mapdate):
    for x,box in enumerate(obj):
        if box == 1:
            boxlist.append(color256('box',topleft=(35*(x-0.5),35*(y-0.5))))

loation      = [0,1]
floor        = Actor('floor',topleft    = (0,0))
box          = Actor('box',topleft      = (0,0))
player       = Actor('player',topleft   = (140,140))
lifedraw     = Actor('player',topleft   = (140,140))
boss         = Actor('boss',topleft     = (365,365))
time         = 1200
playtime     = 60*20
長谷部改         = []
damagetime   = 0
life         = 3
stage        = 1

class missile (Actor):
    def __init__(self,boll,num):
        self.xs=math.cos(math.radians(boll))*num
        self.ys=math.sin(math.radians(boll))*num
        super().__init__('長谷部改',topleft = (365,365))
    def update(self):
        self.x += self.xs
        self.y += self.ys
                         
def draw():
    if stage >= 1:
        screen.clear()
        for y in range(22):
            for x in range(22):
                floor.topleft = (35*x,35*y)
                floor.scale = 0.5
                floor.draw()
            else:
                screen.draw.filled_rect(Rect((35*x,35*y),(70,70)),color=(0,0,0))

        for obj in boxlist:
            obj.scale = 0.5
            obj.draw()
            
    player.scale = 0.5
    boss.scale   = 1
    boss.draw()
    for obj in 長谷部改:
        obj.draw()
  
    player.draw()
    screen.draw.text("BOSS",(360,336),fontsize=40,color="RED")
    screen.draw.text("LIFE",(0,0),fontsize=40,color="YELLOW")
    if playtime == 0:
        screen.draw.text("GAME CLEAR",(140,200),owidth=1.5,ocolor="BLACK",color=(random.randint(0,255),random.randint(0,255),random.randint(0,255)),fontsize=100)
    if life == 0:
        screen.draw.text("GAME OVER",(160,200),owidth=1.5,ocolor="BLACK",color="RED",fontsize=100)

    for i in range(life):
        lifedraw.topleft = (65+i*35,0)
        lifedraw.scale = 0.5
        lifedraw.draw()
        
def update():
    global damagetime,time,life,playtime
    if playtime > 0 and life > 0:
        for obj in 長谷部改:
            if player.colliderect(obj):
                if damagetime == 0:
                    life -= 1
                    damagetime = 60

              
        if damagetime > 0:
            if time % 10 == 0:
                player.image = 'mu'
            elif time % 10 == 5:
                player.image = 'player'
            damagetime -= 1
        else:
            player.image = 'player'

        if keyboard.up:
            if player.y > 50 + 8:
                player.y -= 20
        if keyboard.down:
            if player.y < HEIGHT - 58:
                player.y += 20
        if keyboard.left:
            if player.x > 50 + 8:
                player.x -= 20
        if keyboard.right:
            if player.x < WIDTH - 58:
                player.x += 20
        for obj in 長谷部改:
            obj.update()
            if obj.y < 0 or obj.x < 0 or obj.x > WIDTH or obj.y > HEIGHT:
                長谷部改.remove(obj)
                del obj
        
        if playtime > 600:
            if time % 2 == 0:
                長谷部改.append(missile(random.randint(0,360),8))
        else:
            if time % 30 == 0:
                playtime == 600
                i=random.randint(0,360)
                for x in range(36):  
                    長谷部改.append(missile((i+x*359),6))
        time += 1
        playtime -= 1
def on_key_down(key):
    global life,playtime,長谷部改
    if key == keys.SPACE:
        if life == 0 or playtime == 0:
            life = 3
            playtime = 60*20
            player.x = 140
            player.y = 140
            長谷部改     = []
pgzrun.go()
