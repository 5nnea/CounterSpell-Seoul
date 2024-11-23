using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public LeftCharacterController leftController; // LeftCharacterController 인스턴스
    public RightCharacterController rightController; // RightCharacterController 인스턴스

    void Update()
    {
        // 마우스와 키보드가 동시에 활성화된 경우에만 캐릭터 움직임 허용
        if (leftController.isMouseActive && rightController.isKeyboardActive)
        {
            leftController.enabled = true;
            rightController.enabled = true;
        }
        else
        {
            leftController.enabled = false;
            rightController.enabled = false;
        }
    }
}
