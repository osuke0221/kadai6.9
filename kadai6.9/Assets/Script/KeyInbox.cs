using UnityEngine;

public class KeyClick : MonoBehaviour
{
    public ItemManager itemManager;

    void OnMouseDown()
    {
        Debug.Log("鍵クリックされた！");
        itemManager.hasKey = true;
        gameObject.SetActive(false);
    }
}
