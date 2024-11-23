using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    Animator anim;
    [SerializeField]GameObject target;

    void Start(){
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(){
        anim.SetBool("pushBtn",true);
    }

    void OnTriggerExit2D(){
        anim.SetBool("pushBtn",false);
        target.gameObject.transform.DOMoveY(0,1.5f);
    }

    public void FinishEvents(){
        target.gameObject.transform.DOMoveY(-2,1.5f);
    }
}
