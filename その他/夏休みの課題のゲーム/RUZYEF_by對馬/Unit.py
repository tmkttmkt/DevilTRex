from pgzero.actor import Actor
from pgzero.keyboard import keyboard
from enu import goal
HEIGHT=900
WIDTH=900
class Units:
    def __init__(self):
        self.list=[Unit(HEIGHT/2,WIDTH/2)]
    def draw(self):
        for obj in self.list:
            obj.draw()
    def mouse_down(self,pos):
        for obj in self.list:
            obj.mouse_down(pos)
    def set_pov(self,pov):
        for obj in self.list:
            obj.x+=pov[0]
            obj.y+=pov[1]
class Unit(Actor):
    def __init__(self,x,y):
        super().__init__('tank_syo',center=(x,y))
        self.point=[x,y]
        self.goal=goal.defense
    def move(self,pos):
        pass





