using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour{
	public Text TextTimer;
    // Start is called before the first frame update
	public float Waktu = 100;

	public bool GameAktif = true;
	public GameObject CanvasKalah;
        
	void SetText()
	{
		int menit = Mathf.FloorToInt(Waktu / 60);
		int detik = Mathf.FloorToInt(Waktu % 60);
		TextTimer.text = menit.ToString("00") +":"+ detik.ToString("00");
	}

	float s;
	private void Update()
	{
		if (GameAktif)
		{
		s += Time.deltaTime;
		if(s >= 1)
		{
			Waktu--;
			s =0;
		}
		}

			if(GameAktif && Waktu <=0)
			{
			Debug.Log("Game Kalah");
			CanvasKalah.SetActive(true);
				GameAktif = false;
			}


		SetText();

	}
}
