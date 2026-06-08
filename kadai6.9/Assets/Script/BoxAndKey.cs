using UnityEngine;

public class BoxAndKey : MonoBehaviour
{
    public ItemManager itemManager; // ドライバー所持を確認するため
    public GameObject boxClosed;
    public GameObject boxOpen;
    public GameObject keyInBox;

    public bool hasKey = false;

    void Start()
    {
        boxOpen.SetActive(false);
        keyInBox.SetActive(false);
    }

    void OnMouseDown()
    {
        // 箱をクリックしたとき
        if (gameObject == boxClosed)
        {
            TryOpenBox();
            Debug.Log("空いた");
        }

        // 鍵をクリックしたとき
        if (gameObject == keyInBox)
        {
            GetKey();
        }
    }

    void TryOpenBox()
    {
        if (itemManager.hasDriver)
        {
            boxClosed.SetActive(false);
            boxOpen.SetActive(true);
            keyInBox.SetActive(true);

            Debug.Log("箱を開けた！");
        }
        else
        {
            Debug.Log("ドライバーが必要だ…");
        }
    }

    void GetKey()
    {
        hasKey = true;
        keyInBox.SetActive(false);

        Debug.Log("鍵を手に入れた！");
    }
}
