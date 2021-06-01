using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text scoreText;
    void Start()
    {

    }

    // Update is called once per frame
    void SetScore(){
        scoreText.text = player.position.z.ToString();
    }
}