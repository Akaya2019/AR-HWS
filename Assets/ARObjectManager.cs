using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; // UI bile�enlerini kullanmak i�in gerekli

public class ARObjectManager : MonoBehaviour
{
    public GameObject stationaryObject;
    public GameObject animatedObject;
    public GameObject moveableObject;

    // UI butonlar� i�in referanslar
    public Button getStationaryButton;
    public Button getAnimatedButton;
    public Button getMoveableButton;

    //public Toggle moveToggle;

/*    void Update()
    {
        if (moveToggle.isOn)
        {
            // Robotun yatay eksende (sa�a do�ru) hareket etmesini sa�layan kod
            moveableObject.transform.Translate(Vector3.right * Time.deltaTime);

            // E�er robotun di�er eksenlerde de hareket etmesini istiyorsan�z, a�a��daki kodlar� kullanabilirsiniz:

            // Robotun dikey eksende (yukar� do�ru) hareket etmesi
            // robotModel.transform.Translate(Vector3.up * Time.deltaTime);

            // Robotun derinlik eksende (ileri do�ru) hareket etmesi
            moveableObject.transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
*/


    void Start()
    {
        // Butonlara t�klama olaylar�n� atama
        getStationaryButton.onClick.AddListener(ShowStationaryObject);
        getAnimatedButton.onClick.AddListener(ShowAnimatedObject);
        getMoveableButton.onClick.AddListener(ShowMoveableObject);
    }

    // Hareketsiz nesneyi g�ster
    void ShowStationaryObject()
    {
        stationaryObject.SetActive(true);
        animatedObject.SetActive(false);
        moveableObject.SetActive(false);
    }

    // Animasyonlu nesneyi g�ster
    void ShowAnimatedObject()
    {
        stationaryObject.SetActive(false);
        animatedObject.SetActive(true);
        moveableObject.SetActive(false);
    }

    // Hareketli nesneyi g�ster
    void ShowMoveableObject()
    {
        stationaryObject.SetActive(false);
        animatedObject.SetActive(false);
        moveableObject.SetActive(true);
    }
}

