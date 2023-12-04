using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; // UI bileþenlerini kullanmak için gerekli

public class ARObjectManager : MonoBehaviour
{
    public GameObject stationaryObject;
    public GameObject animatedObject;
    public GameObject moveableObject;

    // UI butonlarý için referanslar
    public Button getStationaryButton;
    public Button getAnimatedButton;
    public Button getMoveableButton;

    //public Toggle moveToggle;

/*    void Update()
    {
        if (moveToggle.isOn)
        {
            // Robotun yatay eksende (saða doðru) hareket etmesini saðlayan kod
            moveableObject.transform.Translate(Vector3.right * Time.deltaTime);

            // Eðer robotun diðer eksenlerde de hareket etmesini istiyorsanýz, aþaðýdaki kodlarý kullanabilirsiniz:

            // Robotun dikey eksende (yukarý doðru) hareket etmesi
            // robotModel.transform.Translate(Vector3.up * Time.deltaTime);

            // Robotun derinlik eksende (ileri doðru) hareket etmesi
            moveableObject.transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
*/


    void Start()
    {
        // Butonlara týklama olaylarýný atama
        getStationaryButton.onClick.AddListener(ShowStationaryObject);
        getAnimatedButton.onClick.AddListener(ShowAnimatedObject);
        getMoveableButton.onClick.AddListener(ShowMoveableObject);
    }

    // Hareketsiz nesneyi göster
    void ShowStationaryObject()
    {
        stationaryObject.SetActive(true);
        animatedObject.SetActive(false);
        moveableObject.SetActive(false);
    }

    // Animasyonlu nesneyi göster
    void ShowAnimatedObject()
    {
        stationaryObject.SetActive(false);
        animatedObject.SetActive(true);
        moveableObject.SetActive(false);
    }

    // Hareketli nesneyi göster
    void ShowMoveableObject()
    {
        stationaryObject.SetActive(false);
        animatedObject.SetActive(false);
        moveableObject.SetActive(true);
    }
}

