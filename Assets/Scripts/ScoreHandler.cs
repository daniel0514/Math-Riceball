using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {
    Text scoreText;
	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        int curScore = ResultAndOpsHandler.result;
        scoreText.text = "Your Score is : " +  curScore.ToString();
        if (PlayerPrefs.HasKey("HighestScore"))
        {
            int highestScore = PlayerPrefs.GetInt("HighestScore");

            if (curScore == highestScore)
            {
                Debug.Log("Beat HighestScore");
                Debug.Log("Cur: " + curScore + " high" + highestScore);
                scoreText.text = scoreText.text + "Highest Score: " + highestScore +  "\n\n Almost Beat Your Highest Score!";
            } else
            {
                Debug.Log("Did not beat");
                Debug.Log("Cur: " + curScore + " high" + highestScore);
                scoreText.text = scoreText.text + "\nYou Almost Beat Your \nHighest Score!\nHighest Score: " + highestScore;
            }
        }
    }
}
