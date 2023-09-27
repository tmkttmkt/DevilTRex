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
mainasu = 1
m_y = 0
m_x = 0
mouse_x2 = 0
mouse_y2= 0
music_flg = 0
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

d_red = 0
d_blue = 0
d_green = 0

title = True
flg = True
angle_mode = False
water_flg = False
angles = max_angle
my_flg = True

gauge_mode = True
ramdom_men = random.randint(1,3)
ball=Actor('yakan',(0,-1600))
ball.scale = 0.5
sora = Actor('sora.png',topleft=(0,0))
zimen = Actor('jimen.png',topleft=(0,0))
ca_ue = Actor('canon_une.png',topleft=(-570,-15))
taiya = Actor('taiya.png',topleft=(-130,265))
tree = Actor('tree.png',topleft=(0,0))
water = Actor('water.png',topleft=(0,0))
kasoru = Actor('ka-soru2')
ura = Actor('urapng.png',topleft=(-570,-15))
jukai = Actor('jukai.jpg',topleft=(0,0))
sabaku = Actor('a_tisu.jpg',topleft=(0,0))
ro_ma = Actor('ro-ma.jpg',topleft=(0,0))
manhattan = Actor('manhattan.jpg',topleft=(0,0))
nihon = Actor('ukiyoe',topleft=(0,0))


Buttonsan = []
if ramdom_men == 1:
    ramen = Actor("cupmen.png",topleft=(0,0))
    ramen.scale = 0.25
else:
    if ramdom_men == 2:
        ramen = Actor("soba.png",topleft=(0,0))
        ramen.scale = 0.14
    else:
        ramen = Actor("kare-men.png",topleft=(0,0))
        ramen.scale = 0.35
water.rect = Rect((water.x, water.y), (500, 100))
ramen.rect = Rect((ramen.x, ramen.y), (40, 100))
random_x = random.randint(100, 400)
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
music.set_volume(0.125)
music.play('wafuu')
sounds.title.play()
def on_mouse_down(pos,button):
    global mouse_x, mouse_y,x2,y2,root,flg,hajime,angle_mode,title,mainasu
    if title == False:
        if gauge_mode == False:
            angle_mode = True
            hajime = True
            if water_flg == False:
                sounds.sakebi.play()
    #if tobu == False and flg == 1:
    mouse_y = pos[1]
    mouse_x = pos[0]  * mainasu
    if ca_ue.angle >= 68:
        mainasu = -1
        #flg = 0:
    Buttonkun1.on_mouse_down(pos,button)
    Buttonkun2.on_mouse_down(pos,button)
    Buttonkun3.on_mouse_down(pos,button)
    Buttonkun4.on_mouse_down(pos,button)
    #Buttonkun5.on_mouse_down(pos,button)

def on_key_down(key):
    global gauge_mode,title
    if key == keys.SPACE and gauge_mode == True:
        gauge_mode = False
def update():
    global player_x,player_y,player_speed_y,player_speed_x,gravity,player_angle,angles
    global owari,hajime,hiku,root,tobu,kyori,player_speed_x2
    global player_speed_y2,angle3,flg,root2,angle_mode,gauge_value,gauge_mode,max_gauge
    global font_value,kiroku,stage,kaiten,water_flg,kiroku2,kiroku_value,red,blue,green
    global random_number,random_x,re_flg,times,d_red,d_blue,d_green,mainasu
    red = random.randint(0, 255)
    blue = random.randint(0, 255)
    green = random.randint(0, 255)
    d_red = random.randint(0, 110)
    d_blue = random.randint(0, 110)
    d_green = random.randint(0, 110)
    kasoru.x = mouse_x2
    kasoru.y = mouse_y2
    ma_flg = False
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
            if player_x < -1 and ma_flg == False:
                player_x = 699
                ma_flg = True
                if ma_flg == True:
                    stage -= 1
                    ma_flg = False
            if player_angle > 0:
                player_angle -= hiku
            else:
                player_angle = 0
            angles += player_angle
            if tobu == True:
                if(player_speed_x >= 10):
                    player_speed_x -= 0.04
                player_x += player_speed_x * mainasu
                kiroku += player_speed_x * mainasu
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
                if ca_ue.angle >= 65:
                    player_x += ((player_speed_x2 + kyori + 35) * math.cos(root2))
                    kiroku += ((player_speed_x2 + kyori + 35) * math.cos(root2))
                    player_y -= (kyori + player_speed_y2 + 10) * math.sin(root2)
                elif ca_ue.angle >= 59 and ca_ue.angle <= 64:
                    player_x += 2
                    kiroku += 2
                    player_y -= (kyori + player_speed_y2) * math.sin(root2)
                else:
                    player_x += ((player_speed_x2 + kyori) * math.cos(root2))
                    kiroku += ((player_speed_x2 + kyori) * math.cos(root2))
                    player_y -= (kyori + player_speed_y2) * math.sin(root2)

                if kaiten == True:
                    player_angle += kaiten * 5
                kyori -= 1
                if kyori == 0 or player_y >= HEIGHT - 90:
                    tobu = True
                
            if angle_mode == True and owari == True:
                font_max = int(kiroku)
                if water.rect.colliderect(ramen.rect) and stage == random_number:
                    kiroku2 = 0
                if stage >= 0:
                    if font_value < font_max:
                        font_value += 10
                    if kiroku_value < kiroku2:
                        kiroku_value += 10
                else:
                    if font_value > font_max:
                        font_value -= 10
                    if kiroku_value < kiroku2:
                        kiroku_value += 10
        if gauge_mode == False and angle_mode == False:
            angle_ca = math.atan2(ca_ue.y - mouse_y2, mouse_x2 - ca_ue.x)
            ca_ue.angle = math.degrees(angle_ca) - 30
            ura.angle = math.degrees(angle_ca) - 30
            print(ca_ue.angle)
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
    global random_number,random_x,re_flg,times,random_men,my_flg
    music.stop()
    music.set_volume(0.125)
    music.play('wafuu')
    if music_flg == 1:
        sounds.hagemasi.play()
    else:
        if music_flg == 2:
            sounds.futuu.play()
        else:
            if music_flg == 3:
                sounds.nagusame.play()
            else:
                if music_flg == 4:
                    sounds.saitei.play()
                else:
                    if music_flg == 5:
                        sounds.osii.play()
    random_x = random.randint(100, 500)
    print(random_x)
    random_number = random.randint(2,4)
    ramdom_men = random.randint(1,3)
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
    my_flg = True
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
    ura.angle = 0
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
        self.flg2 = False
    #def update_string(self,moji):
        #self.moji = moji
    def draw(self):
        screen.draw.filled_rect(Rect((self.rect_x-2, self.rect_y-2), (154, 54)),(0,0,0))
        screen.draw.filled_rect(Rect((self.rect_x, self.rect_y),(150, 50)),(84,57,51))
        screen.draw.text(self.moji,(self.rect_x + 22,self.rect_y + 12),fontname="title.ttf",color="black")
        screen.draw.text(self.moji,(self.rect_x + 20,self.rect_y + 12),fontname="title.ttf",color="white")
    def on_mouse_down(self,pos,button):
        global title,setumei,re_flg
        if self.mode == 1:
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50):
                sounds.button.play()
                sounds.title.stop()
                sounds.hagemasi.stop()
                sounds.futuu.stop()
                sounds.nagusame.stop()
                sounds.saitei.stop()
                sounds.osii.stop()
                #music.stop()
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
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50) and title == True:
                sounds.button.play()
                ru_ru.syokika()
                setumei = True
                ru_ru.draw()
        if self.mode == 4:
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50):
                sounds.button.play()
                setumei = False
                title = True
                ru_ru.draw()
        if self.mode == 5:
            if (self.rect_x <= pos[0] <= self.rect_x + 150) and (self.rect_y <= pos[1] <= self.rect_y + 50) and title == True:
                exit()

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
        screen.draw.text("ラーメン",(ramen_minimap_x - 7, ramen_minimap_y + 7),fontname="in_game.ttf",color = 'red',fontsize=15)
    
        player_minimap_x = (ball.x + (stage - 1) * 600) / random_number
        player_minimap_x = player_minimap_x // 2
        player_minimap_y = (self.minimap_height / HEIGHT) * ball.y
        player_minimap_y = player_minimap_y // 2
        if player_minimap_x <= self.minimap_width:
            screen.draw.filled_circle((player_minimap_x, player_minimap_y), 5, "blue")
            screen.draw.text("やかん",(player_minimap_x - 7, player_minimap_y + 7),fontname="in_game.ttf",color = 'red',fontsize=15)
Mini_Mop = Mini_map()
Buttonkun1 = Buttons(100,100,"スタート",1)
Buttonkun2 = Buttons(100,100,"Yeag",2)
Buttonkun3 = Buttons(100,100,"遊び方",3)
Buttonkun4 = Buttons(100,100,"タイトルへ",4)
Buttonkun5 = Buttons(100,100,"終了する",5)

def Kekka(flg):
    global music_flg,my_flg
    if flg == 1:
        screen.draw.text("審議会の評価：すごい！",(160,400),fontname="in_game.ttf",color="red",fontsize=35)
        screen.draw.text("名誉ラーメン人",(210,450),fontname="in_game.ttf",color=(red,blue,green),fontsize=35)
        if my_flg == True:
            sounds.iron.play()
            my_flg = False
        Buttonkun4.__init__(260,520,"タイトルへ",4)
        Buttonkun4.draw()
    if flg == 2:
        screen.draw.text("審議会の評価：凡庸！",(140,420),fontname="in_game.ttf",color="red",fontsize=45)
        Buttonkun4.__init__(260,520,"タイトルへ",4)
        Buttonkun4.draw()
        if my_flg == True:
            sounds.iron.play()
            my_flg = False
    if flg == 3:
        screen.draw.text("審議会の評価：下手くそ！",(120,420),fontname="in_game.ttf",color="blue",fontsize=42)
        Buttonkun4.__init__(260,520,"タイトルへ",4)
        Buttonkun4.draw()
        if my_flg == True:
            sounds.iron.play()
            my_flg = False
    if flg == 4:
        screen.draw.text("審議会の評価：悲しい",(160,400),fontname="in_game.ttf",color="blue",fontsize=35)
        screen.draw.text("めそめそメソッド",(210,450),fontname="in_game.ttf",color=(d_red,d_blue,d_green),fontsize=35)
        Buttonkun4.__init__(260,520,"タイトルへ",4)
        Buttonkun4.draw()
        if my_flg == True:
            sounds.iron.play()
            my_flg = False
    if flg == 5:
        screen.draw.text("審議会の評価：惜しい！",(140,420),fontname="in_game.ttf",color="blue",fontsize=45)
        Buttonkun4.__init__(260,520,"タイトルへ",4)
        Buttonkun4.draw()
        if my_flg == True:
            sounds.iron.play()
            my_flg = False

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
                sounds.iron.play()
                self.flg2 = False
        if self.times <= 60:
            screen.draw.text("３．クリックで放つ",(120,370),fontname="in_game.ttf",color = 'black',fontsize=30)
            if self.flg3 == True:
                sounds.iron.play()
                self.flg3 = False
        if self.times <= 0:
            screen.draw.text("４．麺にお湯がかかるように祈る",(120,440),fontname="in_game.ttf",color = 'black',fontsize=30)
            if self.flg4 == True:
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
    global player_x,player_y,player_angle,angle_mode,kyori,men_kyori,kiroku2,music_flg
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
                ramen.draw()
        if stage == 3:
            Mappp()
            if random_number == 3:
                ramen.draw()
        if stage == 4:
            Mappp()
            if random_number == 4:
                ramen.draw()
        if stage == 0:
            jukai.draw()
            screen.draw.text("樹海",(402,40),fontname="in_game.ttf",color="black",fontsize=30)
            screen.draw.text("樹海",(400,40),fontname="in_game.ttf",color="white",fontsize=30)
        if stage == -1:
            sabaku.draw()
            screen.draw.text("アーチズ国立公園",(402,40),fontname="in_game.ttf",color="black",fontsize=30)
            screen.draw.text("アーチズ国立公園",(400,40),fontname="in_game.ttf",color="red",fontsize=30)
        if stage == -2:
            ro_ma.draw()
            screen.draw.text("ローマ　コロッセオ",(402,40),fontname="in_game.ttf",color="black",fontsize=30)
            screen.draw.text("ローマ　コロッセオ",(400,40),fontname="in_game.ttf",color="white",fontsize=30)
        if stage == -3:
            manhattan.draw()
            screen.draw.text("アメリカ　マンハッタン",(372,40),fontname="in_game.ttf",color="black",fontsize=30)
            screen.draw.text("アメリカ　マンハッタン",(370,40),fontname="in_game.ttf",color="white",fontsize=30)
        if stage == -4:
            nihon.draw()
            screen.draw.text("東洋の島国　日本",(402,40),fontname="in_game.ttf",color="black",fontsize=30)
            screen.draw.text("東洋の島国　日本",(400,40),fontname="in_game.ttf",color="red",fontsize=30)
        if hajime == True and owari == False:
            ball.scale = 1.25
            ball.draw()
        ball.x = player_x
        ball.y = player_y
        water.x = player_x
        water.y = player_y - 30
        ball.angle = angles
        if stage == 1:
            ura.scale = 0.35
            ura.draw()
            ca_ue.scale = 0.35
            ca_ue.draw()
            taiya.scale = 0.35
            taiya.draw()
        if title == True:
            screen.draw.text("インスタンス　ラーメン",(30,150),fontname="title.ttf",color="black",fontsize=60)
            screen.draw.text("インスタンス　ラーメン",(28,150),fontname="title.ttf",color="white",fontsize=60)
            screen.draw.text("～湯を飛ばす　わびさびゲーム～",(38,230),fontname="title.ttf",color="black",fontsize=40)
            screen.draw.text("～湯を飛ばす　わびさびゲーム～",(36,230),fontname="title.ttf",color="white",fontsize=40)
            Buttonkun1.__init__(480,360,"スタート",1)
            Buttonkun1.draw()
            Buttonkun3.__init__(480,460,"遊び方",3)
            Buttonkun3.draw()
            #Buttonkun5.__init__(480,560,"終了",5)
            #Buttonkun5.draw()
        if title == False and times == 0:
            music_flg = 0
            Mini_Mop.draw()
            screen.draw.text("ミニマップ",(0,0),fontname="title.ttf",color="red",fontsize=30)
            water.rect = Rect((player_x - 120, player_y - 70), (250, 150))
            ramen.rect = Rect((random_x - 40,480), (150, 150))
            if stage == random_number:
                screen.draw.rect(ramen.rect, (255,0, 0, 100))
            screen.draw.rect(water.rect, (255, 0, 0, 100)) #Debugするときは消して
            if title == False:
                if gauge_mode == False and hajime == False:
                    screen.draw.text("狙いを定めてクリック",(200,100),fontname="in_game.ttf",color="red",fontsize=50)
            if angle_mode == False or stage == 1:
                men_kyori = random_x + ((random_number - 1) * 600)
                screen.draw.text("麺まであと"+ str(men_kyori) + "m",(400,0),fontname="in_game.ttf",color="blue",fontsize=30)
                if men_kyori <= 1000:
                    screen.draw.text("<近い>",(400,40),fontname="in_game.ttf",color="red",fontsize=30)
                elif men_kyori >= 1001 and men_kyori <= 1500:
                    screen.draw.text("<ほどほどの距離>",(400,40),fontname="in_game.ttf",color="red",fontsize=30)
                else:
                    screen.draw.text("<遠い>",(400,40),fontname="in_game.ttf",color="red",fontsize=30)
            else:
                if hajime == True and owari == False and stage > 0:
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
                if men_kyori <= 1000:
                    screen.draw.text("←このくらい",(570,400),fontname="in_game.ttf",color="black",fontsize=20)
                elif men_kyori >= 1001 and men_kyori <= 1500:
                    screen.draw.text("←このくらい",(570,250),fontname="in_game.ttf",color="black",fontsize=20)
                else:
                    screen.draw.text("←このくらい",(570,120),fontname="in_game.ttf",color="black",fontsize=20)
            if angle_mode == True and owari == True and re_flg == False:
                kiroku2 = kiroku - men_kyori
                if kiroku2 < 0:
                    kiroku2 *= -1
                if water_flg == True:
                    water.draw()
                    screen.draw.filled_rect(Rect((100, 100), (500, 500)), (255, 255, 255))
                    screen.draw.rect(Rect((100, 100), (500, 500)), (0, 0, 0))
                    men_value = int(kiroku_value)  
                    if font_value > int(kiroku):
                        if water.rect.colliderect(ramen.rect) and stage == random_number:
                            men_value = 0
                            Kekka(1)
                            music_flg = 1
                    if kiroku_value >= kiroku2 and font_value >= int(kiroku):
                        if kiroku2 >= 100 and kiroku2 <= 599:
                            Kekka(2)
                            music_flg = 2
                        if kiroku2 >= 600 and kiroku2 <= 1000:
                            Kekka(3)
                            music_flg = 3
                        if kiroku2 >= 1001:
                            Kekka(4)
                            music_flg = 4
                        if kiroku2 <= 99 and kiroku2 >= 1:
                            Kekka(5)
                            music_flg = 5
                    elif kiroku_value >= kiroku2 and font_value <= int(kiroku) and mainasu < 0:
                        if kiroku2 >= 100 and kiroku2 <= 599:
                            Kekka(2)
                            music_flg = 2
                        if kiroku2 >= 600 and kiroku2 <= 1000:
                            Kekka(3)
                            music_flg = 3
                        if kiroku2 >= 1001:
                            Kekka(4)
                            music_flg = 4
                        if kiroku2 <= 99 and kiroku2 >= 1:
                            Kekka(5)
                            music_flg = 5
                screen.draw.text("結果発表",(212,130),fontname="in_game.ttf",color = 'black',fontsize=60)
                screen.draw.text("結果発表",(210,130),fontname="in_game.ttf",color = 'red',fontsize=60)
                screen.draw.text("飛行距離" + str(font_value) + "m",(210,250),fontname="in_game.ttf",color="blue",fontsize=35)
                clock.tick(2)
                screen.draw.text("麺との距離" + str(int(men_value)) + "m",(210,330),fontname="in_game.ttf",color="red",fontsize=35)
                #Buttonkun5.__init__(260,580,"リトライ？",5)
                #Buttonkun5.draw()
        else:
            if title == False and times > 0:
                screen.draw.text("覚悟を見せろ",(120,150),fontname="title.ttf",color="black",fontsize=60)
                screen.draw.text("覚悟を見せろ",(118,150),fontname="title.ttf",color="red",fontsize=60)
    else:
        ca_ue.scale = 0.35
        ca_ue.draw()
        taiya.scale = 0.35
        taiya.draw()
        ru_ru.draw()
        Buttonkun4.__init__(260,520,"タイトルへ",4)
        Buttonkun4.draw()
    if music_flg == 1 and title == True:
        screen.draw.text("字幕：お前はなかなか見込みがある",(30,610),fontname="title.ttf",color="black",fontsize=40)
        screen.draw.text("字幕：お前はなかなか見込みがある",(28,610),fontname="title.ttf",color="red",fontsize=40)
    else:
        if music_flg == 2 and title == True:
            screen.draw.text("字幕：結構悪くはないと思うよ",(30,610),fontname="title.ttf",color="black",fontsize=40)
            screen.draw.text("字幕：結構悪くはないと思うよ",(28,610),fontname="title.ttf",color="red",fontsize=40)
        else:
            if music_flg == 3 and title == True:
                screen.draw.text("字幕：まあ、気にするな。そういう時もあるよ",(30,610),fontname="title.ttf",color="black",fontsize=30)
                screen.draw.text("字幕：まあ、気にするな。そういう時もあるよ",(28,610),fontname="title.ttf",color="red",fontsize=30)
            else:
                if music_flg == 4 and title == True:
                    screen.draw.text("字幕：まるでやる気が感じられない",(30,610),fontname="title.ttf",color="black",fontsize=40)
                    screen.draw.text("字幕：まるでやる気が感じられない",(28,610),fontname="title.ttf",color="red",fontsize=40)
                else:
                    if music_flg == 5 and title == True:
                        screen.draw.text("字幕：あともうちょっと",(120,610),fontname="title.ttf",color="black",fontsize=40)
                        screen.draw.text("字幕：あともうちょっと",(118,610),fontname="title.ttf",color="red",fontsize=40)
    kasoru.scale = 0.125
    kasoru.draw()

def on_mouse_move(pos):
    global mouse_x2,mouse_y2
    mouse_y2 = pos[1]
    mouse_x2 = pos[0]
    
pgzrun.go()
