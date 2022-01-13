using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour
{
    public bool readyToDestroy = false;
    public string floorTag = "Floor";
    public string tableTag = "table";
    public string paddleTag = "paddle";
    private AudioSource audioSource;
    public int contar;
    public int contarRobot;
    public Text scorePlayer;
    public Text scoreRobot;
    
     

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        float newVolume = 1f;  

        audioSource.volume = newVolume;
        audioSource.Play();

        if (collision.collider.tag == tableTag || collision.collider.tag == paddleTag)
        {
            addScore();
        }
        if (collision.collider.tag == paddleTag)
        {
            addScore();
        }
        if (collision.collider.tag == tableTag)
        {
            addScore();
        }

        if (collision.transform.tag == floorTag)
            readyToDestroy = true;
    }

     void addScore()
        {
        contar += 1;
        score.text = contar.ToString("0");
        }
    void addScoreRobot()
    {
        contarRobot += 1;
    }




}
