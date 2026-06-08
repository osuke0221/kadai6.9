using UnityEngine;

public class BoxClosedClick : MonoBehaviour
{
    public ItemManager itemManager;
    public GameObject boxClosed;
    public GameObject boxOpen;
    public GameObject keyInBox;

    void OnMouseDown()
    {
        Debug.Log("箱クリックされた！");

        if (itemManager.hasDriver)
        {
            boxClosed.SetActive(false);
            boxOpen.SetActive(true);
            keyInBox.SetActive(true);
        }
        else
        {
            Debug.Log("ドライバーが必要だ…");
        }
    }
}
