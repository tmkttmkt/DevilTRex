using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    bool iro_flg = false;
    int n = 0;
    // Start is called before the first frame update
    [SerializeField] Text text;
    [SerializeField] GameObject gg1;
    [SerializeField] GameObject gg2;
    void Start()
    {
        nk = FindObjectOfType<nokori>();
        cr_sui = FindObjectOfType<suizyak>();
        StartCoroutine(start_ibent());
    }

    // Update is called once per frame
    void Update()
    {
        if (iro_flg)
        {
            n++;
            if (n == 6)
            {
                text.color = new Color(Random.value, Random.value, Random.value, 1.0f);
                n = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            fin();
        }
    }
    public void fin()
    {
        iro_flg = true;
        gg1.SetActive(true);
        gg2.SetActive(true);
        StartCoroutine(fin_ibent());
    }
    IEnumerator fin_ibent()
    {

        nk.set_katari("高橋");
        nk.set_text("勝ったので教えてくれ");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("教えるの面倒なので連れていくで");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("おらよっと");
        yield return new WaitForSeconds(2.0f);

        nk.flg_win();

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
        nk.set_text("だれの人間性がぺらっぺらだって\n泣いちゃうぞ？大のティラノが\n泣いちゃうぞ");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("高橋");
        nk.set_text("飴あげるから泣くなよ\nそれより二人の男の子がこのゲームの中\nのどこにいるのか教えてくれ、失敗作");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("もう狂った教授の支配下というわけ\nではないが\n教えないね");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("こちとらは暇で暇でしょうがないんだ\nこの二次元体だと腹もすかない\nだから人を襲う気も起こらないんだ");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("高橋");
        nk.set_text("知ったことかよｗこっちには\n二人の命wwがかかってるんだw\n暴力だってww辞さないぞォ！");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("ギャンブルッ...不合理に身を\nゆだねる狂気の沙汰ほど面白い");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("高橋");
        nk.set_text("俺の特技はギャンブルと肉体言語\nなんだぜｗｗやってやろうじゃん");
        yield return new WaitForSeconds(4.0f);
        //cr_sui.Active_flg();

        nk.set_katari("ゼロ号");
        nk.set_text("ックックック、今回は神経衰弱(†Nerve Weakness And Dead†)で\n勝負しよう、数回で開けれたら君の勝ちだ");
        yield return new WaitForSeconds(4.0f);

        nk.set_katari("ゼロ号");
        nk.set_text("せっかくだからな。\n興が冷めないようにヒントもやるよ");
        yield return new WaitForSeconds(3.0f);

        cr_sui.Active_flg();
    }
    IEnumerator restart_ibent()
    {
        nk.set_katari("ゼロ号");
        nk.set_text("ックックック、今回は神経衰弱(†Nerve Weakness And Dead†)で\n勝負しよう、数回で開けれたら君の勝ちだ");
        yield return new WaitForSeconds(4.0f);
    }
}
