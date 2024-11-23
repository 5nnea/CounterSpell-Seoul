using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    public bool isPastCharacter = false; // 과거 캐릭터 여부

    private Rigidbody2D rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isPastCharacter)
        {
            HandleMouseMovement(); // 과거 캐릭터: 마우스 조작
        }
        else
        {
            HandleKeyboardMovement(); // 현재 캐릭터: 키보드 조작
        }
    }

    void HandleKeyboardMovement()
    {
        float move = Input.GetAxis("Horizontal"); // A, D 키
        transform.Translate(Vector2.right * move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void HandleMouseMovement()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 좌클릭: 이동
        {
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0; // 2D라 Z 값은 0으로 고정
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        if (Input.GetMouseButtonDown(1)) // 마우스 우클릭: 순간 이동
        {
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0;
            transform.position = targetPosition;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
