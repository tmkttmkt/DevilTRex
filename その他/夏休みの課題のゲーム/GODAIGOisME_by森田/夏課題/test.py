import pgzrun
import math
import random
import pygame
import pgzero
from pgzhelper import *


ball=Actor('baka',(100,100))

def draw():
    screen.clear()
    ball.scale = 2
    ball.draw()
pgzrun.go()
