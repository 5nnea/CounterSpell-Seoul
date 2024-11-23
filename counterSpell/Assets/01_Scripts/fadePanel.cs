using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadePanel : MonoBehaviour
{
    private Animator fade;

    void Awake(){
        fade = this.gameObject.GetComponent<Animator>();
    }

    public void FadeOut(){
        this.gameObject.SetActive(true);
        fade.SetBool("fadeOut",true);
    }

    public void FadeIn(){
        fade.SetBool("fadeOut",false);
        SceneManager.LoadScene(GameManager.Instance.nextSceneNum);
        fade.SetBool("fadeIn",true);
    }

    public void FinishFade(){
        fade.SetBool("fadeIn",false);
        this.gameObject.SetActive(false);
    }
}
