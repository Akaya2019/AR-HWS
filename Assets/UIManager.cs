using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject imagePrefab; // Görüntü prefab'ý
    public GameObject videoPrefab; // Video prefab'ý

    // Görüntüyü göster/gizle
    public void ToggleImage()
    {
        imagePrefab.SetActive(!imagePrefab.activeSelf);
    }

    // Videoyu göster/gizle
    public void ToggleVideo()
    {
        videoPrefab.SetActive(!videoPrefab.activeSelf);
    }
}
