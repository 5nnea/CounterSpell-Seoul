using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System;
using System.Collections;
using TMPro;

public class UiManager : Singleton<UiManager>
{
    [SerializeField]TMP_Text stageText;
    [SerializeField]GameObject retryBtn;
    [SerializeField]GameObject UiCanvas;

    public RectTransform settingWindow;
    
    void Start(){
        stageText.text = "";
        settingWindow = UiCanvas.transform.GetChild(0).GetComponent<RectTransform>();
    }

    //설정 창 보이기
    public void ShowSettingWindow(){
        if(GameManager.Instance.isPause == false){   
            settingWindow.DOAnchorPosY(0,0.3f);
        }
    }

    //재시작
    public void Retry(){
        if(GameManager.Instance.isPause == false){
            GameManager.Instance.ChangerScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ShowStageNum(){
        stageText.text = "stage " + SceneManager.GetActiveScene().buildIndex.ToString();
        stageText.rectTransform.DOAnchorPosY(700,0f);
        stageText.rectTransform.DOAnchorPosY(0,0.6f).SetEase(Ease.OutBack).OnComplete(HideStageNum);
    }
    private void HideStageNum(){
        Invoke("degi",1f);
    }
    private void degi(){
        stageText.rectTransform.DOAnchorPosY(-700,0.3f);
        GameManager.Instance.isPause = false;
    }
  

}
