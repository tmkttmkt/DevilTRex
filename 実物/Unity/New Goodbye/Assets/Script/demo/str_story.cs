using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StoryText
{
    public string text;
    public string charcter;
    public float time;
}
public class str_story : MonoBehaviour
{
    nokori nk;
    suizyak cr_sui;
    // Start is called before the first frame update
    void Start()
    {
        nk = FindObjectOfType<nokori>();
        cr_sui = gameObject.GetComponent<suizyak>();
        StartCoroutine(start_ibent());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator start_ibent()
    {
        nk.set_text("ほんとに何があったんだろう、気づい\nたら手持ちもなくなっている。\n電話もできない。");

        nk.set_katari("高橋");
        nk.set_text("ココはいいったいどこだ？ゲームの\n中とは言われたものの...\nって何にこの絵画wwだっさww");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("？？？");
        nk.set_text("クックックッ");
        yield return new WaitForSeconds(1.0f);

        nk.set_katari("？？？");
        nk.set_text("ココココ");
        yield return new WaitForSeconds(1.0f);

        nk.set_katari("？？？");
        nk.set_text("キキッキキッ");
        yield return new WaitForSeconds(1.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("私はこのゲームの守り神だ");
        yield return new WaitForSeconds(3.0f);

        nk.set_katari("高橋");
        nk.set_text("え？髪...ああ紙か、まあお前ら\n2Dだしな、薄っぺらい存在だしな");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("だれの人間性が薄っぺらいだって\n泣いちゃうぞ？大のティラノが\n泣いちゃうぞ");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("高橋");
        nk.set_text("そんなことはどうでもいいんだよ\n二人の男の子がこのゲームの中\nのどこにいるのか教えてくれ、失敗作");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("もう狂った教授の部下というわけ\nではないがただで教えるという\nわけにはいかない");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("こっちは暇で暇でしょうがないんだ\nこの二次元体だと腹も好かない\nから人を襲う気もないんだ");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("高橋");
        nk.set_text("どうすればいいんだｗこっちには\n二人の命wwがかかってるんだw\n暴力だって辞さないぞ");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("ギャンブルッ...不合理に身を\nゆだねる狂気の沙汰ほど面白い");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("高橋");
        nk.set_text("俺の特技はギャンブルと肉体言語\nなんだぜｗｗやってやろうじゃん");
        yield return new WaitForSeconds(4.0f);
        cr_sui.Active_flg();
    }
}
