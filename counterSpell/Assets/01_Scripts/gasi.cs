using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gasi : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target){
        if(target.CompareTag("pastPlayer")){
            GameManager.Instance.ChangerScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
