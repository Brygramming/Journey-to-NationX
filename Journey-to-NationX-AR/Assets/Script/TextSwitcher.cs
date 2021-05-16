using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSwitcher : MonoBehaviour
{
	[Header("Text Gameobjects")]
	public GameObject Gameobject1;
	public GameObject Gameobject2;

	//This will switch text by disabling gameobjects
	public bool[] Switcher;
	int SwitcherValue;

    void Start()
    {
        
    }

    void Update()
    {
    	//Switch Disabler
        if(Switcher[SwitcherValue] == true)
    	{
    		Gameobject1.SetActive(false);
    		Gameobject2.SetActive(true);
    	} 
    	else
    	{
    		Gameobject1.SetActive(true);
    		Gameobject2.SetActive(false);
    	}

    	//To prevent the array going out of range
    	if(SwitcherValue < 0)
    	{
    		SwitcherValue = 0;
    	}
    }

    public void NextButtonSwitch()
    {
    	SwitcherValue++;
    }

    public void PrevButtonSwitch()
    {
    	SwitcherValue--;
    }
}
