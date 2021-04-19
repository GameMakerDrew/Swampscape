using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private Game game;
    private TextMeshProUGUI scoreText;
  

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindObjectOfType<Game>();

        scoreText = GetComponent<TMPro.TextMeshProUGUI>();
        scoreText.SetText(game.getScore().ToString());
     
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + game.getScore().ToString());
    }
}
