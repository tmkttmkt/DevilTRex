import numpy as np
cimport numpy as np
from time import time
cdef extern from "move.c":
    int func(int *,int,int,int,int)


def call_move_func(np.ndarray[np.int32_t, ndim=2] date,loc,pos,pov):
    print("a")
    cdef:
        int loc_x,loc_y,pos_x,pos_y
    loc_x=loc[0]-pov[0]
    loc_y=loc[1]-pov[1]
    pos_x=pos[0]-pov[0]
    pos_y=pos[1]-pov[1]
    start=time()
    cdef int[:] date_list1= date[pov[0]:pov[0]+900, pov[1]:pov[1]+900].ravel()
    print(time()-start)
    start=time()
    num=func(&date_list1[0],loc_x,loc_y,pos_x,pos_y)
    print(time()-start)
    start=time()
    lis=[]
    if num>0:
        lis=np.array(date_list1[:num*2]).reshape(-1,2)
    print()
    print(num,lis)
    print(time()-start)
    return lis