using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public string sceneName; // 切り替えるシーンの名前

    void Update()
    {
        // エンターキーが押されたら
    }
    public void GAME()
    {
         SceneManager.LoadScene(sceneName);//GAME開始する
    }
}
