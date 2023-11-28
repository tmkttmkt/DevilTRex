using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pasward : MonoBehaviour
{
   
   
    [SerializeField] GameObject pass1;
    public GameObject plyerrr;
    float detectionRadius = 5f;
    bool pass_flg=false, isPlayerNear;
    public Text t1;
    public Text t2;
    public Text t3;
    public Text t4;
    public Text t5;
    public int suuzi1 = 0;
    public int suuzi2 = 0;
    public int suuzi3 = 0;
    public int suuzi4 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isPlayerNear = IsPlayerNear();
        // エンターキーが押されたら白い画面を表示
        if (isPlayerNear == true && Input.GetKeyDown(KeyCode.I) && !pass_flg)
        {

            t5.text = "Gキーで黒いところに止めろ!";
            pass_flg = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            pass1.SetActive(pass_flg);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            t5.text = "もうやめるのか？";
            Invoke("Owari", 3.5f);

        }



  
    }
        bool IsPlayerNear()
        {

            // プレイヤーオブジェクトが存在しない場合はプレイヤーは近くにいないと判定
            float disY = Mathf.Abs(plyerrr.transform.position.y - this.transform.position.y);
            if (disY <= 3F)
            {
                // プレイヤーとの距離が検出半径以内かどうかを判定
                float distanceToPlayer = Vector3.Distance(transform.position, plyerrr.transform.position);
                return distanceToPlayer <= detectionRadius;
            }
            return false;
            // "Player"タグを持つオブジェクトを検索
        }
    /*public void onClick()
    {
        Debug.Log("afshfgyauiufdafdyadwatfwdtfwtfatrdftwadfu7tf");
        suuzi1 += 1;
        if (suuzi1 == 10)
        {
            suuzi1 = 0;
        }
        t1.text = t1.ToString();
    }
    public void onClick2()
    {
        Debug.Log("afshfgyauiufdafdyadwatfwdtfwtfatrdftwadfu7tf");
        suuzi2 += 1;
        if (suuzi2 == 10)
        {
            suuzi2 = 0;
        }
        t2.text = t2.ToString();
    }
    public void onClick3()
    {
        Debug.Log("afshfgyauiufdafdyadwatfwdtfwtfatrdftwadfu7tf");
        suuzi3 += 1;
        if (suuzi3 == 10)
        {
            suuzi3 = 0;
        }
        t3.text = t3.ToString();
    }
    public void onClick4()
    {
        Debug.Log("afshfgyauiufdafdyadwatfwdtfwtfatrdftwadfu7tf");
        suuzi4 += 1;
        if (suuzi4 == 10)
        {
            suuzi4 = 0;
        }
        t4.text = t4.ToString();
    }*/
    public void Owari()
    {
        pass_flg = false;
        pass1.SetActive(pass_flg);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void reset()
    {
        t4.text = "0";
        t3.text = "0";
        t2.text = "0";
        t1.text = "0";
    }
    public void kettei()
    {
        if (t1.text == "0" && t2.text == "0" && t3.text == "0" && t4.text == "0" )
        {
            Debug.Log("OK");
        }
        else
        {
            Debug.Log("NO");
        }
        
    }

}
