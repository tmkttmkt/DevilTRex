import math
import pygame
from pygame import Vector2
import pgzrun

WIDTH = 1600
HEIGHT = 600
GRAVITY = 0.5

player_x = 50
player_y = 0
x2 = 0
y2 = 0
player_speed_x = 5
player_speed_y = 0
player_angle = 500
angles = 0
hiku = 2.5
mouse_x = 0
mouse_y = -600
max_angle = 100
gravity = 0.5
owari = False
hajime = False

angles = max_angle
ball=Actor('baka')

def on_key_down(key):
    global hajime
    hajime = True
        
def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles,owari,hajime,hiku
    
    if hajime == True:
        print(player_speed_x)
        if(player_speed_x >= 10):
            player_speed_x -= 0.04
        player_x += player_speed_x
        player_y += player_speed_y
        angles += player_angle
        if player_angle > 0:
            player_angle -= hiku
        else:
            player_angle = 0
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
            player_x = x2
            player_y = y2

            player_speed_x = 5
            player_speed_y = 0
            player_angle = 500
            angles = max_angle
            gravity = 0.5
            owari = False
    else:
        player_x = x2
        player_y = y2
def draw():
    global player_x,player_y,player_angle
    screen.clear()
    screen.fill((255, 255, 255))
    ball.x = player_x
    ball.y = player_y
    ball.angle = angles
    ball.draw()
    screen.draw.text("Mouse Y: {}".format(mouse_y), topleft=(10, 10), color="black")
    cursor_x = mouse
    cursor_y = mouse
    #ball_center_x, ball_center_y = ball.pos
    #delta_y = cursor_y - ball_center_y
    #delta_x = cursor_x - ball_center_x
    #angle_radians = math.atan2(delta_y, delta_x)
    #height = math.tan(angle_radians) * delta_x
    
def on_mouse_move(pos, rel, buttons):
    global mouse_x, mouse_y,x2,y2
    mouse_x,mouse_y = pos
    x2, y2 = map(int, pos)
pgzrun.go()
