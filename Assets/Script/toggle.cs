using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
	public AudioSource BackSound;
	public void backsoundOnOff(){
		AudioSource bgsound = BackSound.GetComponent<AudioSource> ();
		if (bgsound.mute == true){
			bgsound.mute = false;
		}else{
			bgsound.mute = true;
		
		}
	}
}
