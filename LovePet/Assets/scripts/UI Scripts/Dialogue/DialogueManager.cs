using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
        

    private Queue<string> sentences;


    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting Conversation with" + dialogue.NPCname);

        nameText.text = dialogue.NPCname;

        sentences.Clear();



        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }


        DisplayNextSentence();


    }


    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);

        dialogueText.text = sentence;

    }


    void EndDialogue()
    {
        Debug.Log("End of convo.");
    }


}
