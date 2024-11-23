using UnityEngine;

public class RightCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7.5f;
    public bool isKeyboardActive = false; // 키보드 조작 상태

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 키보드 이동 (A, D)
        float move = Input.GetAxis("Horizontal");
        if (move != 0)
        {
            transform.Translate(new Vector3(move * moveSpeed * Time.deltaTime, 0, 0));
            isKeyboardActive = true; // 키보드 조작 활성화
        }
        else
        {
            isKeyboardActive = false; // 키보드 조작 비활성화
        }

        // 점프 (스페이스바)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isKeyboardActive = true; // 점프 시에도 키보드 활성화
        }

        
    }
}