using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    Animator anim;
    [SerializeField]GameObject target;

    [SerializeField]float currentX;
    [SerializeField]float currentY;

    [SerializeField]float x;
    [SerializeField]float y;
    [SerializeField]float time;

    void Start(){
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(){
        anim.SetBool("pushBtn",true);
    }

    void OnTriggerExit2D(){
        anim.SetBool("pushBtn",false);
        target.gameObject.transform.DOMove(new Vector3(currentX,currentY,0),1.5f);
    }

    public void FinishEvents(){
        target.gameObject.transform.DOMove(new Vector3(x,y,0),time).SetAutoKill(false);
    }
}
