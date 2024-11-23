using UnityEngine;

public class RightCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7.5f;

    private Rigidbody2D rb;
    private Animator anim;
    private float move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D)||Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("키보드 눌림");
            GameManager.Instance.isKeyboardActive = true; // 키보드 조작 활성화
        }
        else{
            GameManager.Instance.isKeyboardActive = false; // 키보드 조작 활성화
        }

        // 키보드 이동 (A, D)
        move = Input.GetAxis("Horizontal");

        if (move != 0)
        {

            if(GameManager.Instance.isMouseActive){
                transform.Translate(new Vector3(move * moveSpeed * Time.deltaTime, 0, 0));

                if(move<0){
                    anim.SetBool("C_Lwalking",true);
                    anim.SetBool("C_Rwalking",false);
                }
                else if(move>0){
                    anim.SetBool("C_Lwalking",false);
                    anim.SetBool("C_Rwalking",true);
                }
            }
            else{
                anim.SetBool("C_Lwalking",false);
                anim.SetBool("C_Rwalking",false);
            }

        }
        else
        {
            anim.SetBool("C_Lwalking",false);
            anim.SetBool("C_Rwalking",false);
        }

        // 점프 (스페이스바)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.isKeyboardActive = true; // 점프 시에도 키보드 활성화
            
            if(GameManager.Instance.isMouseActive)
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

    }
}