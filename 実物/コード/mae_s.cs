using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    public float detectionDistance = 10f; // レイキャストの距離

    void Update()
    {
        // 操作するオブジェクトの前方の方向を取得
        Vector3 direction = transform.forward;

        // レイキャストを実行
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, detectionDistance))
        {
            // レイキャストが何かに当たった場合の処理
            GameObject hitObject = hit.collider.gameObject;
            Debug.Log("Hit object: " + hitObject.name);
            // 必要な処理を追加します
        }
    }
}
