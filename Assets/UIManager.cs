using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject imagePrefab; // G�r�nt� prefab'�
    public GameObject videoPrefab; // Video prefab'�

    // G�r�nt�y� g�ster/gizle
    public void ToggleImage()
    {
        imagePrefab.SetActive(!imagePrefab.activeSelf);
    }

    // Videoyu g�ster/gizle
    public void ToggleVideo()
    {
        videoPrefab.SetActive(!videoPrefab.activeSelf);
    }
}
