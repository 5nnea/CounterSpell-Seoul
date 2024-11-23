using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UiManager : Singleton<UiManager>
{
    [SerializeField]GameObject gameUi;

    private RectTransform settingWindow;
    
    void Start(){
        settingWindow = gameUi.transform.GetChild(0).GetComponent<RectTransform>();
        DontDestroyOnLoad(gameUi);
    }

    //설정 창 보이기
    public void ShowSettingWindow(){
        settingWindow.DOAnchorPosY(0,0.3f);
    }

    //재시작
    public void Retry(){
        GameManager.Instance.ChangerScene(SceneManager.GetActiveScene().buildIndex);
    }
}
