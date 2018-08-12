using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCheck : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void OnCollisionEnter(Collision hit)
    {
        Debug.Log("collision");

        if (hit.gameObject.tag == "Star")
        {
            Destroy(hit.gameObject);
            score += 1;
            scoreText.text = "Star : " + score.ToString();
        }
    }
}
