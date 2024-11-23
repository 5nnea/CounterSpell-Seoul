using UnityEngine;

public class RightCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7.5f;
    public bool isKeyboardActive = false; // 키보드 조작 상태

    private Rigidbody2D rb;
    private Animator anim;
    private float move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // 키보드 이동 (A, D)
        move = Input.GetAxis("Horizontal");
        
        if (move != 0)
        {
            transform.Translate(new Vector3(move * moveSpeed * Time.deltaTime, 0, 0));

            if(move<0){
                anim.SetBool("C_Lwalking",true);
                anim.SetBool("C_Rwalking",false);
            }
            else if(move>0){
                anim.SetBool("C_Lwalking",false);
                anim.SetBool("C_Rwalking",true);
            }

            isKeyboardActive = true; // 키보드 조작 활성화
        }
        else
        {
            anim.SetBool("C_Lwalking",false);
            anim.SetBool("C_Rwalking",false);
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