using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] TMP_Text dialogue;
    [SerializeField] string[] lines;

    private int currentDialogue = 0;

    DialogueLines instance;

    private void Awake()
    {
        instance = this;
    }

    public void StartFirstDialogue()
    {
        dialogue.text = lines[currentDialogue];
    }

    public void EmptyDialogue()
    {
        dialogue.text = "";
    }

    public void updateDialogue()
    {
        currentDialogue++;
        dialogue.text = lines[currentDialogue];
    }
}
