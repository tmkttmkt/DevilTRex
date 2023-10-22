import pgzrun
import math
import random
import pygame
import pgzero
from pgzhelper import *


TITLE = "インスタンス　ラーメン"

WIDTH = 700
HEIGHT = 700
GRAVITY = 0.5
alien = Actor('baka.png')
class Guzai():
    def __init__(self,speed,scale,gazou):
        self.guzai = Actor(gazou)
        self.speed = speed
        self.scale = scale
        self.gazou = gazou
        self.x = 0
        self.y = 100
    def draw(self):
        self.guzai.scale = self.scale 
        self.guzai.draw()
    def update(self):
        self.guzai.x += self.speed
        #if self.guzai.colliderect(alien):
      #      self.speed = 0
        
class Player():
    def __init__(self):
        self.player_x = 100
        self.player_y = 100
    def on_key_down(self,key):
        if key == keys.SPACE:
            self.player_x += 2
        elif key == keys.LEFT:
            self.player_x -= 2
    def draw(self):
        alien.angle = -100
        alien.draw()
    def update(self):
        alien.x = self.player_x
        if alien.x  - 100 >= 700:
            alien.x = 0

players = Player()
retasu = Guzai(10,0.25,'retasu.png')
tomato = Guzai(5,0.25,'tomato.png')
def draw():
    screen.clear()
    players.draw()
    retasu.draw()
    tomato.draw()
def update():
    players.update()
    retasu.update()
    tomato.update()
def on_key_down(key):
    players.on_key_down(key)
pgzrun.go()
