using UnityEngine;

public class SplitScreenSetup : MonoBehaviour
{
    public Camera pastCamera;    // 과거 캐릭터 카메라
    public Camera currentCamera; // 현재 캐릭터 카메라

    void Start()
    {
        // 왼쪽 화면 (과거 캐릭터)
        pastCamera.rect = new Rect(0, 0, 0.5f, 1);

        // 오른쪽 화면 (현재 캐릭터)
        currentCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
    }
}
