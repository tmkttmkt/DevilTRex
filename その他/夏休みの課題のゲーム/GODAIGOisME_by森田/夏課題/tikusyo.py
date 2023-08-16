import math
import pygame
from pygame import Vector2
import pgzrun

WIDTH = 1600
HEIGHT = 600
GRAVITY = 0.5

player_x = 110
player_y = 600
x2 = 0
y2 = 0
player_speed_x = 5
player_speed_y = 5
player_speed_x2 = 5
player_speed_y2 = 5
player_angle = 500
angles = 0
angle3 = 0
hiku = 2.5
mouse_x = 0
mouse_y = 0
max_angle = 100
gravity = 0.5
owari = False
hajime = False
tobu = False
root = 0
x3 = 0
y3 = 0
target_x = None
target_y = None
kyori = 100
flg = 1
angles = max_angle
ball=Actor('baka',(0,-1600))

def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles,owari,hajime,hiku,root,tobu,x3,y3,kyori,player_speed_x2,player_speed_y2,target_x,target_y,angle3
    
    if hajime == True:
        print(player_y)
        if player_angle > 0:
            player_angle -= hiku
        else:
            player_angle = 0
        angles += player_angle
        if tobu == True:
            if(player_speed_x >= 10):
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
                    owari = True
        if tobu == False:
            x2 = mouse_x - player_x
            y2 = mouse_y - player_y
            root = math.sqrt(x2**2 + y2**2)
            #if root > 0:
            x3 = (x2 / root) * player_speed_x2
            y3 = (y2 / root) * player_speed_y2
            player_x += x3
            player_y += y3
            kyori -= 1
            if kyori == 0:
                tobu = True
            #player_y = mouse_y * player_speed_y * 0.5
            #x2 = ball.x - mouse_x
            #x2 = x2 ** 2
            #y2 = ball.y - mouse_y
            #y2 = y2 ** 2
            #root1 = math.sqrt(x2)
            #root2 = math.sqrt(y2)
            #player_y -= root2 + player_speed_y
            #player_x -= root1 + player_speed_x
            
    else:
        player_x = 110
        player_y = 300
def draw():
    global player_x,player_y,player_angle
    screen.clear()
    screen.fill((255, 255, 255))
    ball.x = player_x
    ball.y = player_y
    ball.angle = angles
    ball.draw()
    #ball_center_x, ball_center_y = ball.pos
    #delta_y = cursor_y - ball_center_y
    #delta_x = cursor_x - ball_center_x
    #angle_radians = math.atan2(delta_y, delta_x)
    #height = math.tan(angle_radians) * delta_x
    
def on_mouse_down(pos,button):
    global mouse_x, mouse_y,x2,y2,root,flg,hajime
    hajime = True
    #if tobu == False and flg == 1:
    mouse_y = pos[1]
    mouse_x = pos[0]
        #flg = 0
pgzrun.go()
