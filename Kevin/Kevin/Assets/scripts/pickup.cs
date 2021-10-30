using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public int score;
    public AudioSource music;
    public GameObject scoreText;
    //public int health;

    // Start is called before the first frame update
    void Start()
    { score = 0;
        scoreText.GetComponent<Text>().text = "score" + score;
        //health=100;
    }

    // Update is called once per frame
    void Update()
    {

    }

     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            
            music.Play();
            Destroy(collision.gameObject);
            score++;
            scoreText.GetComponent<Text>().text = "score" + score;
        }
    }
  
} 

