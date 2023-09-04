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
times = 120

red = 0
blue = 0
green = 0

title = True
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
taiya = Actor('taiya.png',topleft=(-130,265))
tree = Actor('tree.png',topleft=(0,0))
water = Actor('water.png',topleft=(0,0))
Buttonsan = []


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
music.set_volume(0.25)
setumei = False
ramen.center = (random_x,600)
re_flg = False
#rect_x = 0
#rect_y = 0
#moji = ""


def on_key_down(key):
    global gauge_mode,title
    if key == keys.SPACE and gauge_mode == True:
        gauge_mode = False
    
        
def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles
    global owari,hajime,hiku,root,tobu,kyori,player_speed_x2
    global player_speed_y2,angle3,flg,root2,angle_mode,gauge_value,gauge_mode,max_gauge
    global font_value,kiroku,stage,kaiten,water_flg,kiroku2,kiroku_value,red,blue,green
    global random_number,random_x,re_flg,times
    red = random.randint(0, 255)
    blue = random.randint(0, 255)
    green = random.randint(0, 255)
    if title == False:
        if times != 0:
            times -= 1 
        if gauge_mode == True:
            gauge_value += gauge_speed
            kyori += 1
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
                        sounds.tyakuti.play()
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
                    font_value += 10
                if kiroku_value < kiroku2:
                    kiroku_value += 10
        if gauge_mode == False and angle_mode == False:
            angle_ca = math.atan2(ca_ue.y - mouse_y2, mouse_x2 - ca_ue.x)
            ca_ue.angle = math.degrees(angle_ca) - 30
            taiya.x = 200
    else:
        if title == True and owari == True:
            Syokika()
    if re_flg == True and owari == True and title == False:
        print("j")
        Syokika()
        re_flg == False
    if setumei == True:
        ru_ru.update()
def Syokika():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles
    global owari,hajime,hiku,root,tobu,kyori,player_speed_x2
    global player_speed_y2,angle3,flg,root2,angle_mode,gauge_value,gauge_mode,max_gauge
    global font_value,kiroku,stage,kaiten,water_flg,kiroku2,kiroku_value,red,blue,green
    global random_number,random_x,re_flg,times
    random_x = random.randint(100, 500)
    print(random_x)
    random_number = random.randint(2,4)
    print(random_number)
    player_x = 110
    player_y = 500
    times = 120
    flg = True
    angle_mode = False
    water_flg = False
    gauge_mode = True
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
    player_speed_x = 5
    player_speed_y = 5
    player_speed_x2 = 5
    player_speed_y2 = 5
    player_angle = 500
    ca_ue.angle = 0
    font_value = 0
    kiroku = 0
    kiroku2 = 0
    kiroku_value = 0
    taiya.x = 210
    water.rect = Rect((water.x, water.y), (500, 100))
    ramen.rect = Rect((ramen.x, ramen.y), (40, 100))
    ramen.center = (random_x,600)
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
    my_flg = True
    if flg == 1:
        screen.draw.text("審議会の評価：すごい！",(160,400),fontname="in_game.ttf",color="red",fontsize=35)
        screen.draw.text("名誉ラーメン人",(210,450),fontname="in_game.ttf",color=(red,blue,green),fontsize=35)
    if flg == 2:
        screen.draw.text("審議会の評価：凡庸！",(140,420),fontname="in_game.ttf",color="red",fontsize=45)
        print("2")
    if flg == 3:
        screen.draw.text("審議会の評価：下手くそ！",(120,420),fontname="in_game.ttf",color="blue",fontsize=42)
        print("3")
    if flg == 4:
        screen.draw.text("審議会の評価：IQ－100",(120,420),fontname="in_game.ttf",color="blue",fontsize=45)
        print("4")
    if flg == 5:
        screen.draw.text("審議会の評価：惜しい！",(140,420),fontname="in_game.ttf",color="blue",fontsize=45)
        print("5")
def on_music_end():
    if title == False:
        music.set_volume(0.25)
        music.play('metal')
class Buttons:
    def __init__(self,rect_x,rect_y,moji,mode):
        self.rect_x = rect_x
        self.rect_y = rect_y
        self.moji = ""
        self.moji = moji
        self.mode = mode
        self.flg = True
    #def update_string(self,moji):
        #self.moji = moji
    def draw(self):
        screen.draw.filled_rect(Rect((self.rect_x-2, self.rect_y-2), (154, 54)),(0,0,0))
        screen.draw.filled_rect(Rect((self.rect_x, self.rect_y),(150, 50)),(84,57,51))
        screen.draw.text(self.moji,(self.rect_x + 22,self.rect_y + 12),fontname="title.ttf",color="black")
        screen.draw.text(self.moji,(self.rect_x + 20,self.rect_y + 12),fontname="title.ttf",color="white")
    def on_mouse_down(self,pos,button):
        global title,setumei,re_flg
        print("1")
        if self.mode == 1:
            print("1.5")
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50):
                print("2")# and self.rect_y == pos[1]:
                sounds.button.play()
                if title == True:
                    title = False
                    if title == False:
                        if self.flg == True:
                            music.set_volume(1)
                            music.play_once('kakugo')
        if self.mode == 2:
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50):
                sounds.button.play()
                if title == False:
                    title = True
                    music.stop()
        if self.mode == 3:
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50):
                sounds.button.play()
                ru_ru.syokika()
                setumei = True
                print("a")
                ru_ru.draw()
        if self.mode == 4:
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50):
                sounds.button.play()
                setumei = False
                title = True
                print("a")
                ru_ru.draw()
        if self.mode == 5:
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50):
                sounds.button.play()
                print("a")
                re_flg = True
                music.stop()
                if title == False:
                    if self.flg == True:
                        music.set_volume(1)
                        music.play_once('kakugo')

class Mini_map():
    def __init__(self):
        self.minimap_width = WIDTH // 2
        self.minimap_height = HEIGHT // 4
        self.minimap_x = 0
        self.minimap_y = 0
    def draw(self):
        screen.draw.filled_rect(Rect(0, 0, self.minimap_width, self.minimap_height // 2), "gray")
        screen.draw.rect(Rect(0, 0, self.minimap_width, self.minimap_height // 2), "black")
        screen.draw.rect(Rect(20, 10, self.minimap_width - 40, self.minimap_height // 3 + 10), "green")
        screen.draw.rect(Rect(30, 20, self.minimap_width - 60, self.minimap_height // 4 + 5), "green")
        screen.draw.rect(Rect(40, 30, self.minimap_width - 80, self.minimap_height // 5 - 5), "green")
        #screen.draw.rect(Rect(50, 35, self.minimap_width - 100, self.minimap_height // 6 - 10), "green")
   
        ramen_minimap_x = (ramen.x + (random_number - 1) * 600) / random_number
        ramen_minimap_x = ramen_minimap_x // 2
        ramen_minimap_y = (self.minimap_height / HEIGHT) * ramen.y
        ramen_minimap_y = ramen_minimap_y // 2
        screen.draw.filled_circle((ramen_minimap_x, ramen_minimap_y), 5, "red")
    
        player_minimap_x = (ball.x + (stage - 1) * 600) / random_number
        player_minimap_x = player_minimap_x // 2
        player_minimap_y = (self.minimap_height / HEIGHT) * ball.y
        player_minimap_y = player_minimap_y // 2
        if player_minimap_x <= self.minimap_width:
            screen.draw.filled_circle((player_minimap_x, player_minimap_y), 5, "blue")
Mini_Mop = Mini_map()
Buttonkun1 = Buttons(100,100,"スタート",1)
Buttonkun2 = Buttons(100,100,"Yeag",2)
Buttonkun3 = Buttons(100,100,"遊び方",3)
Buttonkun4 = Buttons(100,100,"タイトルへ",4)
Buttonkun5 = Buttons(100,100,"リトライ",5)

class Setumei:
    def __init__(self):
        self.red = random.randint(0, 255)
        self.blue = random.randint(0, 255)
        self.green = random.randint(0, 255)
        self.times = 240
        self.flg = True
        self.flg2 = True
        self.flg3= True
        self.flg4 = True
    def update(self):
        self.times -= 1
    def draw(self):
        screen.clear()
        for y in range(10):
            for x in range(10):
                sora.topleft=(70*x,70*y)
                sora.draw()
                if map_data2[y][x] == 1:
                    zimen.topleft=(70*x,70*y)
                    zimen.draw()
        screen.draw.filled_rect(Rect((100, 100), (500, 500)), (255, 255, 255))
        screen.draw.rect(Rect((100, 100), (500, 500)), (0, 0, 0))
        screen.draw.text("遊び方",(252,130),fontname="in_game.ttf",color = 'black',fontsize=60)
        screen.draw.text("遊び方",(250,130),fontname="in_game.ttf",color = 'red',fontsize=60)
        if self.times <= 180:
            screen.draw.text("１．スペースキーでパワーを溜める",(120,230),fontname="in_game.ttf",color = 'black',fontsize=30)
            if self.flg == True:
                sounds.iron.play()
                self.flg = False
        if self.times <= 120:
            screen.draw.text("２．マウスで狙いを定める",(120,300),fontname="in_game.ttf",color = 'black',fontsize=30)
            if self.flg2 == True:
                print("b")
                sounds.iron.play()
                self.flg2 = False
        if self.times <= 60:
            screen.draw.text("３．クリックで放つ",(120,370),fontname="in_game.ttf",color = 'black',fontsize=30)
            if self.flg3 == True:
                sounds.iron.play()
                print("a")
                self.flg3 = False
        if self.times <= 0:
            screen.draw.text("４．麺にお湯がかかるように祈る",(120,440),fontname="in_game.ttf",color = 'black',fontsize=30)
            if self.flg4 == True:
                print("a")
                sounds.iron.play()
                self.flg4 = False
    def syokika(self):
        self.flg = True
        self.flg2 = True
        self.flg3= True
        self.flg4 = True
        self.times = 240
ru_ru = Setumei()
def draw():
    global player_x,player_y,player_angle,angle_mode,kyori,men_kyori,kiroku2
    screen.clear()
    if setumei == False:
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
                ramen.scale = 0.25
                ramen.draw()
        if stage == 3:
            Mappp()
            if random_number == 3:
                ramen.scale = 0.25
                ramen.draw()
        if stage == 4:
            Mappp()
            if random_number == 4:
                ramen.scale = 0.25
                ramen.draw()
    
        ball.x = player_x
        ball.y = player_y
        water.x = player_x
        water.y = player_y - 30
        ball.angle = angles
        if (angle_mode == True or gauge_mode == True or title == True) and hajime == False:
            ball.scare = 0.0125
        else:
            ball.scale = 1.25
        ball.draw()
        if stage == 1:
            ca_ue.scale = 0.35
            ca_ue.draw()
            taiya.scale = 0.35
            taiya.draw()
        if title == True:
            screen.draw.text("インスタンス　ラーメン",(30,150),fontname="title.ttf",color="black",fontsize=60)
            screen.draw.text("インスタンス　ラーメン",(28,150),fontname="title.ttf",color="white",fontsize=60)
            screen.draw.text("～湯を飛ばす　わびさびゲーム～",(38,230),fontname="title.ttf",color="black",fontsize=40)
            screen.draw.text("～湯を飛ばす　わびさびゲーム～",(36,230),fontname="title.ttf",color="white",fontsize=40)
            Buttonkun1.__init__(280,360,"スタート",1)
            Buttonkun1.draw()
            Buttonkun3.__init__(280,460,"遊び方",3)
            Buttonkun3.draw()
        if title == False and times == 0:
            Mini_Mop.draw()
            screen.draw.text("ミニマップ",(0,0),fontname="title.ttf",color="red",fontsize=30)
            water.rect = Rect((player_x - 120, player_y - 70), (250, 150))
            ramen.rect = Rect((random_x - 40,480), (150, 150))
            if stage == random_number:
                screen.draw.rect(ramen.rect, (255,0, 0, 100))
            screen.draw.rect(water.rect, (255, 0, 0, 100))
            if title == False:
                if gauge_mode == False and hajime == False:
                    screen.draw.text("狙いを定めてクリック",(200,100),fontname="in_game.ttf",color="red",fontsize=50)
            if angle_mode == False or stage == 1:
                men_kyori = random_x + ((random_number - 1) * 600)
                screen.draw.text("麺まであと"+ str(men_kyori) + "m",(400,0),fontname="in_game.ttf",color="blue",fontsize=30)
            else:
                if hajime == True and owari == False:
                    screen.draw.text("ただいま" + str(int(kiroku)) + "m",(WIDTH//2,HEIGHT//2),fontname="in_game.ttf",color="white",fontsize=30)
                    screen.draw.text("ステージ" + str(stage) + "面",(500,0),fontname="in_game.ttf",color="white",fontsize=30)
            if gauge_mode == True:
                gauge_width =  600 * gauge_value / max_gauge
                gauge_width = min(gauge_width,600 - 102)
                gauge_x = 20
                gauge_rect = Rect(500,600 - gauge_width, 50,gauge_width)
                screen.draw.filled_rect(Rect((500, 105), (50, 490)),(255,0,0))
                screen.draw.rect(Rect((500, 104.5), (50, 490)),(0,0,0))
                screen.draw.filled_rect(gauge_rect, (0, 255, 0))
                screen.draw.rect(gauge_rect, (0,0, 0))
                screen.draw.text("スペースキーで",(100,150),fontname="in_game.ttf",color="red",fontsize=50)
                screen.draw.text("ゲージを止める",(100,210),fontname="in_game.ttf",color="red",fontsize=50)
            if angle_mode == True and owari == True and re_flg == False:
                if water_flg == True:
                    water.draw()
                    screen.draw.filled_rect(Rect((100, 100), (500, 500)), (255, 255, 255))
                    screen.draw.rect(Rect((100, 100), (500, 500)), (0, 0, 0))
                    if kiroku_value > kiroku2 and font_value > int(kiroku):
                        if water.rect.colliderect(ramen.rect) and stage == random_number:
                            Kekka(1)
                        else:
                            if kiroku2 >= 100 and kiroku2 <= 600:
                                Kekka(2)
                            else:
                                if kiroku2 >= 600 and kiroku2 <= 1000 and stage != random_number:
                                    Kekka(3)
                                else:
                                    if stage != random_number:
                                        Kekka(4)
                                    else:
                                        Kekka(5)
                screen.draw.text("結果発表",(212,130),fontname="in_game.ttf",color = 'black',fontsize=60)
                screen.draw.text("結果発表",(210,130),fontname="in_game.ttf",color = 'red',fontsize=60)
                screen.draw.text("飛行距離" + str(font_value) + "m",(210,250),fontname="in_game.ttf",color="blue",fontsize=35)
                clock.tick(2)
                kiroku2 = men_kyori - kiroku
                if kiroku2 < 0:
                    kiroku2 *= -1
                screen.draw.text("麺との距離" + str(int(kiroku_value)) + "m",(210,330),fontname="in_game.ttf",color="red",fontsize=35)
                Buttonkun4.__init__(260,520,"タイトルへ",4)
                Buttonkun4.draw()
                #Buttonkun5.__init__(260,580,"リトライ？",5)
                #Buttonkun5.draw()
    else:
        ca_ue.scale = 0.35
        ca_ue.draw()
        taiya.scale = 0.35
        taiya.draw()
        ru_ru.draw()
        Buttonkun4.__init__(260,520,"タイトルへ",4)
        Buttonkun4.draw()
def on_mouse_down(pos,button):
    global mouse_x, mouse_y,x2,y2,root,flg,hajime,angle_mode,title
    if title == False:
        if gauge_mode == False:
            angle_mode = True
            hajime = True
            if water_flg == False:
                sounds.sakebi.play()
    #if tobu == False and flg == 1:
    mouse_y = pos[1]
    mouse_x = pos[0]
        #flg = 0:
    Buttonkun1.on_mouse_down(pos,button)
    Buttonkun2.on_mouse_down(pos,button)
    Buttonkun3.on_mouse_down(pos,button)
    Buttonkun4.on_mouse_down(pos,button)
    Buttonkun5.on_mouse_down(pos,button)
def on_mouse_move(pos):
    global mouse_x2,mouse_y2
    mouse_y2 = pos[1]
    mouse_x2 = pos[0]
    
pgzrun.go()
