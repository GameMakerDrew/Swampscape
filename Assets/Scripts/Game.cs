using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private float score = 0f;





    public GameObject GlowBall;
    // Start is called before the first frame update
    void Start()
    {
       //InvokeRepeating("SpawnGlow", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore()
    {
        score += 1f;
    }

    public float getScore()
    {
        return score;
    }

    public string stringScore()
    {
        return score.ToString();
    }

    public void SpawnGlow()
    {

        float ranX = Random.Range(-323f, 331f);
        float ranZ = Random.Range(-330f, 318f);
        Vector3 randomPos = new Vector3(ranX, -1.96f, ranZ);
        Quaternion rotation = Quaternion.Euler(0f, 0f, 0f);
        Instantiate(GlowBall, randomPos, rotation);
        
    }

    public void Create()
    {

    }
}
