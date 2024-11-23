using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    public Transform target; // 따라갈 캐릭터
    public Vector2 minBounds; // 카메라 이동 제한 최소값
    public Vector2 maxBounds; // 카메라 이동 제한 최대값

    void LateUpdate()
    {
        if (target != null)
        {
            float clampedX = Mathf.Clamp(target.position.x, minBounds.x, maxBounds.x);
            float clampedY = Mathf.Clamp(target.position.y, minBounds.y, maxBounds.y);
            transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    }
}
