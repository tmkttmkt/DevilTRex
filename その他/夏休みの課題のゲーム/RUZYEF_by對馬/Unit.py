import re
from pgzero.actor import Actor
from pgzero.keyboard import keyboard
from pgzero.constants import mouse
from pgzero.rect import Rect
from math import fabs, sqrt,cos,sin,asin,acos
from var import *
#from pgzero.game import screen
from rapper import call_move_func
import random
from enu import goal
class Units:
    def __init__(self,map):
        self.list=[Unit((HEIGHT/2,WIDTH/2)),Unit((HEIGHT/4,WIDTH/4)),Unit((HEIGHT/4,WIDTH/2)),Unit((HEIGHT/2,WIDTH/4))]
        #self.command=command
        self.map=map
        self.pov=[0,0]
    def set_unit(self,pos):
        self.list.append(Unit(pos))
    def draw(self,screen):
        for obj in self.list:
            obj.draw(screen)
    def update(self,list):
        bullets=[]
        for obj in self.list:
            bul=obj.update()
            if bul!=None:
                bullets+=bul
        return bullets
    def mouse_down(self,pos,button):
        ret_obj=None
        if button==mouse.RIGHT:
            flg=False
            for obj in self.list:
                if obj.Right_down(pos):
                    flg=True
                    ret_obj=obj
            if not flg:
                for obj in self.list:
                    obj.move(pos,self.pov,self.map.date)
                    obj.mouse_up()
                ret_obj=CHANGE
        elif button==mouse.LEFT:
            flg=False
            for obj in self.list:
                if obj.Left_down(pos):
                    flg=True
                    ret_obj=obj
                    break
            if not flg:
                for obj in self.list:
                    obj.fire(pos)
                    obj.mouse_up()
                ret_obj=CHANGE
            else:
                for obj in self.list:
                    if obj!=ret_obj:
                        obj.mouse_up()

        return ret_obj
    def set_unit(self,pos):
        self.list.append(Unit(pos))
    def set_pov(self,pov):
        for obj in self.list:
            obj.set_pov(pov)
class Unit(Actor):
    def __init__(self,pos):
        super().__init__('sol_syo',center=pos)
        self.mouse=False
        self.goal=goal.defense
        self.point_list=[]
        self.fire_point=(-1,-1)
        self.nokori=(-1,-1)

        self.speed=2
        self.armor=0
        self.soldier=12
        self.morale=1.0
        self.guns=[Gun(12,0,1,3,100,60,900,1.5)]
        self.bullets=[]
    def set_pov(self,pov):
        self.x+=pov[0]
        self.y+=pov[1]
        for bul in self.bullets:
            bul.x+=pov[0]
            bul.y+=pov[1]
    def draw(self,screen):
        super().draw()
        if self.mouse:
            screen.draw.circle(self.center,10, (255,0,0))
        for bul in self.bullets:
            bul.draw()
    def fire(self,pos):
        if self.mouse:
            self.fire_point=pos
            self.goal=goal.fire
    def Left_down(self,pos):
        if self.collidepoint(pos):
            self.mouse=True
            return True
        return False
    def Right_down(self,pos):
        if self.collidepoint(pos):
            self.mouse=True
            return True
        return False
    def mouse_up(self):
        self.mouse=False
    def move(self,pos,pov,date):
        if self.mouse:
            self.goal=goal.move
            self.point_list=call_move_func(date,self.center,pos,pov)
    def update(self):
        for gun in self.guns:
            gun.update()
        if self.goal==goal.move:
            if 0<len(self.point_list):
                #print(self.nokori)
                if self.nokori==(-1,-1):
                    nokori=0
                else:
                    nokori=sqrt((self.nokori[0])**2+(self.nokori[1])**2)
                    self.x=int(round(self.x+self.nokori[0],0))
                    self.y=int(round(self.y+self.nokori[1],0))
                    #print("a",self.nokori,(self.x,self.y))
                    self.nokori=(-1,-1)
                while(0<len(self.point_list)):
                    li=self.point_list.pop(0)
                    sya=sqrt(li[0]**2+li[1]**2)
                    nokori+=sya
                    if nokori<self.speed:
                        self.x+=li[0]
                        self.y+=li[1]
                    elif nokori>self.speed:
                        x=(self.speed-(nokori-sya))*(li[0]/sya)
                        y=(self.speed-(nokori-sya))*(li[1]/sya)
                        self.nokori=(li[0]-x,li[1]-y)
                        #print("b",(self.speed-(nokori-sya)),self.nokori)
                        self.x+=x
                        self.y+=y
                        break
                    #print(li,(self.x,self.y))
            else:
                self.goal=goal.defense
        elif self.goal==goal.speed_move:
            pass
        elif self.goal==goal.defense:
            pass
        elif self.goal==goal.fire:
            if self.fire_point!=(-1,-1):
                bullets=[]
                for gun in self.guns:
                    if gun.can:
                        bullets.append(gun.fire(self.center,self.fire_point))
                        return bullets
                return bullets
            else:
                self.goal=goal.defense
        elif self.goal==goal.precision_fire:
            pass
class Gun:
    def __init__(self,cal,explo,penet,wei,ran,inter,speed,hei):
        self.caliber=cal
        self.explosive=explo
        self.penetration=penet
        self.weight=wei
        self.range=ran
        self.interval=inter
        self.bullet_speed=speed
        self.height=hei
        self.time=0
        self.can=False
    def update(self):
        if not self.can:
            self.time+=1
            if self.interval<self.time:
                self.time=0
                self.can=True
    def fire(self,loc,pos):
        sya=sqrt((loc[0]-pos[0])**2+(loc[1]-pos[1])**2)
        seeta=acos((pos[0]-loc[0])/sya)
        print(seeta)
        speed_x=self.bullet_speed*cos(seeta)
        speed_y=self.bullet_speed*sin(seeta)*-(loc[1]-pos[1])/fabs(loc[1]-pos[1])
        """
        speed_x=self.bullet_speed*((pos[0]-loc[0])/sya)
        speed_y=self.bullet_speed*((pos[1]-loc[1])/sya)
        """
        speed_z=1
        speed=[speed_x,speed_y,speed_z]
        self.time=0
        self.can=False
        return Bullet(loc,self.height,speed)

class Bullet(Actor):
    def __init__(self,pos,hei,speed) -> None:
        super().__init__('ho',center=pos)
        self.z=hei
        self.speed=speed
        self.speed[0]*=KERO_SCL*TIME_SCL
        self.speed[1]*=KERO_SCL*TIME_SCL
        self.speed[2]*=TIME_SCL
    def update(self):
        self.x+=self.speed[0]
        self.y+=self.speed[1]
        self.speed[2]-=G
        self.z+=self.speed[2]
        self.angle+=30
class Bullets:
    def __init__(self,map):
        self.map=map
        self.list=[]
    def draw(self):
        for bul in self.list:
            bul.draw()
    def update(self):
        for bul in self.list:
            bul.update()
            pos=bul.center
            pos=(int(round(pos[0],0)),int(round(pos[1],0)))
            sta=self.map.date[pos[1],pos[0]]
            print(sta,pos)
            #0mu 1heiya 2kawa 3tetudou 4douro 5mori 6mati
            if sta==2:
                if bul.z<-1:
                    self.list.remove(bul)
                    continue
            else:
                if bul.z<0:
                    self.list.remove(bul)
                    continue
            if sta==5:
                if 1==random.randint(10):
                    self.list.remove(bul)
                    continue
            elif sta==6:
                if 1==random.randint(4):
                    self.list.remove(bul)
                    continue
    def add_Bullets(self,bUl_list):
        if list==type(bUl_list):
            self.list+=bUl_list
    
class Unit_state:
    def __init__(self,unit:Unit):
        self.unit=unit
    def draw(self,screen):
        screen.draw.filled_rect(Rect((200,HEIGHT-200), (WIDTH-200*2,200)),WHITE)







