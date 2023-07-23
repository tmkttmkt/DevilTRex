import rapper
import numpy as np 
import random as rd
date=np.array([[rd.randint(0,10) for i in range(1100)] for j in range(1100)])
rapper.call_move_func(date,(10,10),(0,0))