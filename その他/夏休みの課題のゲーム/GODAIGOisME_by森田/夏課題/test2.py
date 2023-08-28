import pgzrun

class Rectangle:
    def __init__(self, x, y, width, height, color):
        self.x = x
        self.y = y
        self.width = width
        self.height = height
        self.color = color

    def draw(self):
        screen.draw.filled_rect(Rect(self.x, self.y, self.width, self.height), self.color)

rectangles = []

def update():
    pass

def draw():
    screen.clear()
    for rect in rectangles:
        rect.draw()

def on_mouse_down(pos, button):
    if button == mouse.LEFT:
        new_rect = Rectangle(pos[0], pos[1], 50, 50, (255, 0, 0))
        rectangles.append(new_rect)

def on_mouse_move(pos, rel, buttons):
    for rect in rectangles:
        if rect.x <= pos[0] <= rect.x + rect.width and rect.y <= pos[1] <= rect.y + rect.height:
            print("Mouse is over a rectangle:", rect.x, rect.y)

pgzrun.go()
