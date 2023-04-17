using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pskor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Pskor", 0);

	}

	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = PlayerPrefs.GetInt ("Pskor").ToString ();


	}
}
