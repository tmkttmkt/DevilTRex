import math
import pygame
from pygame import Vector2
import pgzrun

WIDTH = 1600
HEIGHT = 600
GRAVITY = 0.5

player_x = 100
player_y = 0

player_speed_x = 10
player_speed_y = 0
gravity = 0.5

ball=Actor('baka')

def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity
    print(player_speed_x)
    if(player_speed_x >= 0):
        player_speed_x -= 0.04
    player_x += player_speed_x
    player_y += player_speed_y

    player_speed_y += gravity

    if player_y >= HEIGHT - 20:
        if player_speed_y >= 4 or player_y <= -4:
            gravity -= 0.01
            player_speed_y = -player_speed_y * 0.6
            player_y = HEIGHT - 20
        else:
            player_speed_y = 0
            player_speed_x = 0
            gravity = 0
def draw():
    global player_x,player_y
    screen.clear()
    ball.x = player_x
    ball.y = player_y
    ball.draw()
pgzrun.go()
