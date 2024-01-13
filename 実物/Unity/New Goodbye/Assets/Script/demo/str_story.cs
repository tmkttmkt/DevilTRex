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
    [SerializeField] public StoryText[] st;
    nokori nk;
    // Start is called before the first frame update
    void Start()
    {
        nk=FindObjectOfType<nokori>();
        StartCoroutine(start_ibent());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator start_ibent()
    {
        foreach (StoryText tex in st){
            nk.set_text(tex.text);
            nk.set_katari(tex.charcter);
            yield return new WaitForSeconds(tex.time);
        }
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
        yield return new WaitForSeconds(1.0f);

        nk.set_katari("高橋");
        nk.set_text("え？髪...ああ紙か、まあお前ら\n2Dだしな、薄っぺらい存在だしな");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("高橋");
        nk.set_text("だれの人間性が薄っぺらいだって");
        yield return new WaitForSeconds(6.0f);

        nk.set_katari("T-rex");
        nk.set_text("どこかに地図のようなものはないだ\nろうか急がねば・・・・・・");
        yield return new WaitForSeconds(4.0f);
    }
}
