using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    public GameObject myhealth;
    public GameObject spawner;
    public AudioSource music;
    public GameObject winText;
    public GameObject instructions;
    public GameObject help;
    public GameObject CoinSpawn;


    void Start()
    {
        hp = 10;
        myhealth.GetComponent<Text>().text = "Health:" + hp;
        
    }


    void Update()
    {
        myhealth.GetComponent<Text>().text = "Health:" + hp;
       if (hp <= 0) 
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("see lõpetab mängu");
        }
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            help.SetActive(true);
            
            
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            help.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            CoinSpawn.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            CoinSpawn.SetActive(false);
        }



    }
    private void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.tag == "danger")
        {
            hp--;
            music.Play();


        }
        if (collision.gameObject.tag == "finish")
        {
            spawner.SetActive(true);
            winText.SetActive(true);
            instructions.SetActive(true);
            


        }

    }
    
}
