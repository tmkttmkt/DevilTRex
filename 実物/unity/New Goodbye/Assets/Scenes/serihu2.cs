using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class serihu2 : MonoBehaviour
{
    // Start is called before the first frame update{
    public Text displayText;
    public string messageToDisplay = "Hello, World!";
    public int dannraku=0;
    public int mati=0,siraberu=0,dannrakususumistop=0; 
     public GameObject kaiwaowari;
    private Story st;
    private sound sound;
    public Canvas serihucanvas;
    public Texture setumei1,setumei2,home1,home2;
     public Canvas canvas,pasCanvas;
     public Canvas ITEM;
     private syujinnkou syu;
     public GameObject haikei1;
     public RawImage setumei;
     public RawImage RawImage_TAKAHASHI;//表示されているキャラクター（主人公の高橋のイラスト）
     public Texture[] Texture_TAKAHSHI=new Texture[6];//主人公の表情６つ
     public Texture[] Texture_TUSIMA=new Texture[6];//主人公の表情６つ
     public Texture[] Texture_MORITAGO=new Texture[6];//主人公の表情６つ
     public Texture[] Texture_TUSIMARO=new Texture[6];//主人公の表情６つ
     public Texture[] Texture_MORITA=new Texture[6];//主人公の表情６つ
     public Texture[] Texture_TAKATUKA_REX=new Texture[6];//主人公の表情６つ
     public Texture[] Texture_TAKATUKA=new Texture[6];//主人公の表情６つ
     public Texture TAKAHASI2D,setumeida;
     private move move;
     private tatakai t;
     public Vector2 targetPosition;
     public int k,o=0;

     void Start()
    {

        // コルーチンを使ってテキストを表示する
    
        st= FindObjectOfType<Story>();
        sound= FindObjectOfType<sound>();
        syu= FindObjectOfType<syujinnkou>();
        move = FindObjectOfType<move>();
        t = FindObjectOfType<tatakai>();
          
    }
    void Update()
    {
        if(st.storykaunnto==7||st.storykaunnto==6)
        {
           
            if(dannraku==1&&o==0)sound.BGM2_start();
            if(dannraku==4)move.moritagousuto_up();
            if(dannraku==57)
            {
                sound.BGM2_stop();
                sound.pannti1();
                 o=1;
            }

        }
        if(st.storykaunnto==8)
        {            
            if(dannraku==2)sound.BGM2_start();
            if(dannraku==5||dannraku==6) move.tusimaro_up();
            if(dannraku>45) move.tusimaro_down();
           // if(dannraku==1)move.moritagousuto_up();
            //if(dannraku==21)move.moritagousuto_down();
            if(dannraku==47)
            {
                sound.BGM2_stop();
            }
        }
        if(st.storykaunnto==12)
        {
            if(dannraku==2)sound.BGM_morita2();
            if(dannraku==2)sound.pannti1();
                    }
         if(st.storykaunnto==13)sound.BGM_morita2();
         if(st.storykaunnto==14)
         {
            if(dannraku==19)move.tusimaro2.transform.position-=transform.up/10;
         }
         if(st.storykaunnto==15)move.tusimaro2.transform.position-=transform.up/10;
         if(st.storykaunnto==18&&dannraku==3)
         {
            sound.BGM_tusima2();
            sound.pannti1();
         }
         if(st.storykaunnto==19)sound.BGM_tusima2();
         if(st.storykaunnto==22&&dannraku==1)sound.BGM2_start();
         if(st.storykaunnto==23)sound.BGM2_stop();

         if(st.storykaunnto==24)
         {
            if(dannraku==2)
            {
                sound.BGM_takatuka2();
                sound.pannti1();
            }
            if(dannraku==10)move.thirano1();
         }
         if(st.storykaunnto==25)
         {
            sound.BGM_takatuka2();
            move.thirano1();
         }


        
        
        if(st.storykaunnto==7)
        {
            move.moritagousuto_down();
            o=1;
        }
        if(st.storykaunnto==9)move.tusimaro_down();
        if(st.storykaunnto==12 && dannraku>1)move.moritagousuto_doa3();
        if(st.storykaunnto==13)move.moritagousuto_doa3();
        if((pasCanvas.enabled == false &&ITEM.enabled == false &&(Input.GetKeyDown(KeyCode.Q)&&(mati>messageToDisplay.Length || dannraku==0)))||(st.serihuokuru==1)||(syu.i==1 &&dannraku==0))//読み終わるまで押せない
        {  
             if(st.storykaunnto==0)//ストーリーの進みぐあいがゼロの時
            {
                Setmae();
                if(dannraku==0)messageToDisplay = "[高橋]\nこうして俺は、一位になり、無事に彼ら二人と、彼らが行こうとしていたところに遊びに行くことができた|Qキーで次へ";//マックスの文字数
                if(dannraku==1)messageToDisplay = "[高橋]\nしかし、その遊びに行ったところは、俺が予想していた、ネズミーランドでも、遊園地でもなく。。。。。|Qキーで次へ";//マックスの文字数
                if(dannraku==2)messageToDisplay = "[高橋]\nとんでもない、場所であった、それは、とんでもない屋敷なのであった、その屋敷について少し語ろう|Qキーで次へ";//マックスの文字数
                if(dannraku==3)messageToDisplay = "[高橋]\n今から数年前、令和6年、あるところに、Devil・T・Rexというゲームを開発した3人のプログラマーがいた|Qキーで次へ";//マックスの文字数
                if(dannraku==4)messageToDisplay = "[高橋]\n俺が聞く話では、一人目は森田、二人目は對馬、３人目は高塚という名前の人だったらしい・・・・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==5)messageToDisplay = "[高橋]\n本来、彼らが開発したDevil・T・Rexというゲームは、新座総合技術高校の、課題研究の作品だったらしい|Qキーで次へ";//マックスの文字数
                if(dannraku==6)messageToDisplay = "[高橋]\nしかし不思議な現象が起こったのだ、その開発者達は数年後、人のいない山奥に変な建物を作り出したのだ|Qキーで次へ";//マックスの文字数
                if(dannraku==7)messageToDisplay = "[高橋]\n理由はよくわからない、ただ急に作り始めたらしいんだ！、しかも彼らの体は人間の体ではなかったらしい|Qキーで次へ";//マックスの文字数
                if(dannraku==8)messageToDisplay = "[高橋]\n彼らは屋敷に入った人間を次々と襲うらしいんだ、そして屋敷から帰ってきた人は誰一人いないらしい・・|Qキーで次へ";//マックスの文字数
                if(dannraku==9)messageToDisplay = "[高橋]\nしかも、屋敷内では、彼ら３人の研究者とは別に、得体の知れない生物が潜んでいるという話もある・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==10)messageToDisplay = "[高橋]\n俺は友達の青木と佐々木にレースで勝ってしまった、だから断ろうとしても変なプライドで無理だった！！|Qキーで次へ";//マックスの文字数
                if(dannraku==11)messageToDisplay = "[高橋]\n佐々木と青木は、「2Dの人間?ｗｗそんなのいるわけねーじゃん!絶対ウソだからちょっと見に行こうぜ!」|Qキーで次へ";//マックスの文字数
                if(dannraku==12)messageToDisplay = "[高橋]\nというノリで、怖いもの知らずの様子であった、ただ俺はそんな明るいノリにはなれなかったんだ・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==13)messageToDisplay = "[高橋]\n何故なら半分噂を信じてるからだ、もしそれが本当だったら？と思うと怖くて笑えなかったんだ・・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==14)messageToDisplay = "[高橋]\nしかし、屋敷に３人で入った途端悲劇が起きた、入った瞬間、よそ見している間に、青木達が消えた・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==15)messageToDisplay = "[高橋]\n俺は、彼らは帰ったんだろう、っと都合よく考え帰ろうと、屋敷の入り口から引き返そうとした・・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==16)messageToDisplay = "[高橋]\nしかし、屋敷に入るまであんなにワクワクしてた彼らがすぐに帰るわけないと思った・・・・・・・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==17)messageToDisplay = "[高橋]\nもしかしたら、明日いないかもしれない、俺のせいで彼らが行方不明になったと思われるかもしれない・・|Qキーで次へ";//マックスの文字数
                if(dannraku==18)messageToDisplay = "[高橋]\nそう考えると、テストで０点を取る事以上にやばいことが起こりそうだと、俺は危機感を強く感じた・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==19)messageToDisplay = "[高橋]\nそして今俺は仕方なく、青木と佐々木を探しに屋敷に入った、３人の開発者がいるといわれている、不思議な屋敷へ|Qキーで次へ";//マックスの文字数
                if(dannraku==20)Saigo();//終了
                if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==12)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==13)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==14)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==15)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==16)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];  
            }
            if(st.storykaunnto==2)
            {
                Setmae();
                if(dannraku==0&&st.serihuokuru>0)messageToDisplay = "[高橋]\nここが屋敷の中？、でも周りを見渡しても、黒い壁と白い床、この小さなスペースだけが屋敷の中なのか？|Qキーで次へ";//マックスの文字数
                if(dannraku==1)messageToDisplay = "[高橋]\nにしても綺麗な壁だ、彼らは何を使ってこの建物を作ったんだ？、傷１つなく錆びる気配すら感じられない|Qキーで次へ";//マックスの文字数
                if(dannraku==2)messageToDisplay =  "[高橋]\nでも、たしかこの屋敷の入り口は「人間が簡単に立ち入りできない作りになっている」という噂があったな|Qキーで次へ";//マックスの文字数
                if(dannraku==3)messageToDisplay =  "[高橋]\nいや、さっき外から見たからわかるが、こんな小さい部屋しかないなんて変だ、屋敷ははるかに大きかった|Qキーで次へ";//マックスの文字数
                if(dannraku==4)messageToDisplay =  "[高橋]\nきっとここは建物の入り口で、ここには何か、建物内に入れないようにする仕掛けでもあるんだろう・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==5)messageToDisplay =  "[高橋]\nじゃなければ今僕が通った通路は何のためにあるんだ？っていう話になる、なら絶対ここは入口だ・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==6)messageToDisplay =  "[高橋]\nでも、普通こうゆう建物に入る時って、大体家に入る時と同様に鍵が必要だよな？・・・・・・・・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==7)messageToDisplay =  "[高橋]\nさすがに、建物の構造を、誰もが中に入れるような作りにはしないだろう、じゃあ普通に考えて入れない？|Qキーで次へ";//マックスの文字数
                if(dannraku==8)messageToDisplay =  "[高橋]\nじゃあ俺鍵持ってないし、入れないか・・いやでも、僕がここに来る前に屋敷に来た人たちは過去にいるし|Qキーで次へ";//マックスの文字数
                if(dannraku==9)messageToDisplay =  "[高橋]\nなおかつ、屋敷に入った後、襲われるという噂話が出てるぐらいだ、・・熱増でそんなうわさ広まるか？？|Qキーで次へ";//マックスの文字数
                if(dannraku==10)messageToDisplay = "[高橋]\nやっぱ、さすがにそんな噂が出るってことは、何人もの人がこの屋敷に入ることに成功しているはず・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==11)messageToDisplay = "[高橋]\nなら、おそらく今の考察で行けば、やっぱりこの屋敷内には鍵なしで入れるはずだ・・・・・・・・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==12)messageToDisplay = "[高橋]\nこの部屋の中に、恐らく簡単に入口の中に入れないようにする仕掛けがあるはず・・・・・・・・・・・・|Qキーで次へ";//マックスの文字数
                if(dannraku==13)messageToDisplay = "[高橋]\nちょっとこのスペースを今探索してみよう、いろいろ触ってたら、入口のロックを解除できるかもしれない|Qキーで次へ";//マックスの文字数
                if(dannraku==14)Saigo();//終了
                if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
                if(dannraku==12)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==13)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[1];
            
           
         } 
         if(st.storykaunnto==3)
            {
                if(siraberu==1)
                {
                    Setmae();
                    if(dannraku==0)messageToDisplay = "[高橋]\n何だろう壁に「この先、超絶めっちゃ危険!^ω^。BYグットナチュラルパーソン!」っという文が書かれてる|Qキーで次へ";
                    if(dannraku==1)messageToDisplay = "[高橋]\nこの先・・って書いてあるということは、多分ここは入口だ・・にしても何なんだこの緊張感のない文はww|Qキーで次へ";
                    if(dannraku==2)messageToDisplay = "[高橋]\nしかも、恐らくぐっとナチュラルパーソンはカタカナ英語だろう・・でもこの名前どこかで聞き覚えが・・|Qキーで次へ";
                    if(dannraku==3)messageToDisplay = "[高橋]\nあ！たしかこの屋敷を作った研究者3人が新座総合技術高校で研究をしていた時のチーム名だったんだっけ?|Qキーで次へ";
                    if(dannraku==4)messageToDisplay = "[高橋]\nにしても、なんで英語のgoodをグットって示しているんだよｗｗｗｗｗふつうグッドじゃね？ｗｗｗｗｗｗ|Qキーで次へ";
                    if(dannraku==5)messageToDisplay = "[高橋]\nん？ほかにも何か下に書いてある・・・「扉のヒントは、ボタンを押すこと」・・・ボタン？・・・・・・|Qキーで次へ";
                    if(dannraku==6)messageToDisplay = "[高橋]\nこれも何かのヒントだろうか？引き続き探索をしていってみよう・・まだ何か手がかりがあるかもしれない|Qキーで次へ";
                    if(dannraku==7)Saigo();
                }
                 if(siraberu==2)
                {
                    Setmae();
                    if(dannraku==0)messageToDisplay = "[高橋]\n何か書いてある「君はどうしてここに来たんだい?お友達探し?それともいじめ?迷子?家出?酒?・・・・・」|Qキーで次へ";
                    if(dannraku==1)messageToDisplay = "[高橋]\nこの記述・・・誰かが俺様に心配をかけてくれているような記述だな・・、これを見ると少し安心する・・|Qキーで次へ";
                    if(dannraku==2)messageToDisplay = "[高橋]\nでもなんでこんなところに書いているのか、ここにこんな記述を書いた意味がパーリーピーポーだ・・・・|Qキーで次へ";
                    if(dannraku==3)messageToDisplay = "[高橋]\nおや、でも、この下にも何か文が書かれてある。「漢字の書き順、書く数が多いい順に並べなさい」・・・|Qキーで次へ";
                    if(dannraku==4)messageToDisplay = "[高橋]\n書く数が多いい？、書く回数のことか？さっぱり言ってることがわからんなｗｗｗ落書きかなんかだろうｗ|Qキーで次へ";
                    if(dannraku==5)Saigo();
                }

                 if(siraberu==3)
                {
                    Setmae();
                    if(dannraku==0)messageToDisplay = "[高橋]\n何か書いてある「ここに入れば死ぬ、きっと明日お前は消えている、まだ生きていたいなら帰れ・・・・」|Qキーで次へ";
                    if(dannraku==1)messageToDisplay = "[高橋]\nえ！マジ！？、でももし、この文を書いた人って、書き終わった後に文章を自分の書いた読んだ場合・・・|Qキーで次へ";
                    if(dannraku==2)messageToDisplay = "[高橋]\nそれって、もしかして、・・・・・・・・・・・・・・・・・・・・・自分の文章で自分自身に向かって、|Qキーで次へ";
                    if(dannraku==3)messageToDisplay = "[高橋]\n「ここにいれば死ぬ、きっと明日お前は消えている、生きていたいなら帰れ」って主張してることになるな|Qキーで次へ";
                    if(dannraku==4)messageToDisplay = "[高橋]\nこの人は、自分に「お前はもう死んでいる！」とでも言いたかったのだろうか？ｗｗｗｗｗｗｗｗｗｗｗｗ|Qキーで次へ";
                    if(dannraku==5)messageToDisplay = "[高橋]\nん？まだ下に何か書いてある、「左から順番に並べろ」って書かれているな・・・これもヒント臭いなｗｗ|Qキーで次へ";
                    if(dannraku==6)messageToDisplay = "[高橋]\n参考になるかもしれない、頭の片隅にでもこの情報はしまっておくか・・・・・・・・・・・・・・・・・|Qキーで次へ";
                    if(dannraku==7)Saigo();
                }


            }       
        if(st.storykaunnto==4)
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[高橋]\nん？！、何か音がする・・・、壁にあるボタンをポチポチしてたら何かが動いたみたいだ・・・・・・・・|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[高橋]\nでも、どこが動いたんだろう・・でも音からして、この部屋のどこかな気がする・・ちょっと探してみよう|Qキーで次へ";
            if(dannraku==2)Saigo();

        }
        if(st.storykaunnto==7)//if(st.storykaunnto==6)のif文よりも下の行に書くとバグる⚠
        {
            if(k==1)
            {
                Setmae();
                RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==0)messageToDisplay = "[高橋]\n先にあの奥の扉を見に行こう！|Qキーで次へ";
                if(dannraku==1)Saigo();
            }
            if(siraberu==1)
                {
                    Setmae();
                    RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                    if(dannraku==0)messageToDisplay = "[高橋]\nなんだろう、壁に何かある、これは見た感じ、パスワードのロックみたいだ、|Qキーで次へ";
                    if(dannraku==1)messageToDisplay = "[高橋]\nもしかして、このパスワードのロックを解除すれば、この右にあるドアが開くのかな？パスワード画面を調べてみよう|Qキーで次へ";
                    if(dannraku==2)Saigo();
                }
        }
         if(st.storykaunnto==6)
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[高橋]\nん？！、ここの真っ白い壁がなくなっている！！！！、しかもなんだ、見た感じ中に入れるじゃないか！！|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[？？]\nおや？・・・誰が来たみたいだね、お前は誰だい？・・・|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[高橋]\nどこからか声が！！？？・・・・一体どこに？・・・・・・|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[高橋]\n・・・・・・・・・・・・・・・・・・・・・・・・うわーー！！、・・・何！何か下から出てきたぞ！？|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[？？]\n人間さん、こんにちは、暇で飽き飽きしてたんだよ|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[高橋]\nなんだこの奇妙な生物は、一体お前は誰なんだ？！|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[？？]\n俺？・・・俺は森田ゴーストって名前だよ|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[高橋]\n森田ゴースト？ｗｗまぁそんなのどうでもいいや、とにかく質問があるんだ！|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[高橋]\nここに俺と同じ位の年齢の男の子が2人来なかったか？実はそいつらは俺の友達で、今探してるんだ・・・|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[森田ゴースト]\nん？あぁもしかして・・あいつが言っていたあの2人の事か？・・俺は話だけだから知らないけど・・・|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[森田ゴースト]\n確か2人男の子を捕まえたって、知り合いから聞いたよ|Qキーで次へ";
            if(dannraku==11)messageToDisplay = "[高橋]\n知り合い、こんな変な生き物に！？、え、その知り合い、今どこにいるんだ！？|Qキーで次へ";
            if(dannraku==12)messageToDisplay = "[森田ゴースト]\nえー教えたら、つまらねぇなー|Qキーで次へ";
            if(dannraku==13)messageToDisplay = "[高橋]\n頼む、むっちゃくちゃ緊急事態なんだ、お願いだ、|Qキーで次へ";
            if(dannraku==14)messageToDisplay = "[森田ゴースト]\nじゃあ、こうしよう、俺を倒すことができたら、教えてやるよ、絶対無理だと思うがなｗ|Qキーで次へ";
            if(dannraku==15)messageToDisplay = "[森田ゴースト]\n何故なら、我々森田ゴーストは一度も人間に負けたことがないのさ、人間の握力や力は弱いからｗ|Qキーで次へ";
            if(dannraku==16)messageToDisplay = "[森田ゴースト]\nなぜそんなに強いかって？、それは俺たちは、３人の研究者によって生み出された怪物だからさｗ|Qキーで次へ";
            if(dannraku==17)messageToDisplay = "[高橋]\n生み出された怪物？詳しく教えてくれないか？|Qキーで次へ";
            if(dannraku==18)messageToDisplay = "[森田ゴースト]\nいいよ！、ちなみに、この屋敷には、平面上の人間の研究者、森田対馬、高塚がいるんだ|Qキーで次へ";
            if(dannraku==19)messageToDisplay = "[森田ゴースト]\n彼らはもともと新座総合技術高校と言うところで研究をしていて、|Qキーで次へ";
            if(dannraku==20)messageToDisplay = "[森田ゴースト]\nそこでデビルティーレックスと言う作品を作っていたんだ|Qキーで次へ";
            if(dannraku==21)messageToDisplay = "[森田ゴースト]\nそして、彼ら3人は、デビルT・Rexに追いかけられるゲームを作りDevil・T・Rexを再現しようとした|Qキーで次へ";
            if(dannraku==22)messageToDisplay = "[高橋]\nへー・・・・・|Qキーで次へ";
            if(dannraku==23)messageToDisplay = "[森田ゴースト]\n最初は、彼らはゲーム内で収めるつもりだった、|Qキーで次へ";
            if(dannraku==24)messageToDisplay = "[森田ゴースト]\nしかし彼らは実際に現実世界に死んだティラノサウルスを作れないか？と研究を続けたんだ|Qキーで次へ";
            if(dannraku==25)messageToDisplay = "[森田ゴースト]\nしかし、その研究をしていた時だった、メンバーの対馬の作った危険薬物が、|Qキーで次へ";
            if(dannraku==26)messageToDisplay = "[森田ゴースト]\n研究室中にこぼれてしまったんだ、|Qキーで次へ";
            if(dannraku==27)messageToDisplay = "[森田ゴースト]\nその結果、彼らは、なんだかの化学反応により平面上になってしまったんだ。|Qキーで次へ";
            if(dannraku==28)messageToDisplay = "[森田ゴースト]\nそして彼らは、人間世界への復帰が不可能となった・・そして彼らは、人間世界への復帰をあきらめた|Qキーで次へ";
            if(dannraku==29)messageToDisplay = "[森田ゴースト]\n彼らは、街に出ると、周りから大きく怖がられた、だから彼らは、人のいないところに隠れることにした|Qキーで次へ";
            if(dannraku==30)messageToDisplay = "[森田ゴースト]\n彼らは、家もない。お金も稼ぐこともできない。そんな惨めな空間に3人は犯されたのだ。|Qキーで次へ";
            if(dannraku==31)messageToDisplay = "[森田ゴースト]\nしかし、その分メリットもあった。それは飲まず食わずでも生きていけるところだ。|Qキーで次へ";
            if(dannraku==32)messageToDisplay = "[森田ゴースト]\n平面上の体である以上、栄養を取る必要はなく、疲れを持つこともない|Qキーで次へ";
            if(dannraku==33)messageToDisplay = "[森田ゴースト]\nだから彼らに必要なのは、自分たちが生きていけるスペースだった|Qキーで次へ";
            if(dannraku==34)messageToDisplay = "[森田ゴースト]\n彼らが苦痛にならない、周りの一般人とは違う、環境が必要だったのだ|Qキーで次へ";
            if(dannraku==35)messageToDisplay = "[森田ゴースト]\nその結果、この屋敷が作られた|Qキーで次へ";
            if(dannraku==36)messageToDisplay = "[森田ゴースト]\nこの屋敷は、彼らが周りの人から驚かれることもなく、怖がられることもなく、|Qキーで次へ";
            if(dannraku==37)messageToDisplay = "[森田ゴースト]\nそんな落ち着いた生き方ができるような彼らにとって最適な場所なんだ|Qキーで次へ";
            if(dannraku==38)messageToDisplay = "[森田ゴースト]\nただこれは彼らが作ったわけではない、平面上の彼らには手で何かもったり、何かを作ることができない|Qキーで次へ";
            if(dannraku==39)messageToDisplay = "[高橋]\nじゃあ誰が作ったんだ？この建物は・・・・|Qキーで次へ";
            if(dannraku==40)messageToDisplay = "[森田ゴースト]\n私たちだ、私たちは彼らがティラノサウルスを作ろうとしたときに、|Qキーで次へ";
            if(dannraku==41)messageToDisplay = "[森田ゴースト]\n実験に失敗して、誤って生まれてきた、失敗作のティラノサウルス達だ、|Qキーで次へ";
            if(dannraku==42)messageToDisplay = "[森田ゴースト]\n私以外にも失敗作のティラノサウルスは2人いる。しかしみんなティラノサウルスに似てないかなww|Qキーで次へ";
            if(dannraku==43)messageToDisplay = "[森田ゴースト]\nだから、失敗作の私たち3人は、私たちを産んでくれた、3人の研究者の下について頑張っているのさ、|Qキーで次へ";
            if(dannraku==44)messageToDisplay = "[森田ゴースト]\n研究者3人、失敗作3人だから、それぞれ一人の研究者の下に1人ずつついているんだ。|Qキーで次へ";
            if(dannraku==45)messageToDisplay = "[森田ゴースト]\nちなみに俺は研究者森田の下についているお化けさ、|Qキーで次へ";
            if(dannraku==46)messageToDisplay = "[森田ゴースト]\nだから、ここに来た人間も、みんな取っ払うようにしてるよ、彼らの生活を壊さないようにするためにもね|Qキーで次へ";
            if(dannraku==47)messageToDisplay = "[森田ゴースト]\nだけどね、さっき、研究者たちは平面上になった言ったけど、それでも彼らは平然と人を倒せるんだ|Qキーで次へ";
            if(dannraku==48)messageToDisplay = "[森田ゴースト]\nそのぐらい化学反応できょうぼうかした強さを持っているんだよ|Qキーで次へ";
            if(dannraku==49)messageToDisplay = "[森田ゴースト]\nもう話はこれぐらいにしておこう、戦わないと俺はつまらないんだｗｗｗ|Qキーで次へ";     
            if(dannraku==50)messageToDisplay = "[森田ゴースト]\nそれで？君は僕と戦うの？戦わないの？|Qキーで次へ";     
            if(dannraku==51)messageToDisplay = "[高橋]\nちなみに、質問なんだが、君を倒せば通っていいんだな？、倒せばいいんだよな？|Qキーで次へ"; 
            if(dannraku==52)messageToDisplay = "[森田ゴースト]\nそうだよｗでも絶対無謀だから・・挑むのはやめといたほうがいいぜ|Qキーで次へ"; 
            if(dannraku==53)messageToDisplay = "[高橋]\nへへ！、そんなの問題ないよ！、だって俺タイムリーぷできるから！|Qキーで次へ";
            if(dannraku==54)messageToDisplay = "[高橋]\nしかも、こぶしの力もチート！君にたぶん勝つよ！|Qキーで次へ";
            if(dannraku==55)messageToDisplay = "[森田ゴースト]\nははは！ついに切羽詰まって脅しに入ったかｗｗやれるもんならやってみろよ！|Qキーで次へ";
            if(dannraku==56)messageToDisplay = "[高橋]\nよし、それじゃあぶん殴るか！、はいぱーうるとらー！！！チート急のぱんちーー！！|Qキーで次へ";    
            if(dannraku==57)messageToDisplay = "[森田ゴースト]\nうわーーー！は！？、え！？なになに！？|Qキーで次へ";
            if(dannraku==58)messageToDisplay = "[森田ゴースト]\nえ！うそでしょ！お前強すぎ！・・・待ってタイムタイム、死んじまうって！！|Qキーで次へ";
            if(dannraku==59)messageToDisplay = "[高橋]\nやれるもんならやってみろって言ったのは誰だ？・・・|Qキーで次へ";
            if(dannraku==60)messageToDisplay = "[森田ゴースト]\nおれだ。・・すまん。。おれ、人間舐めてたわ。。|Qキーで次へ";
            if(dannraku==61)messageToDisplay = "[森田ゴースト]\n(この威力・・下手したら、３人の研究者たちより強い？ってことは、こいつは研究者たちより強い？)|Qキーで次へ";
            if(dannraku==62)messageToDisplay = "[高橋]\nもう一発殴ろうか？・・・・|Qキーで次へ";
            if(dannraku==63)messageToDisplay = "[森田ゴースト]\nやめろ！・・参った参った！！・・・タイムタイム・・俺の負けだ、また食らったら死ぬｗｗ|Qキーで次へ";
            if(dannraku==64)messageToDisplay = "[森田ゴースト]\nわかったよ・・君の望むように・・・知り合いの居場所を教えてやるよ・・・|Qキーで次へ";
            if(dannraku==65)messageToDisplay = "[高橋]\nよっしゃーーー！！！！|Qキーで次へ";
            if(dannraku==66)messageToDisplay = "[森田ゴースト]\n俺はこの話を、對馬ロボットってやつから聞いた・・・\n|Qキーで次へ";
            if(dannraku==67)messageToDisplay = "[高橋]\nで。。そいつはどこにいるんだ？|Qキーで次へ";
            if(dannraku==68)messageToDisplay = "[森田ゴースト]\nこの階の真上に、白い柵があるんだ、その柵の向こう側に、いるんだ・・|Qキーで次へ";
            if(dannraku==69)messageToDisplay = "[高橋]\nなるほど！ちなみにだが・・対馬ロボットってさっき言ってた、失敗作のティラノサウルスってやつか？|Qキーで次へ";
            if(dannraku==70)messageToDisplay = "[森田ゴースト]\nそうだその通りだ、俺を含めた３人の中の一人だ、|Qキーで次へ";
            if(dannraku==71)messageToDisplay = "[高橋]\nなるほどねｗ！よし！、じゃあそいつに会いに行くわ！ばいばい！ｗｗｗ|Qキーで次へ";
            if(dannraku==72)Saigo();
                if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==12)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==13)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==14)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==15)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==16)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==17)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==18)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==19)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==20)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==21)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==22)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku>=23&&dannraku<=38)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==39)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku>=40&&dannraku<=50)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==51)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==52)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==53)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==54)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==55)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==56)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku>=57&&dannraku<=64&&dannraku!=59&&dannraku!=62)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==59)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==62)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==65)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==66)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==67)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==68)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==69)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                if(dannraku==70)RawImage_TAKAHASHI.texture=Texture_MORITAGO[0];
                if(dannraku==71)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
                
        }
 
        if(st.storykaunnto==8)
        {
            Setmae();
            st.susumiseigyo=0;
            if(dannraku==0)messageToDisplay = "[高橋]\nよし、これがさっきマシュマロ野郎が言ってた白い柵か・・・絨毯の色は茶色か、センスねーー！ダッサ！|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[高橋]\nん？！、なんだ？・・この柵・・・開けようとしてもあかねー！、これもまた、センスねー！！！ダッサ！|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[？？]\n俺が２分で丹念掛けて丁寧に作った、このダサい柵を馬鹿にしたのはだれだ！！！！！！！！！！！！！！|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[高橋]\nん？またどこからか声が・・・・・・・・・・、ってかｗｗｗ２分だけじゃ丹念掛けてねーだろ！ｗｗｗｗ|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[高橋]\n・・・・・・・・・・・・・・・・・・・・・うわーーーーー！！！！段ボールが落ちてきたーー！！！！|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[？？]\nだんぼーるじゃねーよ！！！ロボットだよ！！！！俺のダサいボディーに失礼な！！！！！！！！！！！！|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[高橋]\nえ！、事実を言って何が悪いんですか！！？？、って自分でダサいと言ってるということは認めてる！？？|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[？？]\nうるさい！！！・・・ってお前よく見たら！人間じゃねえか！！！！、は！？どうやってここに来た！？？|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[高橋]\nえ！気づくの遅すぎだろ、ってか君の前の名前は何だよｗｗｗｗｗ初対面に失礼なｗｗｗ|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[？？]\n俺の名前は對馬ロボットだ、ってか俺が聞きたいんだが？おまえ人間だろ、なんでこここれた？|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[對馬ロボット]\n森田ゴーストだっで見張りをしてたはず・・・！！|Qキーで次へ";
            if(dannraku==11)messageToDisplay = "[高橋]\nえ!、あ!あのマシュマロか!、あのマシュマロはカルメ焼きにしておいしく食べました!つまり倒しました!|Qキーで次へ";
            if(dannraku==12)messageToDisplay = "[對馬ロボット]\nそうかｗｗあいつ、俺より弱いくせに、「人間ボコすなんて楽勝でしょ！」って感じにうかれて|Qキーで次へ";
            if(dannraku==13)messageToDisplay = "[對馬ロボット]\nそのせいでついに、浮かれて罰が当たったんだなｗｗｗ、あっはっは！！！！うけるｗｗ|Qキーで次へ";
            if(dannraku==14)messageToDisplay = "[對馬ロボット]\nっと入っても、人間と比べたら、あいつはかなり強いから、人間のお前が勝てたってことは、|Qキーで次へ";
            if(dannraku==15)messageToDisplay = "[對馬ロボット]\nたぶん、ぎりぎり命からがら勝ったってことだろうｗｗきみはゆうかんだなｗｗｗｗよく攻撃に耐えたなｗ|Qキーで次へ";
            if(dannraku==16)messageToDisplay = "[高橋]\nえ！？あいつそんな強いんですか！？僕パンチ一回で倒したけどｗｗ、|Qキーで次へ";
            if(dannraku==17)messageToDisplay = "[高橋]\nっていうか、そんなふざけた会話は置いといて、え！？君の名前、對馬ロボット！？|Qキーで次へ";
            if(dannraku==18)messageToDisplay = "[對馬ロボット]\nそうだよ、久しぶりにお前みたいな人間がここまで侵入してきたからいま驚いてるよ|Qキーで次へ";
            if(dannraku==19)messageToDisplay = "[對馬ロボット]\nできれば、お前を今すぐこの柵をぶち破って倒したいところだが、久しぶりすぎる|Qキーで次へ";
            if(dannraku==20)messageToDisplay = "[對馬ロボット]\n今この状態で戦ったら、骨折や捻挫しちまいそうだから、ちょっと準備運動しようと思う|Qキーで次へ";
            if(dannraku==21)messageToDisplay = "[高橋]\nいや、俺は戦いに来たんじゃない、お前に質問しに来たんだ？|Qキーで次へ";
            if(dannraku==22)messageToDisplay = "[高橋]\n実は、俺は俺と同じくらいの年齢の男の子二人を探している、|Qキーで次へ";
            if(dannraku==23)messageToDisplay = "[高橋]\nでも、さっき、あの森田ゴーストっていうマシュマロみたいなやつが、お前から、|Qキーで次へ";
            if(dannraku==24)messageToDisplay = "[高橋]\n二人の男の子を捕まえたっていう話を聞いたみたいなんだ・・・お前。。いったいどこに閉じ込めたんだ|Qキーで次へ";
            if(dannraku==25)messageToDisplay = "[對馬ロボット]\nえ？俺じゃないよ？俺は彼に、「髙塚ティラノが二人の男の子を捕まえたんだって」って話しをしただけ|Qキーで次へ";
            if(dannraku==26)messageToDisplay = "[對馬ロボット]\n俺は、人間を閉じ込めたりするようなそんなめんどくさい真似はしないよｗｗ|Qキーで次へ";
            if(dannraku==27)messageToDisplay = "[高橋]\nえ！？じゃあ、その男の子二人を閉じ込めたのはお前じゃないってことか？・・・|Qキーで次へ";
            if(dannraku==28)messageToDisplay = "[對馬ロボット]\nそうだよｗｗおそらく噂の男の子二人を閉じ込めたのは、高塚ティラノだよｗｗｗ君、勘違いしたねｗ|Qキーで次へ";
            if(dannraku==29)messageToDisplay = "[高橋]\nおい！じゃあその、高塚ティラノっていうやつにどうすれば会えるか教えろ！|Qキーで次へ";
            if(dannraku==30)messageToDisplay = "[對馬ロボット]\nえー！それはできないなーｗそうゆうのは俺を倒してからにしてくれ、|Qキーで次へ";
            if(dannraku==31)messageToDisplay = "[高橋]\nじゃあ来いよ！、柵のこっち側にｗいつでもＯＫだぞ！俺はお前をワンパンでぶっ飛ばしてやる！|Qキーで次へ";
            if(dannraku==32)messageToDisplay = "[對馬ロボット]\nｗｗ実はねこの柵はね俺でも開けられないんだｗｗｗｗ|Qキーで次へ";
            if(dannraku==33)messageToDisplay = "[高橋]\nえ！？なんで、さっき「この柵をぶち破ってお前を倒したいところだが」って言ってたじゃないか？|Qキーで次へ";
            if(dannraku==34)messageToDisplay = "[對馬ロボット]\nいや、ｗあれは冗談だよｗｗ本来俺は對馬研究者のところに人間が侵入できないように|Qキーで次へ";
            if(dannraku==35)messageToDisplay = "[對馬ロボット]\n入ってきた人間を始末していかなきゃいけないんだ、でもね、俺、人間始末すんの面倒だから|Qキーで次へ";
            if(dannraku==36)messageToDisplay = "[對馬ロボット]\nそもそも中に人間が入れないような柵やバリアを作って対馬研究者のいる部屋に入れないようにしたんだ！|Qキーで次へ";
            if(dannraku==37)messageToDisplay = "[高橋]\nえ！ちーとだろ！、じゃあお前とバトルことはできないってことかよｗｗ|Qキーで次へ";
            if(dannraku==38)messageToDisplay = "[對馬ロボット]\nいや！？でもね、方法が一つだけあるよ、|Qキーで次へ";
            if(dannraku==39)messageToDisplay = "[高橋]\nいったいなんだ？|Qキーで次へ";
            if(dannraku==40)messageToDisplay = "[對馬ロボット]\n君から見て左側に通路があると思うんだけど、その通路の奥には森田研究者がいるんだ！|Qキーで次へ";
            if(dannraku==41)messageToDisplay = "[對馬ロボット]\n実はこの柵ねｗふざけ半分で、森田研究者を倒したらあく仕組みにして作ったんだ|Qキーで次へ";
            if(dannraku==42)messageToDisplay = "[高橋]\nえ！？やば！ｗって森田研究者ってこの屋敷の噂でよく聞く、對馬、高塚、森田という３人の研究者うちの森田？！|Qキーで次へ";
            if(dannraku==43)messageToDisplay = "[對馬ロボット]\nそのとおりだよｗまあ、お前一瞬で森田研究者に倒されると思うがなｗｗｗｗ・・・・|Qキーで次へ";
            if(dannraku==44)messageToDisplay = "[對馬ロボット]\nだから、君が森田研究者を倒してこの柵を開いて、俺と戦いに来るまで俺は、|Qキーで次へ";
            if(dannraku==45)messageToDisplay = "[對馬ロボット]\n君から見てこの柵の向こう側にある部屋でラジオ体操して、体をほぐしつつ待ってるよ、それじゃあｗｗ|Qキーで次へ";
            if(dannraku==46)messageToDisplay = "[高橋]\nうわ！逃げられた！・・・くそー仕方がない！|Qキーで次へ";
            if(dannraku==47)messageToDisplay = "[高橋]\nじゃあその、森田研究者ってのをいっちょ倒せばいいんだな？よし！さっさと倒そう！|Qキーで次へ";
            if(dannraku==48)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==12)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==13)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==14)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==15)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==16)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==17)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==18)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==19)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==20)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==21)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==22)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==23)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==24)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==25)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==26)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==27)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==28)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==29)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==30)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==31)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==32)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==33)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==34)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==35)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==36)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==37)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==38)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==39)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==40)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==41)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==42)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==43)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==44)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==45)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==46)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==47)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];

        }
               if(st.storykaunnto==10)
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[森田]\nなんだ！？・・・人間！？・・・どうやってこの建物の中に入ってきたんだ！？|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[森田]\nまさかお前、森田ゴーストのバリアを通り抜けてここまで来たのか！？え!?アンビリーばぼーじゃないか!|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[森田]\nそのアンビリーばぼーな出来事に俺は関心だ、お前が俺を恐れてないなら、お前も平面上にならなか!!!!?|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[高橋]\nならないよ！、違う俺は君を倒しに来たんだ、對馬ロボットの柵が、YOUを倒さない限り開かないらしい!!|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[森田]\n何！？平面上にならず、しかも俺を倒しに来ただと！？うわーーー！！！もうだめだーーーｗｗｗｗｗｗw|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[森田]\n君とは仲良くできないみたいだ、じゃあ戦おうじゃないか！？ただひいとくなら今のうちだぞ！？|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[森田]\n俺も異常なほどの怪物だが、お前がこの屋敷これ以上手出しせずに、家に帰ってくれるなら見逃してやる!|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[森田]\nさあ少年よ、マイホームに変えるか帰らないか答えるのだ!!!!!!!!俺と戦ったら君は多分バッドエンドだ|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[高橋]\n帰らないよ！俺絶対死なないからww死んでもタイムリーぷで生き返ることもできるし!握力もチートだし!|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[森田]\n醜い冗談は置いとくんだよ少年ｗｗｗじゃあ帰る気がない君に本当の恐ろしさを見せてやる！！ｗｗｗｗ|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[森田]\n今から、戦おうじゃないか！、これが君の最後になるだろうｗｗｗたくさん絶望するがいいｗｗｗｗｗｗ|Qキーで次へ";
            if(dannraku==11)messageToDisplay = "[バトル時の操作説明]\n今からバトルが始まります、バトル時には、ノリノリの曲に合わせて次々と画面に英単語が表示されます|Qキーで次へ";
            if(dannraku==12)messageToDisplay = "[バトル時の操作説明]\nゲーム時はその画面に映し出された、英単語のスペルを素早く入力して、エンターキーを押せばＯＫです|Qキーで次へ";
            if(dannraku==13)messageToDisplay = "[バトル時の操作説明]\nつまり、エンターキーを押す必要がある、タイピングゲームを考えてもらえば大丈夫です|Qキーで次へ";
            if(dannraku==14)messageToDisplay = "[バトル時の操作説明]\nしかし、エンターキーを押すタイミングにめっちゃ注意！、ゲーム内にはノリノリの曲が流れますが、|Qキーで次へ";
            if(dannraku==15)messageToDisplay = "[バトル時の操作説明]\nそのノリノリのリズムに合わせて、画面下の緑の図形が左右に動きます、|Qキーで次へ";
            if(dannraku==16)messageToDisplay = "[バトル時の操作説明]\nその際、緑のブロックと赤いブロックが重なるタイミングがあります。|Qキーで次へ";
            if(dannraku==17)messageToDisplay = "[バトル時の操作説明]\nこの緑のラインと赤のラインが重なるタイミングで曲のリズムに合わせてエンターキーを押してください|Qキーで次へ";
            if(dannraku==18)messageToDisplay = "[バトル時の操作説明]\nちなみに、このタイミングでエンターキーを押せなかった場合は、ダメージを受けてＨＰが減ります|Qキーで次へ";
            if(dannraku==19)messageToDisplay = "[バトル時の操作説明]\nしかし、この戦いで倒されても、主人公はタイムリーぷできるので、また再戦が可能です|Qキーで次へ";
            if(dannraku==20)messageToDisplay = "[バトル時の操作説明]\nつまり、倒されてもゲームオーバーにならないということです、なので安心して音楽を楽しみつつプレイしてください|Qキーで次へ";
            if(dannraku==21)messageToDisplay = "[バトル時の操作説明]\nそれではバトルが始まります、頑張ってください|Qキーで次へ";
            if(dannraku==22)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==11)RawImage_TAKAHASHI.texture=setumeida;
            if(dannraku==15)setumei.enabled=true;
            if(dannraku==15)setumei.texture=setumei1;
            if(dannraku==16)setumei.texture=setumei2;
            if(dannraku==17)setumei.texture=setumei2;
            if(dannraku==18)setumei.enabled=false;
        }
        if(st.storykaunnto==12)
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[高橋]\nよし！・・・そろそろこの森田研究者ってやつの遊びにかまうのも飽きたから、そろそろ僕も攻撃するか！|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[高橋]\nいけ！ハイパーウルトラーぱんちーー！|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[森田]\nえ！？、は！？やっば！お前強すぎだろ！なんだ今のパンチ！！！|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[森田]\nうわーーーｗｗｗ待って俺もう気絶寸前ｗｗｗ君から何言われても答えられなくなるｗｗｗ|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[森田]\nぐほーーー・・・・・・・・・・・・・・・・・・・・・・・・・・・・|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[高橋]\n大丈夫だ！僕は君に質問なんてしないからさ！、これで森田研究者を倒すことができた|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[高橋]\nそれじゃあおそらく、さっき通れなかった白い柵の向こうに行けるはずだ！|Qキーで次へ"; 
            if(dannraku==7)messageToDisplay = "[高橋]\n早速あの對馬ロボットに会いに行くか！あいつの準備運動も終わっただろ！|Qキーで次へ";
            if(dannraku==8)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_MORITA[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
        }
        if(st.storykaunnto==1000||st.storykaunnto==2000||st.storykaunnto==1500)
        {
             Setmae();
             RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==0)messageToDisplay = "[高橋]\nよし！、それじゃあ死んだから、タイムリーぷして戻ろう！|Qキーで次へ";
            if(dannraku==1)Saigo();
        }

        if(st.storykaunnto==14)
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[對馬ロボット]\nえ！・・・人間・・・・・・・お前！・・・森田研究者に勝ったの！？・・・・ウソだろ！！|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[高橋]\nひどいこと言うなぁ俺の握力の強さしらねーだろ君ｗｗｗｗ早速君も倒してしまおうか！|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[對馬ロボット]\n待て待て待て！タイムタイム、勘弁してくれ！なめまくってた！君の強さを実感したよ！！！|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[對馬ロボット]\nもう隠したりせず、知ってる情報は送るから！、お願いだ！死んじまう！|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[高橋]\nなんだ！倒さなくても教えてくれるのか、よっしゃー！そんじゃあ！はやくおしえてくれ！！！|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[對馬ロボット]\n俺が言った髙塚ティラノというやつは、髙塚の部屋にいる、|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[對馬ロボット]\n君が森田ゴーストと話してるときに、森田ゴーストの後ろに扉があったと思う！|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[對馬ロボット]\nその扉の向こう側が髙塚の部屋だ、その部屋の中に高塚ティラノはいる！|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[高橋]\nなるほど！じゃあその場所に向かえばいいんだな！|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[對馬ロボット]\nだけど、その部屋に行くまでには、高塚の部屋の鍵を手に入れなければいけない|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[高橋]\nえ！鍵かかっているのかよ！・・・・・・！！！ちくしょう！、そのカギはいったいどこにある！？|Qキーで次へ";
            if(dannraku==11)messageToDisplay = "[對馬ロボット]\n実は今僕たちがいる場所は、對馬の部屋というところだ|Qキーで次へ";
            if(dannraku==12)messageToDisplay = "[對馬ロボット]\n実は、この對馬の部屋には、エレベーターがある、|Qキーで次へ";
            if(dannraku==13)messageToDisplay = "[對馬ロボット]\nエレベーターで２階に上がった所に部屋があるんだ、その部屋の中に鍵はあるよ|Qキーで次へ";
            if(dannraku==14)messageToDisplay = "[對馬ロボット]\nでも、エレベーターで２階に行っても、１Ｆや３Ｆで鍵を見つけたりしなきゃ|Qキーで次へ";
            if(dannraku==15)messageToDisplay = "[對馬ロボット]\n実は、そのカギがある部屋には入れないんだ、|Qキーで次へ";
            if(dannraku==16)messageToDisplay = "[高橋]\nうわ！めんどくせ！、じゃあとりあえず２階の部屋を空けれる鍵をまず見つけなきゃだめか！|Qキーで次へ";
            if(dannraku==17)messageToDisplay = "[高橋]\nならさっそく２階の部屋の鍵を見つけるか！？|Qキーで次へ";
            if(dannraku==18)messageToDisplay = "[對馬ロボット]\nじゃあ俺はこれで失礼！・・・・・・ひええええええ！！！！！！！！！！！！！！|Qキーで次へ";
            if(dannraku==19)messageToDisplay = "[高橋]\nあいつ俺にビビッて逃げたみたいだな!面白いWWまあ、とりあえず目の前のあのカギをゲットしよ|Qキーで次へ";
            if(dannraku==20)messageToDisplay = "[高橋]\nそのあと、エレベーターで1Fと3Fの二か所を探索してみるか、よしそれじゃあ歩こう！|Qキーで次へ";
            if(dannraku==21)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==12)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==13)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==14)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==15)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==16)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==17)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==18)RawImage_TAKAHASHI.texture=Texture_TUSIMARO[0];
            if(dannraku==19)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==20)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            
        }
        if(st.storykaunnto==16)
        {
             Setmae();
            if(dannraku==0)messageToDisplay = "[對馬]\nえ！・・・人間・・・・・・・お前！、まさか一人で、この建物のバリアを突破してったのか！|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[高橋]\nその通りです！質問なんですが、高塚の鍵というのはここにあるんですか？|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[對馬]\nそうだよ、ここにある、しかし渡すつもりはない、我々の気に食わないことをする奴は排除だ！|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[高橋]\nえ！、この部屋にあるって教えてくれてありがとうございます！|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[對馬]\nいや！、そこは、え！鍵くれないんですか！？くれなきゃ困るよ！って感じの主張しろよ！|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[高橋]\nいや！全然困りません、僕君のことワンパンで倒せるので！問題なしです！！|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[對馬]\n一発で、倒す？さすがに冗談だろ、まあでもここまで君一人で来たなら信じられなくもないか|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[對馬]\nもしかして、森田も倒したのか？|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[高橋]\nはい！一発で倒しました！・・・・・・・・楽勝でした|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[對馬]\nちょっと俺もお前に試しに殴られてみたくなったわ！、今までそんな強いやつ見たことなかったから|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[對馬]\nちょっと俺と戦おうぜ！そんで君が勝って、俺を泣き詫びさせたらこの鍵を渡すよ！|Qキーで次へ";
            if(dannraku==11)messageToDisplay = "[高橋]\nよっしゃーーー！！！じゃあさっそくバトろう！！！|Qキーで次へ";
            if(dannraku==12)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];



        }
        if(st.storykaunnto==18)
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[對馬]\nはーはー、疲れた、ここまで攻撃をよけきるとは、なんというやつだ！|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[高橋]\nよし！そろそろ、飽きたし、いっちょぶん殴ってみるか！(*'▽')(*'▽')|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[高橋]\nスイパーハイパーうるとらーパンチ！ーーーーーーーーーーーーーーーーーー|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[對馬]\nうわーーー！！！！・・・・ぐほ・・・・・死ぬ死ぬ・・・・・・・・・・・|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[高橋]\nなんだ！、まだ念上げないのか！、ちょっと楽しくなってきたから！もう一回殴ってみよう！|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[高橋]\nいやーーーーー！、楽しいーーーーーーーーーーーーーーーーーーーーー！！！！！！！！！|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[對馬]\nやめろやめろ！降参だ！、お前チート急の強さ過ぎてワロタだよｗｗｗｗｗｗｗｗｗｗｗｗｗ|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[對馬]\n約束通り、高塚の部屋の鍵を渡すよ！|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[高橋]\nえ！めっちゃ潔すぎてワロタｗｗｗｗ|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[對馬]\n鍵は、俺の後ろにある、この鍵を持って、高塚の部屋の目の前に行けばＯＫだ！|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[對馬]\nいやーーー！、こんなに強い人間もいるんだなｗ、じゃあ俺はここらへんでｗｗじゃあな|Qキーで次へ";
            if(dannraku==11)messageToDisplay = "[高橋]\nよっしゃーーー！！！そんじゃあさっさと、鍵を持って高塚の部屋に行こう！！！！|Qキーで次へ";
            if(dannraku==12)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TUSIMA[0];
            if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];


        }
        if(st.storykaunnto==20)
                
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[高橋]\nよし！ドアが開いたぞ！！これでやっと高塚ティラノに会える！！！早速探そう|Qキーで次へ";
            if(dannraku==1)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
        }
        if(st.storykaunnto==21)
        {
            if(siraberu==1)
            {
             Setmae();
            if(dannraku==0)messageToDisplay = "[高橋]\nん？こんなところにミニゲームがある、ちょっと遊んでみようかな！|Qキーで次へ";
            if(dannraku==1)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
       
            }

        }
        if(st.storykaunnto==22)
                
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[高橋]\nティラノの形をした人がいる、こいつはおそらく高塚ティラノだ！！！！！！！|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[髙塚ティラノ]\nなんだ！？人間が自分から入ってきた！？しかも俺の名前を知ってる!?|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[高橋]\nあれ！？ってか君普通のティラノサウルスじゃん|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[高橋]\nこの屋敷の３人の研究者たちが行ってたDevil・T・REX現実世界での再現研究は|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[高橋]\n本当は成功していた！？ってことか！！！！！！すげーーーー！|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[髙塚ティラノ]\nいや！違う確かに俺はティラノサウルスの形をしてるがDevil・T・Rexではない|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[髙塚ティラノ]\n彼らはの考えるDevil・T・REXは人を襲い凶暴な生き物だ！|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[髙塚ティラノ]\nだから私は失敗作のティラノサウルスだよ、でも君、彼らが研究していた内容も|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[髙塚ティラノ]\n俺の名前も、この屋敷についてよく知ってるね・・誰かから聞いたのかい？|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[高橋]\nはい、ここに君以外にいた失敗作のティラノサウルから聞きました！|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[髙塚ティラノ]\nなるほど、ｗｗｗｗ理解できたよ、|Qキーで次へ";
            if(dannraku==11)messageToDisplay = "[高橋]\nっていうか、そんな話を私はしに来たんじゃなくて|Qキーで次へ";
            if(dannraku==12)messageToDisplay = "[高橋]\n質問なんですが、高塚ティラノは俺と同じ年ぐらいの年齢の男の子を|Qキーで次へ";
            if(dannraku==13)messageToDisplay = "[高橋]\n二人捕まえたとの話を聞いたのですが、おそらくその二人は、僕の友達です|Qキーで次へ";
            if(dannraku==14)messageToDisplay = "[高橋]\n僕は、その二人の友達を助けにここに来ました、ちゃんと返品してください！！|Qキーで次へ";
            if(dannraku==15)messageToDisplay = "[髙塚ティラノ]\nいや！違うんだよーー！確かに君みたいな年齢の男の子を捕まえたのは僕だけど|Qキーで次へ";
            if(dannraku==16)messageToDisplay = "[髙塚ティラノ]\n捕まえたかったのは俺じゃあない、高塚研究者だよ、彼は2Dの平面上の体なんだ|Qキーで次へ";
            if(dannraku==17)messageToDisplay = "[髙塚ティラノ]\nだから、彼は何かものを持つことができないんだ、手があるわけじゃないからね|Qキーで次へ";
            if(dannraku==17)messageToDisplay = "[髙塚ティラノ]\nそれで物を持ったりすることができる私が、髙塚の指示に従って動いてる感じだ|Qキーで次へ";
            if(dannraku==18)messageToDisplay = "[髙塚ティラノ]\n高塚研究者ね、平面の体になる前までは現実世界にDevil・T・Rex作れないか？|Qキーで次へ";
            if(dannraku==19)messageToDisplay = "[髙塚ティラノ]\nそんな研究をしていたんだ、しかし２Dになってから、研究を継続できなくなり|Qキーで次へ";
            if(dannraku==20)messageToDisplay = "[髙塚ティラノ]\n先ほどの研究は幕を閉じた、だけど高塚研究者だけは研究を諦めきれなかった！|Qキーで次へ";
            if(dannraku==21)messageToDisplay = "[髙塚ティラノ]\nそして、髙塚は、かつて新座総合で開発したDevil・T・REXのゲームの世界に|Qキーで次へ";
            if(dannraku==22)messageToDisplay = "[髙塚ティラノ]\n君みたいに3次元で生きる人間を入れることができないか?という研究をしだした|Qキーで次へ";
            if(dannraku==23)messageToDisplay = "[髙塚ティラノ]\nつまり、Devil・T・REXというゲームの世界に入る方法を探し出したのさ！！！|Qキーで次へ";
            if(dannraku==24)messageToDisplay = "[高橋]\nゲームの世界に入る方法を探すｗｗｗ？いったい何考えてるんだよｗｗｗｗ|Qキーで次へ";
            if(dannraku==25)messageToDisplay = "[髙塚ティラノ]\n黙れ少年！！！！！！！！！！！！、くそ狂った髙塚教授を馬鹿にするな！！！|Qキーで次へ";
            if(dannraku==26)messageToDisplay = "[高橋]\nえ！でも、くそ狂った教授って言ってる時点で貴方も馬鹿にしてるのでは？ｗｗ|Qキーで次へ";
            if(dannraku==27)messageToDisplay = "[髙塚ティラノ]\n違う！！今のはミスっただけだ！！！マジだ！！！ほんとだから勘違いするな！|Qキーで次へ";
            if(dannraku==28)messageToDisplay = "[高橋]\n言い訳が醜すぎて受けるｗｗｗｗマジワロタｗｗｗｗｗｗｗｗｗｗｗｗｗｗｗ|Qキーで次へ";
            if(dannraku==29)messageToDisplay = "[髙塚ティラノ]\nまあそんなことはどうでもいい、まあとにかく、高塚は手で何かを持てない|Qキーで次へ";
            if(dannraku==30)messageToDisplay = "[髙塚ティラノ]\n2Dだからね、だからその代わりに、俺が彼の指示に従ってものを持ったりして|Qキーで次へ";
            if(dannraku==31)messageToDisplay = "[髙塚ティラノ]\n研究を手助けしているんだ！・・・・・・・・・・・・・・・・・|Qキーで次へ";
            if(dannraku==32)messageToDisplay = "[高橋]\nマジか！お前有能すぎだろ！|Qキーで次へ";
            if(dannraku==33)messageToDisplay = "[髙塚ティラノ]\nしかしな！今日素晴らしい結果が出たんだ！！！|Qキーで次へ";
            if(dannraku==34)messageToDisplay = "[髙塚ティラノ]\n私が捕まえた二人の男の子を、ゲーム内の世界にいれることができたんだ|Qキーで次へ";
            if(dannraku==35)messageToDisplay = "[高橋]\nは！？意味が分からない、どうゆうことだよ！|Qキーで次へ";
            if(dannraku==36)messageToDisplay = "[髙塚ティラノ]\nつまりさっき言った、Devil・T・REXのゲームの世界に３次元の人間を入れる|Qキーで次へ";
            if(dannraku==37)messageToDisplay = "[髙塚ティラノ]\nその研究に二人を実験で扱い、なんと！二人を閉じ込めることができた！！！|Qキーで次へ";
            if(dannraku==38)messageToDisplay = "[高橋]\nおいおいウソだろ！！！、じゃあ今俺の友達は今どこに！？|Qキーで次へ";
            if(dannraku==39)messageToDisplay = "[髙塚ティラノ]\n君の友達は、ゲームの中にいるよ！、ゲーム内でDevil・T・REXから逃げてる|Qキーで次へ";
            if(dannraku==40)messageToDisplay = "[高橋]\nそれじゃあもう俺の友達は助けられないってことか！？|Qキーで次へ";
            if(dannraku==41)messageToDisplay = "[高橋]\nもういいや助けんのめんどくさ!、明日期末テストあるから帰って勉強だしよ!|Qキーで次へ";
            if(dannraku==42)messageToDisplay = "[髙塚ティラノ]\nおい！そこは、じゃあもう俺の友達は助けられないのか！？って聞き返せよ！|Qキーで次へ";
            if(dannraku==43)messageToDisplay = "[高橋]\nいや！俺テストで毎回10教科ぐらい赤点とってるから、めちゃくちゃやばい！|Qキーで次へ";
            if(dannraku==44)messageToDisplay = "[高橋]\nまだ、勉強エネルギーをためるためにこの屋敷に肝試しに言ってたけど、|Qキーで次へ";
            if(dannraku==45)messageToDisplay = "[高橋]\nそろそろ勉強始めなくちゃ留年確定なんだ！！|Qキーで次へ";
            if(dannraku==46)messageToDisplay = "[髙塚ティラノ]\nお前！よくそんな点数で、前日にこの屋敷を訪れたな！？いかれてやがる！！|Qキーで次へ";
            if(dannraku==47)messageToDisplay = "[髙塚ティラノ]\n大丈夫だそんなこというな、実は、さっき言ったお前の友達とみられる男の子|Qキーで次へ";
            if(dannraku==48)messageToDisplay = "[髙塚ティラノ]\n彼らをを助ける方法がある！諦めるな少年！|Qキーで次へ";
            if(dannraku==49)messageToDisplay = "[高橋]\nマジ！たすけんのめんどくせーー！！、まあ一応助けとくか！助ける方法は？|Qキーで次へ";
            if(dannraku==50)messageToDisplay = "[髙塚ティラノ]\n実は、俺らは、実験材料としてこの屋敷に侵入してきた人間どもを扱ってる|Qキーで次へ";
            if(dannraku==51)messageToDisplay = "[髙塚ティラノ]\nそして、お前の友達とみられる男の子二人も実験として扱ったんだが|Qキーで次へ";
            if(dannraku==52)messageToDisplay = "[髙塚ティラノ]\n理論上、このゲーム内の世界に迷い込んだ場合、画面にこんなスタート画面が画面に表示されるだろう|Qキーで次へ";
            if(dannraku==53)messageToDisplay = "[髙塚ティラノ]\nその後、そのスタート画面にあるスタートっというボタンを押せば、廃学校のマップに君はたどり着くはず、|Qキーで次へ";
            if(dannraku==54)messageToDisplay = "[髙塚ティラノ]\n恐らく彼らは今その中をさまよっているはずだ、だから彼らを救いたいのであれば、お前もそのゲーム内に入り|Qキーで次へ";
            if(dannraku==55)messageToDisplay = "[髙塚ティラノ]\nマップ内で君の友達二人を見つけ、一緒に脱出をするんだ！そうすれば、私の研究結果が間違ってない限り|Qキーで次へ";
            if(dannraku==56)messageToDisplay = "[髙塚ティラノ]\n彼らも君も、そのゲームの世界から脱出でき、現実世界に帰れるだろうｗｗｗ！だからつまり|Qキーで次へ";
            if(dannraku==57)messageToDisplay = "[髙塚ティラノ]\n君もゲームの中の世界に入り、そこで君のお友達とともにゲームクリアすればOK|Qキーで次へ";
            if(dannraku==58)messageToDisplay = "[髙塚ティラノ]\nそうすれば、彼らを救えるということだ！！！わかったか？少年！！！！！！！|Qキーで次へ";
            if(dannraku==59)messageToDisplay = "[高橋]\nくそ！、あいつを助けなきゃいけねーのか！！！面戸くっさ！！！まあいいや！|Qキーで次へ";
            if(dannraku==60)messageToDisplay = "[高橋]\n決めた、俺もそのゲームの世界に入るよ！、だから入らせてほしい！！！|Qキーで次へ";
            if(dannraku==61)messageToDisplay = "[髙塚ティラノ]\nいいね！それでこそ、ぐっとナチュラルパーソンだ！|Qキーで次へ";
            if(dannraku==62)messageToDisplay = "[髙塚ティラノ]\nゲーム内に人間を入れることに初めて成功したけど！それがたまたまなのか？|Qキーで次へ";
            if(dannraku==63)messageToDisplay = "[髙塚ティラノ]\nもしくはそうではないのか、まだわからないからね！|Qキーで次へ";
            if(dannraku==64)messageToDisplay = "[髙塚ティラノ]\n君も実験材料として使わせてもらうよ！|Qキーで次へ";
            if(dannraku==65)messageToDisplay = "[高橋]\nよし！、そしたら早速そのゲームの世界に行かせてもらおうじゃないか！|Qキーで次へ";
            if(dannraku==66)messageToDisplay = "[髙塚ティラノ]\nだがちょっと待て！、お前と一度戦ってみたい、ここまで来れた人間は初めてだ|Qキーで次へ";
            if(dannraku==67)messageToDisplay = "[髙塚ティラノ]\nここまでこれたということは、君は相当強いということ君の強さを知りたい！|Qキーで次へ";
            if(dannraku==68)messageToDisplay = "[高橋]\nえ！！！いいぜ！！！佐々木達助けるだけじゃつまんないし、いっちょバトろう|Qキーで次へ";
            if(dannraku==69)messageToDisplay = "[髙塚ティラノ]\nよし！では戦おう！！！！！！！！！！|Qキーで次へ";
            if(dannraku==70)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==12)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==13)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==14)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==15)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==16)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==17)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==17)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==18)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==19)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==20)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==21)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==22)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==23)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==24)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==25)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==26)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==27)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==28)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==29)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==30)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==31)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==32)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==33)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==34)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==35)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==36)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==37)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==38)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==39)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==40)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==41)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==42)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==43)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==44)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==45)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==46)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==47)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==48)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==49)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==50)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==51)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==52)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==52)setumei.enabled=true;
            if(dannraku==52)setumei.texture=home1;
            if(dannraku==53)setumei.texture=home2;
            if(dannraku==55)setumei.enabled=false;
            if(dannraku==53)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==54)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==55)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==56)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==57)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==58)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==59)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==60)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==61)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==62)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==63)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==64)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==65)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==66)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==67)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==68)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==69)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
        }
              if(st.storykaunnto==24)
                
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[高橋]\nよし！こいつの攻撃よけるのも飽きたからそろそろぶっ倒すか！|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[高橋]\nスーパーハイパーうるとらーーーぱんちーーーー！！！！！！！！！|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[髙塚ティラノ]\nうわ！やばすぎ、ぐほーーーーー！！！！！！！！！！！|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[髙塚ティラノ]\nいや！、見事なパンチだった、私もお手上げだ！！！|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[髙塚ティラノ]\n急なお願いだったが対戦ありがとう少年よ！|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[髙塚ティラノ]\nそれじゃあ、君をゲームの世界に連れて行こうじゃないか！|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[高橋]\nよっしゃーー！あざっす！！！！！！！！！！！！！|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[髙塚ティラノ]\n実は俺のから見て左側の部屋は、研究室で、そこには高塚教授がいるんだ、|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[髙塚ティラノ]\nただゲームの世界に行くにはその部屋に行く必要があるからまずその部屋に行け！|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[髙塚ティラノ]\n俺は先に、地面を潜ってその部屋に行くから、先に、君のすぐ目の前にある研究室で待ってるぞ！|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[高橋]\nOK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!|Qキーで次へ";
            if(dannraku==11)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==8)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
        }
            if(st.storykaunnto==26)
                
        {
            Setmae();
            if(dannraku==0)messageToDisplay = "[髙塚]\n人間が来たな、こいつが髙塚ティラノの言ってた人間か？|Qキーで次へ";
            if(dannraku==1)messageToDisplay = "[高塚ティラノ]\nそうです、こいつがチート急の力を持ってる人間です|Qキーで次へ";
            if(dannraku==2)messageToDisplay = "[髙塚]\nなるほど、それじゃあ今からお前に友達を助けに行くついでにゲーム内に入ってもらう|Qキーで次へ";
            if(dannraku==3)messageToDisplay = "[高橋]\nよっしゃーー！それじゃあ早く入らせてくれ！！！！！！！！！！！！！！！！！！|Qキーで次へ";
            if(dannraku==4)messageToDisplay = "[髙塚]\nゲーム内に入る時は、今君の目の前にある赤いじゅうたんの上に乗れば大丈夫だ！！|Qキーで次へ";
            if(dannraku==5)messageToDisplay = "[髙塚]\nしかし、君、がちで強すぎるみたいだな？おそらくそんな体で入ったらゲーム崩壊だ|Qキーで次へ";
            if(dannraku==6)messageToDisplay = "[髙塚]\nなので、君には、肉体を俺が手掛けて作った3Dモデルに切り替えてもらう！！！！！|Qキーで次へ";
            if(dannraku==7)messageToDisplay = "[髙塚ティラノ]\nよし、じゃあお前に今から魔法をかける、行くぞ「お前の体！よわくなれ～～は！」・・よし魔法を唱えた！|Qキーで次へ";
            if(dannraku==8)messageToDisplay = "[3D高橋]\nうわーーーー！！！！なんだこの体！、だっさ！しかも動きずら！！！！！！|Qキーで次へ";
            if(dannraku==9)messageToDisplay = "[髙塚]\nすまないな、お前みたいなチート急の人間がゲーム内に入ったら、|Qキーで次へ";
            if(dannraku==10)messageToDisplay = "[髙塚]\n恐らくこのゲーム内の屋敷がとんでもないことになりそうだから、いろいろぶっ壊れそう|Qキーで次へ";
            if(dannraku==11)messageToDisplay = "[髙塚]\nだから君は、その体で屋敷内をうろつくように頑張れ！！！！！！！！！！|Qキーで次へ";
            if(dannraku==12)messageToDisplay = "[髙塚]\nDEVILE・T・REXの握力30だから、君がワンパンで倒してしまいそうでｗｗｗ|Qキーで次へ";
            if(dannraku==13)messageToDisplay = "[3D高橋]\nえ！そんなよわっちい恐竜を作るためだけにずっと研究してたの！！ＷＷＷ？|Qキーで次へ";
            if(dannraku==14)messageToDisplay = "[髙塚]\nうるせーー！！！こまけーことは気にすんな！！！！！！！！！！！！|Qキーで次へ";
            if(dannraku==15)messageToDisplay = "[髙塚]\nとにかく、これで君もゲーム内に入れる体になったことだから早速赤いじゅうたんの上に行け！|Qキーで次へ";
            if(dannraku==16)messageToDisplay = "[髙塚]\n君がゲーム内に入ることは、我々のためでもあり、君のためでもあるんだ|Qキーで次へ";
            if(dannraku==17)messageToDisplay = "[3D高橋]\nちぇーーめんどくせーーー！！わかった！とりあえず赤いじゅうたんに乗って|Qキーで次へ";
            if(dannraku==18)messageToDisplay = "[3D高橋]\nゲームの世界に入ったら、友達を助けてゲームクリアしてみせるよ！|Qキーで次へ";
            if(dannraku==19)messageToDisplay = "[髙塚]\nいい意気込みだ！さすがだ少年！それでは幸運を願うぞ！！！！！！！！！！！|Qキーで次へ";
            if(dannraku==20)Saigo();
            if(dannraku==0)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==1)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==2)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==3)RawImage_TAKAHASHI.texture=Texture_TAKAHSHI[0];
            if(dannraku==4)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==5)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==6)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==7)RawImage_TAKAHASHI.texture=Texture_TAKATUKA_REX[0];
            if(dannraku==8)RawImage_TAKAHASHI.texture=TAKAHASI2D;
            if(dannraku==9)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==10)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==11)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==12)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==13)RawImage_TAKAHASHI.texture=TAKAHASI2D;
            if(dannraku==14)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==15)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==16)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
            if(dannraku==17)RawImage_TAKAHASHI.texture=TAKAHASI2D;
            if(dannraku==18)RawImage_TAKAHASHI.texture=TAKAHASI2D;
            if(dannraku==19)RawImage_TAKAHASHI.texture=Texture_TAKATUKA[0];
        }

        if((Input.GetKeyDown(KeyCode.Q)||st.serihuokuru>0)&&dannrakususumistop==0)dannraku++;
        if(Input.GetKeyDown(KeyCode.Q)||st.serihuokuru>0)
        {
                StartCoroutine(DisplayMessage());//←セリフ表示開始文　StartCoroutine(DisplayMessage());
                st.serihuokuru=0;
        }
            
         
        }
 
        if(Input.GetKeyDown(KeyCode.Space)&&serihucanvas.enabled == true)Saigo();//文章スキップ
    }

    IEnumerator DisplayMessage()
    {
        // 一文字ずつテキストに表示する
        for (int i = 0; i <= messageToDisplay.Length; i++)
        {
          
            displayText.text = messageToDisplay.Substring(0, i);
            sound.Koukaonn1();//音を鳴らしている
            yield return new WaitForSeconds(0.05f);//←プログラム読んでる最中に隙間時間入れる記述
            mati+=1;
        }
    }
    void Setmae()
    {
        mati=0;
        dannrakususumistop=0;//セリフ表示終了時に段落1の状態で終了してしまうのを防ぐためのストッパー
        canvas.enabled = false;//普段のキャンバスがついてたら消す  
        serihucanvas.enabled = true;//セリフキャンバス付ける
        if(st.storykaunnto==6)sound.BGM3_stop();
        if(st.storykaunnto==8)sound.BGM3_stop();
        if(st.storykaunnto==10)sound.BGM3_stop();
        if(st.storykaunnto==16)sound.BGM3_stop();
        if(st.storykaunnto==22)sound.BGM3_stop();
        
    }
    void Saigo()
    {
         setumei.enabled=false;
         sound.BGM2_stop();//👈会話中に流れるBGMをここに書く
         if(st.storykaunnto==0||st.storykaunnto==6||st.storykaunnto==8||st.storykaunnto==12||st.storykaunnto==18||st.storykaunnto==24)sound.BGM3_start();
         dannrakususumistop=1;//セリフ表示終了時に段落1の状態で終了してしまうのを防ぐためのストッパー
         canvas.enabled = true;//普段のキャンバス付ける 
         serihucanvas.enabled = false;//セリフキャンバス消す 
         messageToDisplay="";//
         displayText.text="";//
         kaiwaowari.transform.position+=transform.up/2;
         dannraku=0;//段落数をリセットする
         if(st.storykaunnto==0)haikei1.SetActive(!haikei1.activeSelf); // ←最初だけ(後ろ背景削除)
         if(st.susumiseigyo!=1)st.storykaunnto+=1;//ストーリーを進める(進めない場所だったら進めない)
         st.serihuokuru=0;//セリフリセット
         syu.i=0;//←最初だけ
         st.susumiseigyo=0;//進み制御ストッパー解除
         dannrakususumistop=1;//セリフ表示終了時に段落1の状態で終了してしまうのを防ぐためのストッパーcanvas.enabled ==true
         if(st.storykaunnto==7&&siraberu==1)pasCanvas.enabled=true;
        if(st.storykaunnto==1001)
        {
            st.storykaunnto=11;
            t.start=0;
            t.beatCount=0;
            t.i=1;
            t.ii=0;
           MoveImage(targetPosition);
        }
        if(st.storykaunnto==1501)
        {
            st.storykaunnto=17;
            t.start=0;
            t.beatCount=0;
            t.i=1;
            t.ii=0;
           MoveImage(targetPosition);
        }
        if(st.storykaunnto==2001)
        {
            st.storykaunnto=23;
            t.start=0;
            t.beatCount=0;
            t.i=1;
            t.ii=0;
           MoveImage(targetPosition);
        }

    }
     public void MoveImage(Vector2 newPosition)
   {
        RectTransform imageTransform = t.image1.GetComponent<RectTransform>();

        // 画像のRectTransformの座標を変更して指定位置に移動する
        imageTransform.anchoredPosition = newPosition;
    }
}

