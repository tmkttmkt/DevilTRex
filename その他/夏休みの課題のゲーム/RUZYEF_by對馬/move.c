#include <stdio.h>
#include <time.h>
struct pas
{
        int pos[2];
        int cost;
        int yte;
        struct pas *oya;
        struct pas *R_ko;
        struct pas *L_ko;
        struct pas *mae;
        
        
};
int func(int * date,int loc_x,int loc_y,int pos_x,int pos_y) {
    const int arry[16][2]={{1,1},{-1,1},{1,-1},{-1,-1},{1,0},{-1,0},{0,1},{0,-1},
                        {2,1},{1,2},{-2,1},{-1,2},{2,-1},{1,-2},{-2,-1},{-1,-2}};
    int nokori=1;
    struct pas *sen;
    struct pas *naw,*new;
    int cost=0;
    float point_cost;
    int tot_x,tot_y;
    int i;
    int cost_map[900][900];
    memset(cost_map, 9999, sizeof(cost_map));
    sen = (struct pas*)malloc(sizeof(struct pas) * 900 * 900);
    if(sen==NULL ||  cost_map==NULL)return -3;
    if(loc_x==pos_x&&loc_y==pos_y){
        return -1;
    }
    naw->pos[0]=loc_x;
    naw->pos[1]=loc_y;
    naw->cost=cost;
    naw->yte=(loc_x-pos_x)*(loc_x-pos_x)+(loc_y-pos_y)*(loc_y-pos_y);
    new++;
    while(nokori>0){
        naw=next_point();
        cost=naw->cost;
            tot_x=naw->pos[0];
            tot_y=naw->pos[1];
            for(i=0;i<16;i++){
                new++;
                tot_x+=arry[i][0];
                tot_y+=arry[i][1];
                point_cost=1.0;
                if(cost_map[tot_y][tot_y]==4)point_cost=2.0;
                else if(cost_map[tot_y][tot_y]==2)point_cost=10.0;
                cost=(arry[i][1]*arry[i][1]+arry[i][0]*arry[i][0])*point_cost;
                if(tot_x==pos_x && tot_y==pos_y){
                        nokori=0;
                        break;
                }
        }
    }
    return 0;
}
    struct pas *next_point(){

    }