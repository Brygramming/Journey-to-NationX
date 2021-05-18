using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{
    //This is where text writes
    [Header("Text Dialogues")]
    public Text DialogueTextPage1;
    public Text DialogueTextPage2;
    public Text DialogueTextPage3;
    public string[] Sentences;
    private int Index = 0;
    [Range(0f, 1f)]
    public float DialogueSpeed;

    void Start()
    {
        //Canvas.ForceUpdateCanvases();
    }

    public void NextSentence()
    {
        Index++;
        if (Index <= Sentences.Length - 1)
        {
            DialogueTextPage1.text = "";
            DialogueTextPage2.text = "";
            DialogueTextPage3.text = "";
            StartCoroutine(WriteSentences());
        }
        //MoveCanvas();
    }
    public void PrevSentence()
    {
        Index--;
        DialogueTextPage1.text = "";
        DialogueTextPage2.text = "";
        DialogueTextPage3.text = "";
        StartCoroutine(WriteSentences());
    }

    IEnumerator WriteSentences()
    {
        foreach (char Character in Sentences[Index].ToCharArray())
        {
            DialogueTextPage1.text += Character;
            DialogueTextPage2.text += Character;
            DialogueTextPage3.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        //Index++;
    }

    void Update()
    {
        //To prevent array going out of range
        if(Index < 0)
        {
            Index = 0;
        }
    }

    /*void MoveCanvas()
    {
        if(Index == 1)
        {
            MainDialogue.transform.position = new Vector3(0.5f, 0, 0);
        }
    }*/
}
