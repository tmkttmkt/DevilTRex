import numpy as np
cimport numpy as np
from time import time
cdef extern from "move.c":
    int func(int *,int,int,int,int)


def call_move_func(np.ndarray[np.int32_t, ndim=2] date,loc,pos,pov):
    cdef:
        int loc_x,loc_y,pos_x,pos_y
    loc_x=loc[0]-pov[0]
    loc_y=loc[1]-pov[1]
    pos_x=pos[0]-pov[0]
    pos_y=pos[1]-pov[1]
    """
    start=time()
    cdef np.ndarray[np.int32_t, ndim=2] date_list2=np.zeros((900, 900), dtype=np.int32)
    for y in range(900):
        for x in range(900):
            date_list2[y,x]=date[y,x]
    print(time()-start)
    """
    start=time()
    cdef np.ndarray[np.int32_t, ndim=2] date_list1= date[pov[0]:pov[0]+900, pov[1]:pov[1]+900]
    print(time()-start)
    num=func(*date[0,0],loc_x,loc_y,pos_x,pos_y)
    return []