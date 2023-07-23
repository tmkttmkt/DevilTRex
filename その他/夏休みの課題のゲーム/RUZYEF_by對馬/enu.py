from enum import Enum
class cldt(Enum):
    mu=(0,0,0)
    plains=(0,255,0)
    river=(0,128,255)
    rail=(32,32,32)
    road=(128,64,0)
    woods=(0,128,0)
    urban=(128,128,128)
class goal(Enum):
    move=1
    speed_move=2
    fire=3
    defense=4
class title_mode(Enum):
    START=0
    execution=1
    CONTINUATION=2
    EXPLANATION=3

