import pgzrun
import math

WIDTH = 400
HEIGHT = 400

angle = 0  # 初期角度

def update():
    global angle
    angle += 1  # 角度を増やして回転させる

def draw():
    screen.clear()
    
    # 四角形の中心座標とサイズ
    rect_center = (WIDTH // 2, HEIGHT // 2)
    rect_size = (100, 100)
    
    # 四角形の描画座標を計算
    rect_x = rect_center[0] - rect_size[0] // 2
    rect_y = rect_center[1] - rect_size[1] // 2
    
    # 四角形の描画
    screen.draw.filled_rect((rect_x, rect_y, rect_size[0], rect_size[1]), "blue", angle=angle)

pgzrun.go()
