using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text characterNameText; // 캐릭터 이름 UI
    public Text dialogueText;      // 대사 텍스트 UI
    public Button nextButton;      // 다음 버튼
    public Dialogue dialogueData;  // 대사 데이터

    private int currentLineIndex = 0; // 현재 대사 인덱스

    void Start()
    {
        nextButton.onClick.AddListener(NextDialogue); // 버튼 클릭 이벤트
        ShowDialogue(); // 첫 대사 출력
    }

    void ShowDialogue()
    {
        if (currentLineIndex < dialogueData.lines.Length)
        {
            // 현재 대사 출력
            characterNameText.text = dialogueData.lines[currentLineIndex].characterName;
            dialogueText.text = dialogueData.lines[currentLineIndex].dialogueText;
        }
        else
        {
            // 대사가 끝났을 때
            Debug.Log("대화 종료");
            nextButton.gameObject.SetActive(false); // 버튼 비활성화
        }
    }

    public void NextDialogue()
    {
        currentLineIndex++;
        ShowDialogue();
    }
}
