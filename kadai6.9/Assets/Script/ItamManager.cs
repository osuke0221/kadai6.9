using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemManager : MonoBehaviour
{
    public bool hasDriver = false;
    public bool hasKey = false;   // Å© Ç±ÇÍÇí«â¡ÅI

    public Image driverPopupImage;

    public void GetDriver()
    {
        if (hasDriver) return;

        hasDriver = true;
        StartCoroutine(ShowDriverPopup());
    }

    IEnumerator ShowDriverPopup()
    {
        driverPopupImage.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        driverPopupImage.gameObject.SetActive(false);
    }
}
