from pgzero.actor import Actor
from pgzero.keyboard import keyboard
from pgzero.constants import mouse
#from pgzero.game import screen
from rapper import call_move_func
from enu import goal
HEIGHT=900
WIDTH=900
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
        if button==mouse.RIGHT:
            flg=False
            for obj in self.list:
                if obj.Right_down(pos):
                    flg=True
            if not flg:
                for obj in self.list:
                    if obj.mouse:
                        obj.move(pos,self.pov,self.map.date)
                    obj.mouse_up()
        if button==mouse.LEFT:
            flg=False
            for obj in self.list:
                if obj.Left_down(pos):
                    flg=True
    def set_pov(self,pov):
        for obj in self.list:
            obj.x+=pov[0]-self.pov[0]
            obj.y+=pov[1]-self.pov[0]
class Unit(Actor):
    def __init__(self,pos):
        super().__init__('tank_syo',center=pos)
        self.point=pos
        self.mouse=False
        self.goal=goal.defense
        self.point_list=[]
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
        self.goal=goal.move
        self.point_list=call_move_func(date,pos,self.center,pov)
    def update(self):
        if self.mode==goal.move:
            pass





