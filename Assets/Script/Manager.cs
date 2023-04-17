using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    
	public Text Result;
	public Text Akhir;
    public Image AIChoice;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors;

	public Text winText;
	public Text loseText;

	public GameObject win;
	public GameObject lose;

	public int winCount = 0;
	private int loseCount = 0;
    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch(randomChoice)
        {
            case "Rock":
                switch(myChoice)
                {
                    case "Rock":
                        Result.text = "Tie!";
                        break;

                    case "Paper":
                        Result.text = "The paper covers the rock, you win!";
				winCount = PlayerPrefs.GetInt ("skor") + 1;
				PlayerPrefs.SetInt ("skor", winCount);

				break;
				     
                    case "Scissors":
                        Result.text = "The rock destroys the scissors, you lose!";
				loseCount= PlayerPrefs.GetInt ("Pskor") + 1;
				PlayerPrefs.SetInt ("Pskor", loseCount);
                        break;

                    
                }

                AIChoice.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "The paper covers the rock, you lose!";
				loseCount= PlayerPrefs.GetInt ("Pskor") + 1;
				PlayerPrefs.SetInt ("Pskor", loseCount);
                        break;

                    case "Paper":
                        Result.text = "Tie!";
				        
                        break;
				      
                    case "Scissors":
                        Result.text = "The scissors cuts the paper, you win!";
				winCount = PlayerPrefs.GetInt ("skor") + 1;
				PlayerPrefs.SetInt ("skor", winCount);  
                        break;

                }

                AIChoice.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "The rock destroys the scissors, you win!";
				loseCount= PlayerPrefs.GetInt ("skor") + 1;
				PlayerPrefs.SetInt ("skor", loseCount);
                        break;

                    case "Paper":
                        Result.text = "The scissors cuts the paper, you win!";
				winCount = PlayerPrefs.GetInt ("Pskor") + 1;
				PlayerPrefs.SetInt ("Pskor", winCount);  
                        break;

                    case "Scissors":
                        Result.text = "Tie!";
                        break;

                }
			winText.text = winCount.ToString();
			loseText.text = loseCount.ToString();
                AIChoice.sprite = Scissors;
                break;

        }
		Akhir.text = "    "+winCount;

    }

}
