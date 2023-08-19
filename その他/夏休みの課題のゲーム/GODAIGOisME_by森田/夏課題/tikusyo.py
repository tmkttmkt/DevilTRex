import math
import pygame
from pygame import Vector2
import pgzrun

WIDTH = 600
HEIGHT = 600
GRAVITY = 0.5

player_x = 110
player_y = 600
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
gauge_value = 19
max_gauge = 10
kyori = 100
flg = True
angle_mode = False
angles = max_angle
ball=Actor('baka',(0,-1600))
gauge_speed = 0.3
font_value = 0
kiroku = 0

def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles
    global owari,hajime,hiku,root,tobu,kyori,player_speed_x2
    global player_speed_y2,target_x,target_y,angle3,flg,root2,angle_mode,gauge_value,font_value,kiroku

    gauge_value += gauge_speed

    if gauge_value >= max_gauge:
        gauge_value = 0
    
    if hajime == True:
        if player_x > WIDTH:
            player_x = 0
            kiroku += 600
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
            #if root > 0:
            if flg == True:
                root2 = math.atan2(player_y - mouse_y,mouse_x - player_x)
                flg = False
            player_x += player_speed_x2 * math.cos(root2)
            player_y -= player_speed_y2 * math.sin(root2)
            kyori -= 1
            if kyori == 0:
                tobu = True
        if angle_mode == True and owari == True:
            font_max = int(kiroku)
            if font_value < font_max:
                font_value += 3
    else:
        player_x = 110
        player_y = 300
def draw():
    global player_x,player_y,player_angle,angle_mode
    screen.clear()
    screen.fill((255, 255, 255))
    gauge_width =  HEIGHT * gauge_value / max_gauge
    gauge_width = min(gauge_width,HEIGHT - 102)
    gauge_x = 20
    gauge_rect = Rect(WIDTH//2 - 50,HEIGHT - gauge_width, 50,gauge_width)
    screen.draw.rect(Rect((220, 100), (200, 600)),(0,0,0))
    screen.draw.filled_rect(gauge_rect, (0, 255, 0))
    ball.x = player_x
    ball.y = player_y
    ball.angle = angles
    ball.draw()
    if angle_mode == False:
        screen.draw.text("覚悟をみせろ",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="blue",fontsize=30)
    if angle_mode == True and owari == True:
        screen.draw.text("結果" + str(font_value) + "m",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="blue",fontsize=30)
def on_mouse_down(pos,button):
    global mouse_x, mouse_y,x2,y2,root,flg,hajime,angle_mode
    angle_mode = True
    hajime = True
    #if tobu == False and flg == 1:
    mouse_y = pos[1]
    mouse_x = pos[0]
        #flg = 0
pgzrun.go()
