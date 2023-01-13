using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreController : MonoBehaviour
{

    public Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "bomb")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "fruit")
        {
            Destroy(collision.gameObject);
            score++;
        }
    }
}
