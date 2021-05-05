using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{

    public Text DialogueText;
    public string[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;

    void Start()
    {
        
    }

    void NextSentence()
    {
        if (Index <= Sentences.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences());
        }
    }

    IEnumerator WriteSentences()
    {
        foreach (char Character in Sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
