using UnityEngine;

public class LeftCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도
    public bool isMouseActive = false; // 마우스 조작 활성 상태

    Vector3 mousePosition;

    void Update()
    {
        // 마우스 좌클릭: 이동
        if (Input.GetMouseButton(0))
        {
            isMouseActive = true; // 마우스 조작 활성화
            
            Debug.Log("마우스 좌클릭");
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Z축 고정
            mousePosition.y = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);

        }
        else
        {
            isMouseActive = false; // 마우스 조작 비활성화
        }
    }
}