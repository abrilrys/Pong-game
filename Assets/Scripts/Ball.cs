using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeControl;
public class Ball : MonoBehaviour
{

    public Text scoreboard;
    public Text scoreboard2;
    private int score;
    private int score2;
    [SerializeField]
    float speed;

    public float radius;
    public Vector2 direction;
    
    Rigidbody2D m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
        m_Rigidbody.velocity = transform.right * speed;
        score = 0;
        scoreboard.text = score.ToString();
        score2 = 0;
        scoreboard2.text = score2.ToString();

    }

     void OnTriggerEnter2D(Collider2D other)
    {
        this.transform.position = new Vector3(0f, 0f, 0f);
        if (other.tag == "WallRight")
        {
            Message.Send(new PointScored("Paddle1"));
            
        }
        if (other.tag == "WallLeft")
        {
            Message.Send(new PointScored("Paddle2"));
            
        }
       
    }
}
