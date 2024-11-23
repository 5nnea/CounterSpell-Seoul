using UnityEngine;

public class PastCharacterController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        if (Input.GetMouseButton(0)) // 마우스 좌클릭
        {
            Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }
}