import math
import pygame
from pygame import Vector2
import pgzrun
from pgzhelper import *

WIDTH = 1800
HEIGHT = 600
player_x = 0
player_y = 0
max_angle = 200
angle = 0
angle2 = 0.8
alien = Actor('player.jpg')

player_speed_x = 10
player_speed_y = 0
gravity = 0.5

angle = max_angle

def update():
    global player_x,player_y,player_speed_x,player_speed_y,gravity,angle,angle2
    print(player_speed_y)
    if(player_speed_x >= 0):
        player_speed_x -= 0.05
    player_x += player_speed_x
    player_y += player_speed_y
    player_speed_y += gravity
    if angle > 0:
        angle -= angle2
    else:
        angle = 0
    if player_y >= HEIGHT - 30:
        if player_speed_y >= 4 or player_speed_y <= -4:
            gravity -= 0.05
            player_speed_y = -player_speed_y * 0.6
            player_y = HEIGHT - 30
        else:
            player_speed_y = 0
            player_speed_x = 0
            gravity = 0

def draw():
    alien.scale = 0.25
    alien.angle += angle
    alien.x = player_x
    alien.y = player_y
    screen.clear()
    screen.fill((255,255,255))
    alien.draw()

pgzrun.go()
