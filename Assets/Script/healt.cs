using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healt : MonoBehaviour
{
	private Image HealtBar;
	public float CurrentHealt;
	private float MaxHealth = 100f;

	Manager Play;

    // Start is called before the first frame update
    void Start()
    {
        
		HealtBar = GetComponent<Image>();
		Play = FindObjectOfType<Manager>();

    }

    // Update is called once per frame
    private void Update()
    {
		
    }
}
