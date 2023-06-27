class ESC:
    def __init__(self):
        self.start=Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2],[240,60],"START")
        self.conit=Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2+70],[240,60],"CONTINUATION")
        self.exp=Buttan((64,64,64),[WIDTH/2-120,HEIGHT/2+140],[240,60],"EXPLANATION")
    def draw(self):
        self.start.draw()
        self.conit.draw()
        self.exp.draw()
    def mouse_down(self,pos,key):
        if self.start.collidepoint(pos,key):
            return 1
        elif self.conit.collidepoint(pos,key):
            return 2
        elif self.exp.collidepoint(pos,key):
            return 3
