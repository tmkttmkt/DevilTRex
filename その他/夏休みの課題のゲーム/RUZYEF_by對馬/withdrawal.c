#include "pas.h"
#define HABA 600

int withdrawal_func(int * date,int y_lan,int loc_x,int loc_y,int *out,int n) {
    const int arry[16][2]={{1,1},{2,1},{1,2},
                        {-1,1},{-2,1},{-1,2},
                        {1,-1},{2,-1},{1,-2},
                        {-1,-1},{-2,-1},{-1,-2},
                        {1,0},{-1,0},{0,1},{0,-1},};
    int nokori=1;
    struct pas *sen;
    struct pas *naw,*new,*last;
    struct pas *top;
    float cost=0;
    float point_cost;
    int tot_x,tot_y;
    int i,m=0;
    float pos_x=0,pos_y=0;
    int *date_start=date;
    float *cost_map,*at_cost_map;
    double time1,time2;
    printf("a");
    time1=(double)clock() / CLOCKS_PER_SEC;
    cost_map=(float *)malloc(sizeof(float) * (HABA+1) * (HABA+1));
    sen = (struct pas*)malloc(sizeof(struct pas) * (HABA+1) * (HABA+1)*2);
    if(sen==NULL ||  cost_map==NULL){
        free(sen);
        free(cost_map);
        return -3;
    }
    at_cost_map=cost_map;
    for(i=0;i<(HABA+1) * (HABA+1);i++){
        *at_cost_map=9999.9;
        at_cost_map++;
    }
    printf("a");
    at_cost_map=cost_map;

    naw=new=last=top=sen;
    while(n>m){
        pos_x+=*out;
        out++;
        pos_y+=*out;
        out++;
        m++;
    }
    
    printf("a");
    pos_x/=n;
    pos_y/=n;
    naw->pos[0]=loc_x;
    naw->pos[1]=loc_y;
    naw->cost=cost;
    naw->yte=-sqrtf((loc_x-pos_x)*(loc_x-pos_x)+(loc_y-pos_y)*(loc_y-pos_y));
    time2=(double)clock() / CLOCKS_PER_SEC;
    printf("c %f\n",time2-time1);
    time1=(double)clock() / CLOCKS_PER_SEC;
    while(nokori>0){
        naw=next_point_tree(&top);
        //printf("\n|%d,%d,%d|%d,%d|\n",top-sen,naw-sen,nokori,naw->pos[0],naw->pos[1]);
        cost=naw->cost;
        tot_x=naw->pos[0];
        tot_y=naw->pos[1];
        last++;
        nokori--;
        for(i=0;i<16;i++){
            tot_x+=arry[i][0];
            tot_y+=arry[i][1];
            if(tot_x-loc_x<-HABA/2 || tot_y-loc_y<HABA/2 || tot_x-loc_x>HABA/2 || tot_y-loc_y>HABA/2){
                tot_x-=arry[i][0];
                tot_y-=arry[i][1];
                continue;
            }
            date=date_start+tot_x+tot_y*y_lan;
            cost_map=at_cost_map+(tot_x-loc_x-HABA/2)+(tot_x-loc_x-HABA/2)*(HABA+1);
            //0mu 1heiya 2kawa 3tetudou 4douro 5mori 6mati
            point_cost=1.0;
            if(*date==1)point_cost=1.0;
            else if(*date==2)point_cost=20.0;
            else if(*date==3)point_cost=0.5;
            else if(*date==4)point_cost=0.5;
            else if(*date==5){
                    new->pos[0]=tot_x;
                    new->pos[1]=tot_y;
                    new->mae=naw;
                    nokori=0;
                    break;
            }
            else if(*date==6){
                    new->pos[0]=tot_x;
                    new->pos[1]=tot_y;
                    new->mae=naw;
                    nokori=0;
                    break;
            }
            else continue;
            cost+=sqrtf(arry[i][1]*arry[i][1]+arry[i][0]*arry[i][0])*point_cost;
            if(tot_x==pos_x && tot_y==pos_y){
            }
            if(new==sen+(HABA/2+1)*(HABA/2+1)*10-1){
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
                new->mae=naw;
                naw->yte=-sqrtf((tot_x-pos_x)*(tot_x-pos_x)+(tot_y-pos_y)*(tot_y-pos_y));
                if (sqrtf((tot_x-pos_x)*(tot_x-pos_x)+(tot_y-pos_y)*(tot_y-pos_y))>300){
                    nokori=0;
                    break;
                }
                tree(new,top);
                nokori++;
            }
            cost-=sqrtf(arry[i][1]*arry[i][1]+arry[i][0]*arry[i][0])*point_cost;
            tot_x-=arry[i][0];
            tot_y-=arry[i][1];
        }
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
    return i;
}
