using UnityEngine;

public class LeftCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    Vector3 mousePosition;
    private Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // 마우스 좌클릭: 이동
        if (Input.GetMouseButton(0))
        {
            GameManager.Instance.isMouseActive = true; // 마우스 조작 활성화
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(GameManager.Instance.isKeyboardActive){
                if(mousePosition.x - transform.position.x <0){
                    anim.SetBool("P_Lwalking",true);
                    anim.SetBool("P_Rwalking",false);
                }
                else if(mousePosition.x - transform.position.x>0){
                    anim.SetBool("P_Lwalking",false);
                    anim.SetBool("P_Rwalking",true);
                }
                mousePosition.z = 0; // Z축 고정
                mousePosition.y = transform.position.y;
                transform.position = Vector3.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
            }

        }
        else
        {
            GameManager.Instance.isMouseActive = false; // 마우스 조작 비활성화
            anim.SetBool("P_Lwalking",false);
            anim.SetBool("P_Rwalking",false);
        }
    }
}