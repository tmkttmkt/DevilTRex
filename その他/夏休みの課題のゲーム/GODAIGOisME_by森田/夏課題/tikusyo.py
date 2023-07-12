import math
import pygame
from pygame import Vector2
import pgzrun

WIDTH = 1600
HEIGHT = 600
GRAVITY = 0.5

player_x = 50
player_y = 0

player_speed_x = 5
player_speed_y = 0
player_angle = 1
angles = 1
gravity = 0.5
owari = False
hajime = False

ball=Actor('baka')

def on_key_down(key):
    global hajime
    hajime = True
        
def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles,owari,hajime
    if hajime == True:
        print(player_speed_x)
        if(player_speed_x >= 10):
            player_speed_x -= 0.04
        player_x += player_speed_x
        player_y += player_speed_y
        if owari == False:
            player_angle += 15
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
                owari = True
        if keyboard.up:
            player_x = 50
            player_y = 0

            player_speed_x = 5
            player_speed_y = 0
            player_angle = 1
            angles = 1
            gravity = 0.5
            owari = False
def draw():
    global player_x,player_y,player_angle
    screen.clear()
    screen.fill((255, 255, 255))
    ball.x = player_x
    ball.y = player_y
    ball.angle = player_angle
    ball.draw()
pgzrun.go()
