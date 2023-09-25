import pgzrun
from enum import Enum
import math
class Onpu:
    def __init__(self,kai,num,lon,flg):
        self.kai=kai
        self.num=num
        self.lon=lon
        self.flg=flg
        self.harf=0#1.5
    def draw(self):
        point=HEIGHT-(self.num+(self.kai-2)*7)*BOU/2
        if self.flg!=3:
            if self.lon==16:
                screen.draw.filled_circle([50,point],25,(0,0,0))
                screen.draw.filled_circle([50,point],15,(255,255,255))
            elif self.lon==8:
                screen.draw.filled_circle([50,point],25,(0,0,0))
                screen.draw.filled_rect(Rect((50+12.5,point-70),(12.5,70)),(0,0,0))
                screen.draw.filled_circle([50,point],15,(255,255,255))
            elif self.lon==4:
                screen.draw.filled_circle([50,point],25,(0,0,0))
                screen.draw.filled_rect(Rect((50+12.5,point-70),(12.5,70)),(0,0,0))
            elif self.lon==2:
                screen.draw.filled_circle([50,point],25,(0,0,0))
                screen.draw.filled_rect(Rect((50+12.5,point-70),(12.5,70)),(0,0,0))
                screen.draw.filled_rect(Rect((50+12.5,point-70),(25+12.5,12.5)),(0,0,0))
            elif self.lon==1:
                screen.draw.filled_circle([50,point],25,(0,0,0))
                screen.draw.filled_rect(Rect((50+12.5,point-70),(12.5,70)),(0,0,0))
                screen.draw.filled_rect(Rect((50+12.5,point-70),(25+12.5,12.5)),(0,0,0))
                screen.draw.filled_rect(Rect((50+12.5,point-70+12.5*1.5),(25+12.5,12.5)),(0,0,0))
            for x in range(self.harf):
                screen.draw.filled_circle([50+35+x*20,point],7,(0,0,0))
            if self.flg==1:
                screen.draw.text("#",(50+50,point-70),color=(0, 0, 0),fontsize=50)
            elif self.flg==2:
                screen.draw.text("D",(50+50,point-70),color=(0, 0, 0),fontsize=50)
        else:
            if self.lon==16:
                screen.draw.filled_rect(Rect((50-30,point-15),(60,30)),(0,0,0))
                screen.draw.filled_rect(Rect((50-40,point-15),(80,4)),(0,0,0))
            elif self.lon==8:
                screen.draw.filled_rect(Rect((50-30,point-15),(60,30)),(0,0,0))
                screen.draw.filled_rect(Rect((50-40,point+15-4),(80,4)),(0,0,0))
            elif self.lon==4:
                screen.draw.filled_rect(Rect((50+10,point-20-12.5),(12.5,100)),(0,0,0))
                screen.draw.filled_rect(Rect((50-15,point+50),(30,15)),(0,0,0))
            elif self.lon==2:
                screen.draw.filled_circle([50,point-10],10,(0,0,0))
                screen.draw.filled_rect(Rect((50+10,point-20-12.5),(12.5,100)),(0,0,0))
            elif self.lon==1:
                screen.draw.filled_circle([50,point-10],10,(0,0,0))
                screen.draw.filled_circle([50,point-10+30],10,(0,0,0))
                screen.draw.filled_rect(Rect((50+10,point-20-12.5),(12.5,100)),(0,0,0))
    def show(self):
        global code
        st="music("+str((self.kai-2)*7+self.num)+","+str(int(self.lon*1.5**self.harf))+");"
        #st="ot("+str(self.kai-1)+","+str(self.num)+","+str(int(self.lon*1.5**self.harf))+","+str(self.flg)+");"
        print(st)
        code+="\t"+st+"\n"
    def up(self):
        self.num+=1
        if self.num==7 and self.kai!=4:
            self.num=0
            self.kai+=1
        elif self.num==7:
            self.num-=1
    def down(self):
        self.num-=1
        if self.num==-1 and self.kai!=2:
            self.num=6
            self.kai-=1
        elif self.num==-1:
            self.num+=1
    def go_long(self):
        if self.lon!=16:
            self.lon*=2
            self.harf=0
    def harf_long(self):
        if self.harf<math.log(self.lon,2):
            self.harf+=1
    def go_short(self):
        if self.lon!=1:
            self.lon=int(self.lon/2)
            self.harf=0
    def harf_short(self):
        if self.harf!=0:
            self.harf-=1
    def flg_change(self,num):
        #if num==3:
            #self.harf=0
        self.flg=num


class Play:
    def __init__(self):
        self.harf_flg=False
        self.flg_num=0
        self.Point=0
        self.onpu=[Onpu(3,0,4,0)]
    def draw(self):
        self.onpu[self.Point].draw()
    def update(self):
        pass
    def on_key_down(self,key):
        if key==keys.UP:
            self.onpu[self.Point].up()
        elif key==keys.DOWN:
            self.onpu[self.Point].down()
        elif key==keys.LEFT:
            if self.harf_flg:
                self.onpu[self.Point].harf_short()
            else:
                self.onpu[self.Point].go_short()
        elif key==keys.RIGHT:
            if self.harf_flg:
                self.onpu[self.Point].harf_long()
            else:
                self.onpu[self.Point].go_long()
        elif key==keys.LSHIFT:
            self.harf_flg=True
        elif key==keys.RETURN:
            self.onpu[self.Point].show()
        elif key==keys.K or key==keys.K_4:
            self.onpu[self.Point].flg_change(3)
        elif key==keys.D or key==keys.K_1:
            self.onpu[self.Point].flg_change(2)
        elif key==keys.N or key==keys.K_0:
            self.onpu[self.Point].flg_change(0)
        elif key==keys.S or key==keys.K_3:
            self.onpu[self.Point].flg_change(1)
        if self.harf_flg:
            if key==keys.SPACE:
                global code
                print("\n")
                print(code)
                code=""
    def on_key_up(self,key):
        if key==keys.LSHIFT:
            self.harf_flg=False
TITLE="ONPU"
HEIGHT=600
WIDTH=1200
BOU=2*HEIGHT/(7*3)
play=Play()
code=""

def update():
    pass#play.update()
def draw():
    screen.fill((255,255,255))
    for y in range(0,20):
        screen.draw.filled_rect(Rect((0,BOU*y+BOU/2),(WIDTH,2)),(200,200,200))
    for y in range(5,5+5):
        screen.draw.filled_rect(Rect((0,BOU*y+BOU/2),(WIDTH,2)),(0,0,0))
    play.draw()
def on_key_down(key,mod,unicode):
    #print(key)
    play.on_key_down(key)
def on_key_up(key):
    if key==keys.SPACE:
        print("\n")
        print(code)
    else:
        play.on_key_up(key)




pgzrun.go()
