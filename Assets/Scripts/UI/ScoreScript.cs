using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {

    public static ScoreScript instance;

    public Text scoreText;
    int score = 0;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start() {
        scoreText.text = "Bots Fixed: " + score.ToString() + "/4";

    }

    public void AddPoint(){

        score += 1;
        scoreText.text = "Bots Fixed: " + score.ToString() + "/4";
       
    }
    public void Update()
    {
        if (score >= 4)
        {
            SceneManager.LoadScene("Win");
        }
    }
}

