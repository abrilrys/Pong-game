using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeControl;

public class KeepTrackOfScoring : MonoBehaviour
{
    private int Paddle1score = 0;
    private int Paddle2score = 0;
    public Text scoreboard;
    public Text scoreboard2;
    // Start is called before the first frame update
    void Awake()
    {
        Message.AddListener<PointScored>(OnScore);
        scoreboard.text = Paddle2score.ToString();
        scoreboard2.text= Paddle1score.ToString();
    }

    void OnDestroy()
    {
        Message.RemoveListener<PointScored>(OnScore);
    }
    void OnScore(PointScored msg)
    {
        if (msg.player == "Paddle1")
        {
            Paddle1score++;
        }
        else
        {
            Paddle2score++;
        }
        Debug.Log(Paddle1score + "," + Paddle2score);
        scoreboard.text = Paddle2score.ToString();
        scoreboard2.text = Paddle1score.ToString();
    }
}