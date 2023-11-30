using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject start_kabe;
    [SerializeField] private time ti;
    private musi mus;
    private string serihu;
    private int dannraku; 
    private int serihubamenn;
    public int iventID=0;
    // Start is called before the first frame update
    void Start()
    {
        mus = FindObjectOfType<musi>();
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

                iventID = 1;
                StartCoroutine(start_ibent());
                start_kabe.SetActive(true);


            }
        }
    }
    public void map_flg()
    {
        if (iventID == 2)
        {
            iventID = 3;
            StartCoroutine(map_ibent());
        }
    }
    public void key_flg()
    {
        if (iventID == 4)
        {
            iventID = 5;
            StartCoroutine(key_ibent());
        }
    }
    
    public void syeruta_flg()
    {
        if (iventID == 6)
        {
            iventID = 7;
            StartCoroutine(syeruta_ibent());
        }
    }
    public void denngonn_flg()
    {
        if (iventID == 8)
        {
            iventID = 9;
            StartCoroutine(denngonn_ibent());
        }
    }
    IEnumerator start_ibent()
    {
        mus.kihon_flg();
        transform.position = new Vector3(67.74f, 21.38f, 80.149f);
        ti.set_text("いったい何があったんだ、青木は?\n佐々木は？みんなどこ行ったんだ！");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("気づいたら知らない場所に飛ばされ\nていた、意味が分からない。・・・・");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("ほんとに何があったんだろう、築い\nたら手持ちもなくなっている。\n電話もできない。");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("仕方がない、ここの建物がどこにあ\nるのかを知れるものでも探すか。\nおそらくこれは緊急事態だ");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("どこかに地図のようなものはないだ\nろうか急がねば・・・・・・");
        yield return new WaitForSeconds(4.0f);
        ti.set_goal_only("地図を探そう");
        iventID = 2;
    }
    IEnumerator map_ibent()
    {

        ti.set_text("こんなところに、ハザードマップ\nが張られてある、おそらくこの\n建物は探索した感じ、学校のようだ");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("ただ学校の位置を地図で確かめた\n感じ、おそらく佐々木たちがいる\n場所とは違う所にいる・・");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("しかも巨大な音？足音？、変な音\nが聞こえる。誰かいるのだろうか、\nでも人間の足音のようには聞こえない");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("ん？何か文章が書かれてある、\nこの建物から出たければ。\nカギを見つけろ");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("カギ・・・・・それらしきものでも\n探してみるか？・・・\nまるで俺の立場を知っているかのような文章だ・・");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("なんだろう、落書きかとも思ったが\nそのようには見えない。");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("おそらく何かの伝言かもしれない、\n期待はしないが参考にし\nて探索してみよう");
        yield return new WaitForSeconds(4.0f);
        ti.set_goal_only("鍵を探そう");

        iventID = 4;
    }
    IEnumerator key_ibent()
    {
        ti.set_text("この、二つのパーツ、もしかして、\n同じ鍵のパーツなんだろうか？");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("上手く組み合わせれば、新しいアイ\nテムが作れるかもしれない");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("二つのアイテムをくっつけてみよう\nかな？、そしたら、何かの手掛かりが\n見つかるかもしれない");
        yield return new WaitForSeconds(4.0f);
        ti.set_goal_only("２階につながる階段へ向かおう");
        iventID = 6;
    }
    IEnumerator syeruta_ibent()
    {
        ti.set_text("あ！、シェルターらしきかべが\nさっき合成させた、鍵を使ったら\n開いたぞ！");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("あれは、シェルターの鍵だったのか\nずいぶん変わったもんだ・・・\nとりあえずシェルターの奥は\nどうなっているんだろう・・・");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("どうやら下の階につながっている\nみたいだ・・・・・この先に行け\nば出口でもあるのだろうか\n・・・・・いそいで探索してみよう！");
        yield return new WaitForSeconds(4.0f);
        ti.set_goal_only("1階2階を探索してみよう");
        iventID = 8;
    }
    IEnumerator denngonn_ibent()
    {
        ti.set_text("なんだろう何かの紙切れがある。\n！？これは、この字は、青木、佐々木の字？!");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("これは、青木、佐々木、の伝言!?\nなんて書いてあるんだろう・・・・\n「ごめん高橋・・俺らはお前をとん\nでもない目に巻き込ませてしまったかも\nしれない・・・・");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("これはうわさを信じなかった俺ら\nの責任だ。実はこの屋敷には。過去に\n実在した、巨大生物の幽霊がうろ追って\nいるという噂があった");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("それを俺らはうのみにしなかった\nただ二人より3人いたほうが心強いと\n思ってお前、高橋を誘いったんだ");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("しかもこの屋敷のうわさはもう一\nつあるんだ、それは建物に入った瞬間\nに。一緒にいた人とはぐれてしまうという噂だ、");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("もしお前が生きていたら、ここに\n書いた文章をよく目に刻んでくれ。出口\nは1階にある");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("そして、この屋敷にはうわさが正\nしければ必ずカギを開けるためのカギがある\nはずなんだ。それを見つけたら急いで出口に\n迎え、そしたら・・・・・・」");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("文章はここで切れている。なるほ\nど、俺があの時に止めていれば。くそ！\n伝言が書かれた紙には佐々木と、青木の\nものと思われる血がついている");
        yield return new WaitForSeconds(4.0f);
        ti.set_text("鍵・・を見つけたらと書いてあった\nうわさが正しければ必ずあるはず。。か\n・・とにかく急ごう！、深く考えている\n暇はない・・・");
        yield return new WaitForSeconds(4.0f);
        ti.set_goal_only("鍵を探そう");
        iventID = 10;

    }
    IEnumerator deguti_ibent()
    {
        ti.set_text("あ！！、鍵を手に入れることが\nできた、おそらくこれは出口の鍵脱出しよう\n、脱出しよう！！！！！！！！！！");
        yield return new WaitForSeconds(4.0f);
        ti.set_goal_only("脱出しよう");
    }


}
