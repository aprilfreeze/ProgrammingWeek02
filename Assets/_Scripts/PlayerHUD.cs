using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHUD : MonoBehaviour
{
    private static PlayerHUD sInstance;
    //reset score
    public PlayerController youDied;

    public static PlayerHUD Instance
    {
        get
        {
            if (sInstance == null)
            {
                sInstance = FindObjectOfType<PlayerHUD>();
            }
            return sInstance;
        }
    }

    private int Score = 0;
    private Text ScoreField;

    private void Start()
    {
        GameObject go = GameObject.Find("Score");
        if(go != null)
        {
            ScoreField = go.GetComponent<Text>();
        }

        PlayerHUD.Instance.AdjustScore(0);
    }

    public void Update()
    {
        //reset score if dead
        if( GameObject.Find( "RollerBall" ).GetComponent<PlayerController>().isDead )
        {
            Debug.Log( "ya dead son" );
            if( Score != 0 )
            {
                Score = 0;
            }
            if( ScoreField != null )
            {
                ScoreField.text = "Score: " + Score;
            }
            GameObject dead = GameObject.FindGameObjectWithTag( "Player");
            youDied = dead.GetComponent<PlayerController>();
            youDied.isDead = false;
        }
    }

    public void AdjustScore(int value)
    {
        //otherwise score +- normally
        if( !GameObject.Find( "RollerBall" ).GetComponent<PlayerController>().isDead)
        {
            Debug.Log( "yay ur alive" );
            Score += value;
            if( ScoreField != null )
            {
                ScoreField.text = "Score: " + Score;
            }
        }
    }
}
