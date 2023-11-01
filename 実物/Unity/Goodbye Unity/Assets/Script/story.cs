using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{
    [SerializeField] private GameObject start;
    [SerializeField] private time ti;
    private string serihu;
    private int dannraku; 
    private int serihubamenn;
    private int iventID=0;
    // Start is called before the first frame update
    void Start()
    {
        ti.set_goal("学校に入ろう");
        ti.set_text("すごく学校に入りたい");
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    void OnCollisionEnter(Collision collision)
    {
        if (iventID == 0)
        {
            if (collision.gameObject == start)
            {
                Debug.Log("次の段階に!!");
                iventID = 1;
                StartCoroutine(start_ibent());
            }
        }
    }

    IEnumerator start_ibent()
    {
        transform.position = new Vector3(67.74f, 21.38f, 80.149f);
        ti.set_text("いったい何があったんだ、青木は?\n佐々木は？みんなどこ行ったんだ！");
        yield return new WaitForSeconds(8.0f);
        ti.set_text("気づいたら知らない場所に飛ばされ\nていた、意味が分からない。・・・・");
        yield return new WaitForSeconds(8.0f);
        ti.set_text("ほんとに何があったんだろう、築い\nたら手持ちもなくなっている。\n電話もできない。");
        yield return new WaitForSeconds(8.0f);
        ti.set_text("仕方がない、ここの建物がどこにあ\nるのかを知れるものでも探すか。\nおそらくこれは緊急事態だ");
        yield return new WaitForSeconds(8.0f);
        ti.set_text("どこかに地図のようなものはないだ\nろうか急がねば・・・・・・");
        ti.set_goal_only("地図を探そう");
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
