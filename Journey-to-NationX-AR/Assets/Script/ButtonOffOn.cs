using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOffOn : MonoBehaviour
{
	public GameObject PartActive;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ParticleOffOn()
	{
		PartActive.SetActive(!PartActive.activeInHierarchy);
	}
}
