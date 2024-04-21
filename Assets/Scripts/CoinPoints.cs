using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinPoints : MonoBehaviour
{
    public static CoinPoints instance;

    public Text coinText;
    public int points = 0;
     private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start() {
        coinText.text = "Coins: " + points.ToString() + "/9";

    }

    public void AddCoins(){

        points += 1;
        coinText.text = "Coins: " + points.ToString() + "/9";
       
    }
    public void Update()
    {
        if (points >= 9)
        {
            SceneManager.LoadScene("Win");
        }
    }

}
