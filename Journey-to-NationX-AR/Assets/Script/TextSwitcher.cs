using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSwitcher : MonoBehaviour
{
	[Header("UI Gameobjects Page 1")]
    public GameObject NarratorDialogueUI;
	public GameObject HeroDialogueUI;
    public GameObject BeggarSpyDialogueUI;

    [Header("UI Gameobjects Page 2")]
    public GameObject NarratorDialogueUITwo;
    public GameObject HeroDialogueUITwo;
    public GameObject BeggarSpyDialogueUITwo;

    [Header("UI Gameobjects Page 1")]
    public GameObject NarratorDialogueUIThree;
    public GameObject HeroDialogueUIThree;
    public GameObject BeggarSpyDialogueUIThree;

	//This will switch text by disabling gameobjects
    [Header("Array Value")]
    [SerializeField] int SwitcherValue;
	public bool[] Switcher;

    void Start()
    {
        
    }

    void Update()
    {
        SwitchDisablerOne();
        SwitchDisablerTwo();
        SwitchDisablerThree();

    	//To prevent the array going out of range
    	if(SwitcherValue < 0)
    	{
    		SwitcherValue = 0;
    	}
    }

    //For The buttons
    public void NextButtonSwitch()
    {
    	SwitcherValue++;
    }

    public void PrevButtonSwitch()
    {
    	SwitcherValue--;
    }

    //Disable Gameobjects Page One
    void SwitchDisablerOne()
    {
        if(Switcher[SwitcherValue] == true)
        {
            //Beggar's Dialogue
            if(SwitcherValue == 8 || SwitcherValue == 9 || SwitcherValue == 10 || SwitcherValue == 11)
            {
                HeroDialogueUI.SetActive(false);
                NarratorDialogueUI.SetActive(false);
                BeggarSpyDialogueUI.SetActive(true);
            }
            else
            {
                HeroDialogueUI.SetActive(false);
                BeggarSpyDialogueUI.SetActive(false);
                NarratorDialogueUI.SetActive(true);
            }
        }
        else
        {
            HeroDialogueUI.SetActive(true);
            BeggarSpyDialogueUI.SetActive(false);
            NarratorDialogueUI.SetActive(false);
        }

        //Turn Dialogue off on Page 1
        if(SwitcherValue >= 13)
        {
            HeroDialogueUI.SetActive(false);
            BeggarSpyDialogueUI.SetActive(false);
            NarratorDialogueUI.SetActive(false);
        }
    }

    //Disable Gameabjects Page Two
    void SwitchDisablerTwo()
    {
        if(Switcher[SwitcherValue] == true)
        {
            //Spy's Dialogue
            if(SwitcherValue == 17 || SwitcherValue == 18 || SwitcherValue == 19 || SwitcherValue == 20)
            {
                HeroDialogueUITwo.SetActive(false);
                NarratorDialogueUITwo.SetActive(false);
                BeggarSpyDialogueUITwo.SetActive(true);
            }
            else
            {
                HeroDialogueUITwo.SetActive(false);
                BeggarSpyDialogueUITwo.SetActive(false);
                NarratorDialogueUITwo.SetActive(true);
            }
        }
        else
        {
            HeroDialogueUITwo.SetActive(true);
            BeggarSpyDialogueUITwo.SetActive(false);
            NarratorDialogueUITwo.SetActive(false);
        }
    }

    //Disable Gameobjects Page Three
    void SwitchDisablerThree()
    {
        if(Switcher[SwitcherValue] == true)
        {
            //Fisherman's Dialogue
            if(SwitcherValue == 24 || SwitcherValue == 25 || SwitcherValue == 26 || SwitcherValue == 27)
            {
                HeroDialogueUIThree.SetActive(false);
                NarratorDialogueUIThree.SetActive(false);
                BeggarSpyDialogueUIThree.SetActive(true);
            }
            else
            {
                HeroDialogueUIThree.SetActive(false);
                BeggarSpyDialogueUIThree.SetActive(false);
                NarratorDialogueUIThree.SetActive(true);
            }
        }
        else
        {
            HeroDialogueUIThree.SetActive(true);
            BeggarSpyDialogueUIThree.SetActive(false);
            NarratorDialogueUIThree.SetActive(false);
        }

        //Turn Dialogue Off on Page 2
        if(SwitcherValue >= 22)
        {
            HeroDialogueUITwo.SetActive(false);
            BeggarSpyDialogueUITwo.SetActive(false);
            NarratorDialogueUITwo.SetActive(false);
        }
    }
}
