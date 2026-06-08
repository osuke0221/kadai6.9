using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject roomLeft;
    public GameObject roomCenter;
    public GameObject roomRight;

    int currentRoom = 1; // 0=左, 1=中央, 2=右

    void Start()
    {
        ShowRoom(currentRoom);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Input.mousePosition;

            // 画面右端をクリック
            if (pos.x > Screen.width * 0.85f)
            {
                MoveRight();
            }

            // 画面左端をクリック
            if (pos.x < Screen.width * 0.15f)
            {
                MoveLeft();
            }
        }
    }

    void MoveRight()
    {
        if (currentRoom < 2)
        {
            currentRoom++;
            ShowRoom(currentRoom);
        }
    }

    void MoveLeft()
    {
        if (currentRoom > 0)
        {
            currentRoom--;
            ShowRoom(currentRoom);
        }
    }

    void ShowRoom(int index)
    {
        roomLeft.SetActive(index == 0);
        roomCenter.SetActive(index == 1);
        roomRight.SetActive(index == 2);
    }
}
