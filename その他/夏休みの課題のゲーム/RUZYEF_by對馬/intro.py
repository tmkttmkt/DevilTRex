import pygame
import pgzrun
import random
import os
import math
from Unit import *#Units
from enu import cldt,title_mode
import numpy as np 
HEIGHT=900
WIDTH=900
TITLE="RUZYEF"
GRAY=(64,64,64)
BLACK=(0,0,0)
WHITE=(255,255,255)
BACK=-1
NOT_BACK=0


class Buttan:
    def __init__(self,color,pos,scope,txt):
        self.txt=txt
        self.color=color
        self.pos=pos
        self.scope=scope
        if 0!=len(self.txt):
            self.txtsize=(((self.scope[0])/len(self.txt))*(90/60))
        else:
            self.txtsize=0
        self.rect=Rect(pos,scope)
    def draw(self):
        screen.draw.filled_rect(self.rect,self.color)
        screen.draw.text(self.txt,self.pos,fontname='genshingothic-bold.ttf',color=BLACK,fontsize=self.txtsize)
    def key_down(self,key):
        if key==self.key:
            return True
        return False
    def collidepoint(self,pos):
        if(self.pos[0]<=pos[0] and pos[0]<=self.pos[0]+self.scope[0] and self.pos[1]<=pos[1] and pos[1]<=self.pos[1]+self.scope[1]):
            return True
        return False

class Start:
    def __init__(self):
        self.title_mode=title_mode.START
        self.start=Buttan(GRAY,[WIDTH/2-120,HEIGHT/2],[240,60],"START")
        self.conit=Buttan(GRAY,[WIDTH/2-120,HEIGHT/2+70],[240,60],"CONTINUATION")
        self.exp=Buttan(GRAY,[WIDTH/2-120,HEIGHT/2+140],[240,60],"EXPLANATION")
        self.exo_txt ="\n"
        self.exo_txt+="\n"
        self.exo_txt+="\n"
    def set_start(self):
        self.title_mode=title_mode.START
    def draw(self):
        if self.title_mode==title_mode.START:
            screen.fill((128, 0, 0))
            screen.draw.text("RUZYEF",(WIDTH/2-200,HEIGHT/3-100),fontname='fugazone_regular.ttf',color=BLACK,fontsize=100)
            self.start.draw()
            self.conit.draw()
            self.exp.draw()
        elif self.title_mode==title_mode.execution:
            return
        elif self.title_mode==title_mode.CONTINUATION:
            screen.fill((255,255,0))
            screen.draw.text("chachachachara\nchachachachara",(0,0),fontname='genshingothic-bold.ttf',color=BLACK,fontsize=50)
        elif self.title_mode==title_mode.EXPLANATION:
            screen.fill(WHITE)
            screen.draw.text(self.exo_txt,(0,0),fontname='genshingothic-bold.ttf',color=BLACK,fontsize=50)
    def mouse_down(self,pos):
        if self.title_mode==title_mode.START:
            if self.start.collidepoint(pos):
                self.title_mode=title_mode.execution
            elif self.conit.collidepoint(pos):
                self.title_mode=title_mode.CONTINUATION
            elif self.exp.collidepoint(pos):
                self.title_mode=title_mode.EXPLANATION
        elif self.title_mode==title_mode.execution:
            pass
        elif self.title_mode==title_mode.CONTINUATION or self.title_mode==title_mode.EXPLANATION:
                self.title_mode=title_mode.START
class Maps:
    def __init__(self):
        self.mode=-1
        self.list=[tesmap(),test(),Map([900,900])]
        self.set_buttan()
        self.pov=[0,0]
        self.ret=Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2],[240,60],"return")
        self.set=Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2+70],[240,60],"setting")
        self.menu=Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2+140],[240,60]," menu ")
        self.return_mode=False
    def set_buttan(self):
        self.buttan_list=[Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2],[240,60]," test ")
                        ,Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2+70],[240,60]," map ")
                        ,Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2+140],[240,60],"return")]
    def update(self):
        moto_pov=[self.pov[0],self.pov[1]]
        if keyboard.s:
            if(self.pov[1]>-(self.list[self.mode].rect[3]-HEIGHT)):
                self.pov[1] -= 10
        if keyboard.w:
            if(self.pov[1]<0):
                self.pov[1] += 10
        if keyboard.d:
            if(self.pov[0]>-(self.list[self.mode].rect[2]-WIDTH)):
                self.pov[0]-= 10
        if keyboard.a:
            if(self.pov[0]<0):
                self.pov[0] += 10
        self.list[self.mode].units.set_pov([self.pov[0]-moto_pov[0],self.pov[1]-moto_pov[1]])
    def mouse_down(self,pos):
        if self.mode==-1:
            i=0
            for obj in self.buttan_list:
                if obj.collidepoint(pos):
                    self.mode=i
                i+=1
            if self.mode==2:
                self.mode=-1
                return BACK
        else:
            if self.return_mode:
                if self.ret.collidepoint(pos):
                    self.return_mode=False
                if self.set.collidepoint(pos):
                    pass
                if self.menu.collidepoint(pos):
                    self.mode=-1
            else:
                self.list[self.mode].units.mouse_down(pos)
        return NOT_BACK
    def key_down(self,key):
        if key==keys.ESCAPE:
            self.return_mode=not self.return_mode
    def draw(self):
        if self.mode==-1:
            screen.fill((172,172,172))
            for obj in self.buttan_list:
                obj.draw()
        else:
            self.list[self.mode].draw(self.pov)
            if self.return_mode:
                screen.draw.filled_rect(Rect((WIDTH/2-120-20,HEIGHT/2-20), (280,40+140+60)),WHITE)
                self.ret.draw()
                self.set.draw()
                self.menu.draw()
class Map:
    def __init__(self,wide):
        self.rect=Rect((0,0),(wide[0],wide[1]))
        self.date= np.array([[1 for i in range(self.rect[2])] for j in range(self.rect[3])])
        self.draw_date=pygame.Surface((self.rect[2],self.rect[3]), flags=0)
        #0mu 1heiya 2kawa 3tetudou 4douro 5mori 6mati
        self.color=[(0,0,0),(0,255,0),(0,128,255),(32,32,32),(128,64,0),(0,128,0),(128,128,128)]
        self.draw_date.fill(self.color[1],None, special_flags=0)
        self.units=Units()
    def setdate(self,name):
        source=pygame.image.load(os.path.join('images', name))
        source=source.convert()
        rect=self.draw_date.blit(source,[0,0], area=None, special_flags = 0)
        for y in range(rect[1]):
            for x in range(rect[0]):
                self.date[y,x]=i=0
                for set_color in self.color:
                    if set_color==self.draw_date.get_at((x, y)):
                        self.date[y,x]=i
                    i+=1
    def draw(self,pov):
        screen.blit(self.draw_date,(pov[0],pov[1]))
        self.units.draw()
    def sen(self,pos,go_pos,haba,setd):
        haba/=2
        xsen=(pos[0]-go_pos[0])
        ysen=(pos[1]-go_pos[1])
        if(ysen!=0 and xsen!=0):
            a=ysen/xsen
            b=pos[1]-a*pos[0]
            ap=-1/a
            hyp=(math.sqrt(ysen**2+xsen**2)/xsen)
            haba*=abs(hyp)
            if(pos[1]<go_pos[1]):
                bp=pos[1]-ap*pos[0]
                bgp=go_pos[1]-ap*go_pos[0]
            else:
                bgp=pos[1]-ap*pos[0]
                bp=go_pos[1]-ap*go_pos[0]
            for y in range(self.rect[3]):
                for x in range(self.rect[2]):
                    if(y >= a*x+b -haba and y <= a*x+b +haba):
                        if(y >= ap*x+bp and y <= ap*x+bgp):
                            self.date[y,x]=setd
                            self.draw_date.set_at((x,y),self.color[setd])
        elif(ysen==0 and xsen==0):
            return
        elif(ysen==0):
            if(pos[0]>go_pos[0]):
                box=pos
                pos=go_pos
                go_pos=box
            haba=int(haba)
            for x in range(pos[0],go_pos[0]):
                for y in range(pos[1]-haba,pos[1]+haba):
                    self.date[y,x]=setd
                    self.draw_date.set_at((x,y),self.color[setd])
        elif(xsen==0):
            if(pos[1]>go_pos[1]):
                box=pos
                pos=go_pos
                go_pos=box
            haba=int(haba)
            for y in range(pos[1],go_pos[1]):
                for x in range(pos[0]-haba,pos[0]+haba):
                    self.date[y,x]=setd
                    self.draw_date.set_at((x,y),self.color[setd])
    def en(self,pos,haba,setd):
        for y in range(pos[1]-haba,pos[1]+haba):
            for x in range(pos[0]-haba,pos[0]+haba):
                if((x-pos[0])**2+(y-pos[1])**2<=(haba/2)**2):
                    self.date[y,x]=setd
                    self.draw_date.set_at((x,y),self.color[setd])
    def daen(self,fpos,setd):
        x_min=self.rect[2]
        x_max=0
        y_min=self.rect[3]
        y_max=0
        for pos in fpos:
            print(pos)
            if(pos[0]<x_min):
                x_min=pos[0]
            if(pos[0]>x_max):
                x_max=pos[0]
            if(pos[1]<y_min):
                y_min=pos[1]
            if(pos[1]>y_max):
                y_max=pos[1]
        print(x_min,x_max,y_min,y_max)
        xr=(x_max-x_min)/2
        yr=(y_max-y_min)/2
        cen=[(x_max+x_min)/2,(y_max+y_min)/2]
        print(cen,xr,yr)
        for y in range(y_min,y_max):
            for x in range(x_min,x_max):
                siki=((x-cen[0])/xr)**2+((y-cen[1])/yr)**2
                if(siki<=1):
                    self.date[y,x]=setd
                    self.draw_date.set_at((x,y),self.color[setd])
    def sikaku(self,pos,go_pos,setd):
        for y in range(pos[1] if pos[1]<go_pos[1] else go_pos[1],go_pos[1] if pos[1]<go_pos[1] else pos[1]):
            for x in range(pos[0] if pos[0]<go_pos[0] else go_pos[0],go_pos[0] if pos[0]<go_pos[0] else pos[0]):
                self.date[y,x]=setd
                self.draw_date.set_at((x,y),self.color[setd])                          
    def all(self,setd):
        self.draw_date.fill(self.color[1],None, special_flags=0)
        self.date= np.array([[setd for i in range(self.rect[2])] for j in range(self.rect[3])])
class test(Map):
    def __init__(self):
        source=pygame.image.load(os.path.join('images', 'test.png'))
        wide_rect=source.get_clip()
        super().__init__([wide_rect[2],wide_rect[3]])
        self.setdate('test.png')  
class tesmap(Map):
    def __init__(self):
        super().__init__([1000,1000])
        
        self.en([0,50],10,2)
        self.sen([0,50],[100,400],10,2)
        self.en([100,400],10,2)
        self.sen([100,400],[600,500],10,2)
        self.en([600,500],10,2)
        self.sen([600,500],[900,400],5,2)
        self.sen([600,500],[700,900],5,2)
    
        self.sikaku([250,70],[390,140],6)
        self.sen([400,0],[300,100],5,4)
        self.sen([300,100],[900,100],5,4)
        self.sen([300,100],[290,400],5,4)
        self.sen([290,400],[200,800],5,4)
        self.sen([200,800],[100,900],5,4)


        self.sen([300,0],[200,900],10,3)

        self.daen([[100,100],[200,100],[150,-100],[150,200]],5)
        self.daen([[0,400],[100,800],[150,600],[-150,700]],5)
maps=Maps()
start=Start()
time=0
def draw():
    start.draw()
    if start.title_mode==title_mode.execution:
        maps.draw()
    
def update():
    global time,maps
    time+=1
    maps.update()
def on_key_down(key):
    maps.key_down(key)
def on_mouse_down(pos,button):
    if button==mouse.LEFT or button==mouse.RIGHT:
        if start.title_mode==title_mode.execution:
            if BACK==maps.mouse_down(pos):
                start.set_start()
        else:
            start.mouse_down(pos)



pgzrun.go()
