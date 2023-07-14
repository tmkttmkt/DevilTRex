import pgzrun
import pygame
import os
class Unit(Actor):
    def __init__(self):
        super().__init__('tank_syo',topleft=(100,100))
        self.haba=1
un=Unit()
print(un.x,un.y)
pgzrun.go()
