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
map_data1 = [[0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,3,0,3,0,3,0,3,0,3],
            [1,1,1,1,1,1,1,1,1,1]]

map_data2 = [[0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
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
mouse_x2 = 0
mouse_y2= 0
max_angle = 100
gravity = 0.5
owari = False
hajime = False
tobu = False
root = 0
gauge_value = 19
max_gauge = 10
kyori = 50
kaiten = True
stage = 1

flg = True
angle_mode = False
water_flg = False
angles = max_angle

gauge_mode = True

ball=Actor('yakan',(0,-1600))
ball.scale = 0.5
sora = Actor('sora.png',topleft=(0,0))
zimen = Actor('jimen.png',topleft=(0,0))
ramen = Actor("cupmen.png",topleft=(0,0))
ca_ue = Actor('canon_une.png',topleft=(-570,-15))
taiya = Actor('taiya.png',topleft=(-150,265))
tree = Actor('tree.png',topleft=(0,0))
water = Actor('water.png',topleft=(0,0))

water.rect = Rect((water.x, water.y), (500, 100))
ramen.rect = Rect((ramen.x, ramen.y), (40, 100))
random_x = random.randint(100, 500)
random_number = random.randint(2,4)
men_kyori = 0
gauge_speed = 0.3
#random.randint(1, 3)
font_value = 0
kiroku = 0
kiroku2 = 0
kiroku_value = 0

def on_key_down(key):
    global gauge_mode
    
    if key == keys.SPACE and gauge_mode == True:
        gauge_mode = False
    
        
def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles
    global owari,hajime,hiku,root,tobu,kyori,player_speed_x2
    global player_speed_y2,target_x,target_y,angle3,flg,root2,angle_mode,gauge_value
    global font_value,kiroku,stage,kaiten,water_flg,kiroku2,kiroku_value
    if gauge_mode == True:
        gauge_value += gauge_speed
        kyori += 2
        if gauge_value >= max_gauge:
            gauge_value = 0
            kyori = 15
    
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
                    water_flg = True
        if tobu == False:
            #if root > 0:
            if flg == True:
                root2 = math.atan2(player_y - mouse_y,mouse_x - player_x)
                flg = False
            player_x += (player_speed_x2 + kyori) * math.cos(root2)
            kiroku += (player_speed_x2 + kyori) * math.cos(root2)
            player_y -= (kyori + player_speed_y2) * math.sin(root2)

            if kaiten == True:
                player_angle += kaiten * 5
            kyori -= 1
            if kyori == 0 or player_y >= HEIGHT - 90:
                tobu = True
                
        if angle_mode == True and owari == True:
            font_max = int(kiroku)
            if font_value < font_max:
                font_value += 3
            if kiroku_value < kiroku2:
                kiroku_value += 5
    else:
        player_x = 110
        player_y = 500
    if gauge_mode == False and angle_mode == False:
        angle_ca = math.atan2(ca_ue.y - mouse_y2, mouse_x2 - ca_ue.x)
        ca_ue.angle = math.degrees(angle_ca) - 30

def Mappp():
    for y in range(10):
        for x in range(10):
            sora.topleft=(70*x,70*y)
            sora.draw()
            if map_data1[y][x] == 1:
                zimen.topleft=(70*x,70*y)
                zimen.draw()
            if map_data1[y][x] == 3:
                tree.topleft=(70*x,70*y)
                tree.draw()    
def Kekka(flg):
    if flg == 1:
        screen.draw.text("審議会の評価：すごい！",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="red",fontsize=30)
    if flg == 2:
        screen.draw.text("審議会の評価：凡庸！",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="blue",fontsize=30)
def draw():
    global player_x,player_y,player_angle,angle_mode,kyori,men_kyori,kiroku2
    screen.clear()
    if stage == 1:
        for y in range(10):
            for x in range(10):
                sora.topleft=(70*x,70*y)
                sora.draw()
                if map_data2[y][x] == 1:
                    zimen.topleft=(70*x,70*y)
                    zimen.draw()
    if stage >= 5:
        Mappp()
    if stage == 2:
        Mappp()
        if random_number == 2:
            ramen.topleft = (random_x,550)
            ramen.scale = 0.25
            ramen.draw()
    if stage == 3:
        Mappp()
        if random_number == 3:
            ramen.topleft = (random_x,550)
            ramen.scale = 0.25
            ramen.draw()
    if stage == 4:
        Mappp()
        if random_number == 4:
            ramen.topleft = (random_x,550)
            ramen.scale = 0.25
            ramen.draw()
            
    ball.x = player_x
    ball.y = player_y
    water.x = player_x
    water.y = player_y - 30
    ball.angle = angles
    ball.scale = 1.25
    ball.draw()
    water.rect = Rect((player_x - 120, player_y - 70), (250, 150))
    ramen.rect = Rect((random_x - 40,480), (150, 150))
    if stage == random_number:
        screen.draw.rect(ramen.rect, (255,0, 0, 100))
    screen.draw.rect(water.rect, (255, 0, 0, 100))
    if angle_mode == False or stage == 1:
        #screen.draw.text("覚悟をみせろ",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="blue",fontsize=30)
        men_kyori = random_x + ((random_number - 1) * 600)
        screen.draw.text("麺まであと"+ str(men_kyori) + "m",(400,0),fontname="in_game.ttf",color="blue",fontsize=30)
        ca_ue.scale = 0.35
        ca_ue.draw()
        taiya.scale = 0.35
        taiya.draw()
    else:
        if hajime == True and owari == False:
            screen.draw.text("ただいま" + str(int(kiroku)) + "m",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="blue",fontsize=30)
            screen.draw.text("ステージ" + str(stage) + "面",(500,0),fontname="in_game.ttf",color="blue",fontsize=30)
    if gauge_mode == True:
        gauge_width =  600 * gauge_value / max_gauge
        gauge_width = min(gauge_width,600 - 102)
        gauge_x = 20
        gauge_rect = Rect(500,600 - gauge_width, 50,gauge_width)
        screen.draw.filled_rect(Rect((500, 105), (50, 490)),(255,0,0))
        screen.draw.rect(Rect((500, 104.5), (50, 490)),(0,0,0))
        screen.draw.filled_rect(gauge_rect, (0, 255, 0))
        screen.draw.rect(gauge_rect, (0,0, 0))
        
    if angle_mode == True and owari == True:
        screen.draw.text("結果" + str(font_value) + "m",(WIDTH//2,200),fontname="in_game.ttf",color="blue",fontsize=30)
        kiroku2 = men_kyori - kiroku
        #if stage == random_number:
            #kiroku2 = ramen.x - ball.x
        #else:
            #stage_kyori = (stage - random_number) * 600
            #if stage_kyori < 0:
             #   stage_kyori *= -1
            #kiroku2 = ramen.x - stage_kyori
        if kiroku2 < 0:
            kiroku2 *= -1
        screen.draw.text("麺との距離" + str(int(kiroku_value)) + "m",(WIDTH//2,HEIGHT//4),fontname="in_game.ttf",color="red",fontsize=30)
        
    if water_flg == True:
        clock.tick(2)
        water.draw()
        if water.rect.colliderect(ramen.rect) and stage == random_number:
            Kekka(1)
        else:
            if kiroku2 >= 100 and kiroku2 <= 600:
                Kekka(2)
def on_mouse_down(pos,button):
    global mouse_x, mouse_y,x2,y2,root,flg,hajime,angle_mode
    if gauge_mode == False:
        angle_mode = True
        hajime = True
    #if tobu == False and flg == 1:
        mouse_y = pos[1]
        mouse_x = pos[0]
        #flg = 0

def on_mouse_move(pos):
    global mouse_x2,mouse_y2
    mouse_y2 = pos[1]
    mouse_x2 = pos[0]
    
pgzrun.go()
