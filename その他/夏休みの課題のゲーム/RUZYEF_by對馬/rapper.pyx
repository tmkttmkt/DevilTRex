import numpy as np
cimport numpy as np
from time import time
cdef extern from "move.c":
    int func(int *,int,int,int,int)


def call_move_func(np.ndarray[np.int32_t, ndim=2] date,loc,pos,pov):
    cdef:
        int loc_x,loc_y,pos_x,pos_y
    start=time()
    loc_x=loc[0]-pov[0]
    loc_y=loc[1]-pov[1]
    pos_x=pos[0]-pov[0]
    pos_y=pos[1]-pov[1]
    cdef int[:] date_list1= date[pov[0]:pov[0]+900, pov[1]:pov[1]+900].ravel()
    print(" ",time()-start)
    start=time()
    num=func(&date_list1[0],loc_x,loc_y,pos_x,pos_y)
    print(" ",time()-start)
    start=time()
    lis=[]
    if num>0:
        lis=np.flipud(np.array(date_list1[:num*2]).reshape(-1,2))
        print(lis)
        ind=len(lis)-1
        while ind>=0:
            lis[ind][0]-=lis[ind-1][0]
            lis[ind][1]-=lis[ind-1][1]
            ind-=1
        lis[0][0]-=loc_x
        lis[0][1]-=loc_y
    print(lis)
    #print(num)
    print(" ",time()-start)
    return lis