using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttachDoor : MonoBehaviour
{
    Animator anim;
    void Start(){
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D target){
        if(target.CompareTag("pastPlayer"))
            anim.SetBool("doorOpen",true);
    }
    public void nextStage(){
        GameManager.Instance.ChangerScene(SceneManager.GetActiveScene().buildIndex+1);
    } 
}
