using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    public Text TEXT;
    void Start()
    {
        score = 0;
        TEXT.text = score.ToString()
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void UpdateScore()
    {
        score++;
        TEXT.text = score.ToString()
    }
}
