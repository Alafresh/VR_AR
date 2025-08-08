using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    [SerializeField] string url;
    void OnMouseDown() {
        Application.OpenURL(url);
    }
}
