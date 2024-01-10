using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour, IPointerClickHandler
{
    private Scene s;
    public AudioSource i;
     public AudioSource BGM;
  
    void Start()
    {
        s=FindObjectOfType<Scene>();
        i.Stop();
      
    }
    public void OnPointerClick(PointerEventData eventData)//ボタンが押されたらゲーム開始
    {
        s.GAME(); 
        i.Play();
        BGM.Stop();
   
    
    }
}