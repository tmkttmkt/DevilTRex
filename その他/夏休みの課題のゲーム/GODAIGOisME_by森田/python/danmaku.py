import pgzrun
import winsound
import math
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
            boxlist.append(color256('renga',topleft=(35*(x-0.5),35*(y-0.5))))

loation      = [0,1]
floor        = Actor('tairu',topleft    = (0,0))
box          = Actor('renga',topleft      = (0,0))
player       = Actor('baka',topleft   = (140,140))
lifedraw     = Actor('baka',topleft   = (140,140))
boss         = Actor('對馬',topleft     = (365,365))
time         = 1200
playtime     = 60*20
tama         = []
damagetime   = 0
life         = 17
stage        = 1
player_x = 0
player_y = 0
tama_time = 0

class missile (Actor):
    def __init__(self,boll,num):
        self.random_x = random.randint(0,360)
        self.random_y = random.randint(0,360)
        self.xs = 0
        self.ys = 0
        self.x3 = 0
        self.y3 = 0
        self.timer = 0
        self.xs = player_x
        self.ys = player_y
        self.x3 = math.cos(math.radians(boll)) * num
        self.y3 = math.sin(math.radians(boll)) * num
        super().__init__('tamatama',topleft = (365,365))
    def update(self):
        self.timer += 1
        if self.timer % 20 == 0:
            self.x = self.xs
            self.y = self.ys
        else:
            self.x += self.x3
            self.y += self.y3
class missile2(Actor):
    def __init__(self,boll,num):
        self.x3 = math.cos(math.radians(boll)) * num
        self.y3 = math.sin(math.radians(boll)) * num
        super().__init__('tamatama',topleft = (365,365))
    def update(self):
        self.x += self.x3
        self.y += self.y3
class missile3(Actor):
    def __init__(self,boll,num):
        self.x3 =  player.x
        self.y3 =  player.y
        super().__init__('tamatama',topleft = (365,365))
    def update(self):
        self.x += self.x3
        self.y += self.y3 
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
            
    player.scale = 0.25
    boss.scale   = 1
    boss.draw()
    for obj in tama:
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
    global damagetime,time,life,playtime,player_x,player_y,tama_time
    player_x = player.x
    player_y = player.y
    if playtime > 0 and life > 0:
        for obj in tama:
            if player.colliderect(obj):
                if damagetime == 0:
                    life -= 1
                    damagetime = 60

              
        if damagetime > 0:
            if time % 10 == 0:
                player.image = 'mu'
            elif time % 10 == 5:
                player.scale = 1.25
                player.image = 'baka'
            damagetime -= 1
        else:
            player.scale = 1.25
            player.image = 'baka'

        if keyboard.up:
            if player.y > 50 + 8:
                player.y -= 10
        if keyboard.down:
            if player.y < HEIGHT - 58:
                player.y += 10
        if keyboard.left:
            if player.x > 50 + 8:
                player.x -= 10
        if keyboard.right:
            if player.x < WIDTH - 58:
                player.x += 10
        for obj in tama:
            obj.update()
            if playtime < 500:
                if obj.y < 0 or obj.x < 0 or obj.x > WIDTH or obj.y > HEIGHT or tama_time % 60 == 0:
                    tama.remove(obj)
                    del obj
        
        if playtime < 500:
            if time % 30 == 0:
                i=random.randint(0,360)
                for x in range(14):
                    tama.append(missile2((i+x*30),40))
                for x in range(14):
                    tama.append(missile((30*30),6))
                if time % 120 == 0:
                    for x in range(18):
                        i=random.randint(0,360)
                        tama.append(missile((i*30),6)) 
        else:
            if time % 120 == 0:
                for x in range(36):
                    i=random.randint(0,360)
                    tama.append(missile((i*30),6))   
            
        time += 1
        tama_time += 1
        playtime -= 1
def on_key_down(key):
    global life,playtime,tama
    if key == keys.SPACE:
        if life == 0 or playtime == 0:
            life = 17
            playtime = 60*20
            player.x = 140
            player.y = 140
            tama     = []
pgzrun.go()
