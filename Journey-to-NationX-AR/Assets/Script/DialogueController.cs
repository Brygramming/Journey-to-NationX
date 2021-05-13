using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{
    /*[Header("Canvas")]
    public Canvas MainDialogue;
    public Vector3 DialoguePosition;*/

    [Header("Texts")]
    public Text DialogueText;
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
            DialogueText.text = "";
            StartCoroutine(WriteSentences());
        }
        //MoveCanvas();
    }
    public void PrevSentence()
    {
        Index -= 2;
        DialogueText.text = "";
        StartCoroutine(WriteSentences());
    }

    IEnumerator WriteSentences()
    {
        foreach (char Character in Sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
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
