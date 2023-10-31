using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{
    [SerializeField] private time ti;
    private string serihu;
    private int dannraku,serihubamenn,iventID; 
    // Start is called before the first frame update
    void Start()
    {
        iventID = 1;
        serihu = "いったい何があったんだ、青木は？　佐々木は？みんなどこ行ったんだ！";
        ti.set_text(serihu);
        StartCoroutine(start_ibent());
        map_ibent();
        key_ibent();
        syeruta_ibent();
        denngonn_ibent();
        deguti_ibent();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    IEnumerator start_ibent()
    {
        ti.set_text("いったい何があったんだ、青木は?\n\n佐々木は？みんなどこ行ったんだ！");
        yield return new WaitForSeconds(8.0f);
        ti.set_text("気づいたら知らない場所に飛ばされ\n\nていた、意味が分からない。・・・・");
        yield return new WaitForSeconds(8.0f);
        ti.set_text("ほんとに何があったんだろう、築い\n\nたら手持ちもなくなっている。\n\n電話もできない。");
        yield return new WaitForSeconds(8.0f);
        ti.set_text("仕方がない、ここの建物がどこにあ\n\nるのかを知れるものでも探すか。\n\nおそらくこれは緊急事態だ");
        yield return new WaitForSeconds(8.0f);
        ti.set_text("どこかに地図のようなものはないだ\n\nろうか急がねば・・・・・・");
    }
    private void map_ibent()

    {
    }
    private void key_ibent()
    {
    }
    private void syeruta_ibent()
    {
    }
    private void denngonn_ibent()
    {
    }
    private void deguti_ibent()
    {

    }


}
