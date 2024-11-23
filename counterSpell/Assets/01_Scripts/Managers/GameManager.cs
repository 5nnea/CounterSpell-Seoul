using UnityEditor;
using UnityEngine;
using DG.Tweening;

public class GameManager : Singleton<GameManager>
{
    public int nextSceneNum;
    public bool isPause = false;
    public bool isKeyboardActive = false;
    public bool isMouseActive = false;

    [SerializeField] FadePanel fadePanel;
    [SerializeField] GameObject canvas;

    void Start(){
        DontDestroyOnLoad(canvas);
    }

    public void ChangerScene(int num){
        UiManager.Instance.settingWindow.DOAnchorPosY(1100,0.3f);
        fadePanel.FadeOut();
        nextSceneNum = num;
    }

}
