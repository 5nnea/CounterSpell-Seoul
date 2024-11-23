using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 따라갈 캐릭터
    public Vector3 offset;   // 카메라와 캐릭터 간 거리

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}