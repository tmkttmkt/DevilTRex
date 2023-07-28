#include <stdio.h>
#include <time.h>
#include <math.h>
struct pas
{
        int pos[2];
        float cost;
        float yte;
        struct pas *oya;
        struct pas *R_ko;
        struct pas *L_ko;
        struct pas *mae;
        
        
};
struct pas *next_point(struct pas *,int);
void tree(struct pas *);
double point_time=0.0;

int func(int * date,int loc_x,int loc_y,int pos_x,int pos_y) {
    const int arry[16][2]={{1,1},{-1,1},{1,-1},{-1,-1},{1,0},{-1,0},{0,1},{0,-1},
                        {2,1},{1,2},{-2,1},{-1,2},{2,-1},{1,-2},{-2,-1},{-1,-2}};
    int nokori=1;
    struct pas *sen;
    struct pas *naw,*new,*last;
    float cost=0;
    float point_cost;
    int tot_x,tot_y;
    int i;
    int *date_start=date;
    int *cost_map,*at_cost_map;
    double time1,time2;
    double time,kitaku_time=0.0;
    point_time=0.0;
    time1=(double)clock() / CLOCKS_PER_SEC;
    if(loc_x==pos_x&&loc_y==pos_y){
        return -1;
    }
    cost_map=(int *)malloc(sizeof(int) * 900 * 900);
    sen = (struct pas*)malloc(sizeof(struct pas) * 900 * 900*10);
    if(sen==NULL ||  cost_map==NULL){
        free(sen);
        free(cost_map);
        return -3;
    }
    memset(cost_map, 9999,sizeof(int) * 900 * 900);
    at_cost_map=cost_map;

    naw=new=last=sen;
    naw->pos[0]=loc_x;
    naw->pos[1]=loc_y;
    naw->cost=cost;
    naw->yte=sqrtf((loc_x-pos_x)*(loc_x-pos_x)+(loc_y-pos_y)*(loc_y-pos_y));
    time2=(double)clock() / CLOCKS_PER_SEC;
    printf("c %f\n",time2-time1);
    time1=(double)clock() / CLOCKS_PER_SEC;
    while(nokori>0){
        naw=next_point(last,nokori);
        time=(double)clock() / CLOCKS_PER_SEC;
        cost=naw->cost;
        tot_x=naw->pos[0];
        tot_y=naw->pos[1];
        last++;
        nokori--;
        for(i=0;i<16;i++){
            tot_x+=arry[i][0];
            tot_y+=arry[i][1];
            if(tot_x<0 || tot_y<0 || tot_x>=900 || tot_y>=900){
                tot_x-=arry[i][0];
                tot_y-=arry[i][1];
                continue;
            }
            date=date_start+tot_x+tot_y*900;
            cost_map=at_cost_map+tot_x+tot_y*900;
            point_cost=1.0;
            if(*date==4)point_cost=2.0;
            else if(*date==2)point_cost=10.0;
            cost+=sqrtf(arry[i][1]*arry[i][1]+arry[i][0]*arry[i][0])*point_cost;
            if(tot_x==pos_x && tot_y==pos_y){
                    new->pos[0]=tot_x;
                    new->pos[1]=tot_y;
                    new->mae=naw;
                    nokori=0;
                    break;
            }
            if(new==sen+900*900*10-1){
                free(sen);
                free(cost_map);
                return -2;
            }
            if(*cost_map>cost){
                *cost_map=cost;
                new++;
                new->pos[0]=tot_x;
                new->pos[1]=tot_y;
                new->cost=cost;
                new->yte=sqrtf((tot_x-pos_x)*(tot_x-pos_x)+(tot_y-pos_y)*(tot_y-pos_y));
                new->mae=naw;
                nokori++;
            }
            cost-=sqrtf(arry[i][1]*arry[i][1]+arry[i][0]*arry[i][0])*point_cost;
            tot_x-=arry[i][0];
            tot_y-=arry[i][1];
        }
        kitaku_time+=(double)clock() / CLOCKS_PER_SEC;
        kitaku_time-=time;
    }
    time2=(double)clock() / CLOCKS_PER_SEC;
    printf("c %f\n",time2-time1);
    time1=(double)clock() / CLOCKS_PER_SEC;
    i=0;
    date=date_start;
    cost_map=at_cost_map;
    do{
        *date=new->pos[0];
        date++;
        *date=new->pos[1];
        date++;
        i++;
        new=new->mae;
    }while(new != sen);
    free(cost_map);
    free(sen);
    time2=(double)clock() / CLOCKS_PER_SEC;
    printf("c %f\n",time2-time1);
    printf("cc%f\ncc%f\n",point_time,kitaku_time);
    return i;
}
    void tree(struct pas *new){

    }
    struct pas *next_point(struct pas *last,int num)
        {
            struct pas *point=last,*exm=last;
            struct pas box;
            double time;
            time=(double)clock() / CLOCKS_PER_SEC;
            for(int i=1;i<num;i++){
                point++;
                if(point->yte+point->cost < exm->yte+exm->cost){
                    exm=point;
                }
                else if(point->yte+point->cost == exm->yte+exm->cost){
                    if(point->yte < exm->yte)exm=point;
                }
            }
            box=*last;
            *last=*exm;
            *exm=box;
            point_time+=(double)clock() / CLOCKS_PER_SEC;
            point_time-=time;
            return last;
    }