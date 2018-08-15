using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCheck : MonoBehaviour
{
    public Text playerScoreText;
    public Text loseGameScoreText;

    public int playerScore = 0;

    public ImprovedCarMovement movement;

    public GameObject loselevelPanel;
    public GameObject duringGamePanel;


    private void Awake()
    {
        loselevelPanel.SetActive(false);
        duringGamePanel.SetActive(true);

    }
    void OnCollisionEnter(Collision hit)
    {
        Debug.Log("collision");

        if (hit.gameObject.tag == "Gift")
        {
            Destroy(hit.gameObject);
            playerScore += 1;
            playerScoreText.text = "Gifts : " + playerScore.ToString();
        }
        else if (hit.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
            loselevelPanel.SetActive(true);
            duringGamePanel.SetActive(false);
            loseGameScoreText.text = "Total Score : " + playerScore.ToString();
        }
    }

}
