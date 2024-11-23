using UnityEditor;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int nextSceneNum;

    [SerializeField] FadePanel fadePanel;
    [SerializeField] GameObject canvas;

    void Start(){
        DontDestroyOnLoad(canvas);
    }
    public void ChangerScene(int num){
        fadePanel.FadeOut();
        nextSceneNum = num;
    }
}
