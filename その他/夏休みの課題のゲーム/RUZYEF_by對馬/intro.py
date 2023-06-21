import pygame
import pgzrun
import random
import os
import math
HEIGHT=900
WIDTH=900
TITLE="RUZYEF"

class Buttan:
    def __init__(self,color,pos,scope,txt,key):
        self.txt=txt
        self.key=keys.Q
        self.color=color
        self.pos=pos
        self.scope=scope
        if 0!=len(self.txt):
            self.txtsize=(((self.scope[0]-60)/len(self.txt))*(90/60))
        else:
            self.txtsize=0
        self.rect=Rect(pos,scope)
    def draw(self):
        screen.draw.filled_rect(self.rect,self.color)
        screen.draw.text(self.txt,self.pos,fontname='genshingothic-bold.ttf',color=(0,0,0),fontsize=self.txtsize)
        screen.draw.text("("+self.key+")",(self.pos[0]+self.scope[0]-60,self.pos[1]),color=(0,0,0),fontsize=60)
    def key_down(self,key):
        if key==self.key:
            return 1
        return 0
    def collidepoint(self,pos,key):
        if key==mouse.LEFT or key==mouse.RIGHT:
            if(self.pos[0]<=pos[0] and pos[0]<=self.pos[0]+self.scope[0] and self.pos[1]<=pos[1] and pos[1]<=self.pos[1]+self.scope[1]):
                return 1
        return 0