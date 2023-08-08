import re
from pgzero.actor import Actor
from pgzero.keyboard import keyboard
from pgzero.constants import mouse
from pgzero.rect import Rect
from math import fabs, sqrt,cos,sin,asin,acos
from var import *
#from pgzero.game import screen
from rapper import call_move_func
from enu import goal
class Units:
    def __init__(self,map):
        self.list=[Unit((HEIGHT/2,WIDTH/2)),Unit((HEIGHT/4,WIDTH/4)),Unit((HEIGHT/4,WIDTH/2)),Unit((HEIGHT/2,WIDTH/4))]
        self.map=map
        self.pov=[0,0]
    def set_unit(self,pos):
        self.list.append(Unit(pos))
    def draw(self,screen):
        for obj in self.list:
            obj.draw(screen)
    def update(self):
        for obj in self.list:
            obj.update()
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
                ret_obj=CHANGE
        return ret_obj
    def set_pov(self,pov):
        for obj in self.list:
            obj.set_pov(pov)
class Unit(Actor):
    def __init__(self,pos):
        super().__init__('sol_syo',center=pos)
        self.mouse=False
        self.goal=goal.defense
        self.point_list=[]
        self.fre_point=(-1,-1)
        self.nokori=(-1,-1)

        self.speed=10
        self.armor=0
        self.soldier=12
        self.morale=1.0
        self.guns=[]
        self.bullets=[]
    def set_pov(self,pov):
        self.x-=pov[0]
        self.y-=pov[1]
        for bullet in self.bullets:
            pass
    def draw(self,screen):
        super().draw()
        if self.mouse:
            screen.draw.circle(self.center,10, (255,0,0))
    def fire(self):
        pass
    def Left_down(self,pos):
        self.mouse=self.collidepoint(pos)
        return self.mouse
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
        if self.goal==goal.move:
            if 0<len(self.point_list):
                #print(self.nokori)
                if self.nokori==(-1,-1):
                    nokori=0
                else:
                    nokori=sqrt((self.nokori[0])**2+(self.nokori[1])**2)
                    self.x=int(self.x+self.nokori[0])
                    self.y=int(self.y+self.nokori[1])
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
                for gun in self.guns:
                    gun.fire(self.center,self.fire_point)
            else:
                self.goal=goal.defense
        elif self.goal==goal.precision_fire:
            pass
        for gun in self.guns:
            gun.update()
        for bullet in self.bullets:
            bullet.update()
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
                self.can=True
    def fire(self,loc,pos):
        if self.can:
            sya=sqrt((loc[0]-pos[0])**2+(loc[1]-pos[1])**2)
            seeta=acos((pos[0]-loc[0])/sya)
            speed_x=self.bullet_speed*cos(seeta)
            speed_y=self.bullet_speed*sin(seeta)
            speed_z=1
            speed=[speed_x,speed_y,speed_z]
            return Bullet(loc,self.height,speed)
        else :
            return

class Bullet(Actor):
    def __init__(self,pos,hei,speed) -> None:
        self.hei=hei
        self.speed=speed
        super().__init__('ho',center=pos)
    def update(self):
        self.x+=self.speed[0]
        self.y+=self.speed[1]
        self.angle+=30

class Unit_state:
    def __init__(self,unit:Unit):
        self.unit=unit
    def draw(self,screen):
        screen.draw.filled_rect(Rect((200,HEIGHT-200), (WIDTH-200*2,200)),WHITE)







