using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle paddle;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball);
       paddle paddle 1= Instantiate(paddle);
        paddle paddle 2= Instantiate(paddle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
