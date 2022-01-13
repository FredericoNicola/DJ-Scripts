using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{

    public Text text;
    private int contar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = contar.ToString("0");
    }
    public void addScore()
    {
        contar += 1;     
    }
}
