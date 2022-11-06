using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlscore : MonoBehaviour
{
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = gamescore.score.ToString();
    }
}
