using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorClick : MonoBehaviour
{
    public ItemManager itemManager;   // 鍵を持っているか確認
    public string nextSceneName;      // 移動先のシーン名

    void OnMouseDown()
    {
        Debug.Log("ドアがクリックされた！");

        if (itemManager.hasKey)
        {
            Debug.Log("鍵を使ってドアを開ける！");
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.Log("鍵が必要だ…");
        }
    }
}
