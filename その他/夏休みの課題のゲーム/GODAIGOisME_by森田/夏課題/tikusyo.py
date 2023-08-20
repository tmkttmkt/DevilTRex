import math
import random
import pygame
from pgzhelper import *
import pgzrun

WIDTH = 700
HEIGHT = 700
GRAVITY = 0.5
map_data1 = [[0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [1,1,1,1,1,1,1,1,1,1]]

map_data2 = [[0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,1,0,0,0,0],
            [0,0,0,0,0,1,0,0,0,0],
            [0,0,0,0,0,1,0,0,0,0],
            [0,0,0,0,0,1,0,0,0,0],
            [0,0,0,0,0,1,0,0,0,0],
            [0,0,0,0,0,1,0,0,0,0],
            [1,1,1,1,1,1,1,1,1,1]]

map_data3 = [[0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,9,0],
            [1,1,1,1,1,1,1,1,1,1]]


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
kaiten = True
stage = 1

flg = True
angle_mode = False
angles = max_angle

gauge_mode = True

ball=Actor('baka',(0,-1600))
sora = Actor('sora.png',topleft=(0,0))
zimen = Actor('jimen.png',topleft=(0,0))
ramen = Actor("cupmen.png",topleft=(0,0))


gauge_speed = 0.3
random_number = 1
#random.randint(1, 3)
font_value = 0
kiroku = 0

def on_key_down(key):
    global gauge_mode
    
    # スペースキーが押されたら、ゲームの状態を切り替える
    if key == keys.SPACE and gauge_mode == True:
        gauge_mode = False
        
def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles
    global owari,hajime,hiku,root,tobu,kyori,player_speed_x2
    global player_speed_y2,target_x,target_y,angle3,flg,root2,angle_mode,gauge_value
    global font_value,kiroku,stage,kaiten
    if gauge_mode == True:
        gauge_value += gauge_speed
        kyori += 2
        if gauge_value >= max_gauge:
            gauge_value = 0
            kyori = 5
    
    if hajime == True and gauge_mode == False:
        if player_x > WIDTH:
            player_x = 0
            stage += 1
        if player_angle > 0:
            player_angle -= hiku
        else:
            player_angle = 0
        angles += player_angle
        if tobu == True:
            if(player_speed_x >= 10):
                player_speed_x -= 0.04
            player_x += player_speed_x
            kiroku += player_speed_x
            player_y += player_speed_y
        
            player_speed_y += gravity
    
            if player_y >= HEIGHT - 90:
                if player_speed_y >= 4 or player_y <= -16:
                    gravity -= 0.01
                    player_speed_y = -player_speed_y * 0.6
                    player_y = HEIGHT - 90
                else:
                    player_speed_y = 0
                    player_speed_x = 0
                    gravity = 0
                    player_angle -= 10
                    owari = True
        if tobu == False:
            #if root > 0:
            if flg == True:
                root2 = math.atan2(player_y - mouse_y,mouse_x - player_x)
                flg = False
            player_x += player_speed_x2 * math.cos(root2)
            kiroku += player_speed_x2 * math.cos(root2)
            player_y -= player_speed_y2 * math.sin(root2)
            player_x += kyori
            player_y -= kyori
            if kaiten == True:
                player_angle += kaiten * 5
            kyori -= 1
            if kyori == 0 or player_y >= HEIGHT - 90:
                tobu = True
                
        if angle_mode == True and owari == True:
            font_max = int(kiroku)
            if font_value < font_max:
                font_value += 3
    else:
        player_x = 110
        player_y = 500
def draw():
    global player_x,player_y,player_angle,angle_mode,kyori
    screen.clear()
    if stage == 1:
        for y in range(10):
            for x in range(10):
                sora.topleft=(70*x,70*y)
                sora.draw()
                if map_data1[y][x] == 1:
                    zimen.topleft=(70*x,70*y)
                    zimen.draw()
    if stage == 2:
        for y in range(10):
            for x in range(10):
                sora.topleft=(70*x,70*y)
                sora.draw()
                if map_data2[y][x] == 1:
                    zimen.topleft=(70*x,70*y)
                    zimen.draw()
    if stage >= 3:
        for y in range(10):
            for x in range(10):
                sora.topleft=(70*x,70*y)
                sora.draw()
                if map_data3[y][x] == 1:
                    zimen.topleft=(70*x,70*y)
                    zimen.draw()
                if random_number == 1:
                    ramen.topleft = (230,230)
                    ramen.draw()
                    ramen.scale = 2
    if gauge_mode == True:
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
    else:
        if hajime == True and owari == False:
            screen.draw.text("ただいま" + str(int(kiroku)) + "m",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="blue",fontsize=30)
    if angle_mode == True and owari == True:
        screen.draw.text("結果" + str(font_value) + "m",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="blue",fontsize=30)
def on_mouse_down(pos,button):
    global mouse_x, mouse_y,x2,y2,root,flg,hajime,angle_mode
    if gauge_mode == False:
        angle_mode = True
        hajime = True
    #if tobu == False and flg == 1:
        mouse_y = pos[1]
        mouse_x = pos[0]
        #flg = 0
pgzrun.go()
