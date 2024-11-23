using UnityEngine;

public class SplitScreenCamera : MonoBehaviour
{
    public Camera pastCamera;
    public Camera presentCamera;

    void Start()
    {
        // 화면 분할 설정
        pastCamera.rect = new Rect(0, 0, 0.5f, 1); // 왼쪽 절반
        presentCamera.rect = new Rect(0.5f, 0, 0.5f, 1); // 오른쪽 절반
    }
}
