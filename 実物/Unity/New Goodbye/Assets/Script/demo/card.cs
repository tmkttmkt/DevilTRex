using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class card : MonoBehaviour
{
    int id;
    bool flg = false;
    Image img;
    Sprite ura;
    suizyak game;
    public void id_flg(int num)
    {
        id = num;
    }
    public void pls_img(Image imageComponent)
    {
        img = imageComponent;
    }
    public void pls_game(suizyak inputgame)
    {
        game = inputgame;
    }
    public void pls_sprite(Sprite inputura)
    {
        ura = inputura;
    }
    public void del()
    {
        this.gameObject.SetActive(false);
    }
    public void tozi()
    {
        img.sprite = ura;
        flg = false;

    }
    public void OnImageButtonClick(PointerEventData eventData)
    {
        if (game.hyuzi_kazu.Count == 0 || game.hyuzi_kazu.Count == 1)
        {
            if (!flg)
            {
                img.sprite = Resources.Load<Sprite>("defrt/saisyu/torannpu-illust" + (id+52-13));
                game.add_hyou(id,this);
                flg =true;
            }
        }
    }
}
