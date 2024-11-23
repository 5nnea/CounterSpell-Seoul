using UnityEngine;

[System.Serializable]
public class DialogueLine
{
    public string characterName; // 캐릭터 이름
    [TextArea(3, 10)] public string dialogueText; // 대사 내용
}

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/DialogueData")]
public class Dialogue : ScriptableObject
{
    public DialogueLine[] lines; // 대사 배열
}
