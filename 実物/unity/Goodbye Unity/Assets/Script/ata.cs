using UnityEngine;

public class ata : MonoBehaviour
{
    public float detectionDistance = 10f; // レイキャストの距離

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))//アイテム取得ボタン押したとき※Returnはエンターキーを示す
        {
        // 操作するオブジェクトの前方の方向を取得
        Vector3 direction = transform.forward;

        // レイキャストを実行
        RaycastHit hit;
      

            if (Physics.Raycast(transform.position, direction, out hit, detectionDistance))//←このIf分の中にアイテムゲットの処理を書いてる
            {
                // レイキャストが何かに当たった場合の処理
                GameObject hitObject = hit.collider.gameObject;
                Debug.Log("Hit object: " + hitObject.name);//←アイテム取得した時に実行されるプログラム
                // 必要な処理を追加します
            }
        }

    }
}

