using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameTimer : MonoBehaviour
{
     public float timeRemaining = 450f;
     public Text timer;

     // Update is called once per frame
     void Update()
     {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timer.text = Mathf.Floor(timeRemaining).ToString();
        }

        if (timeRemaining <= 0f)
        {
            timeRemaining = 45f;
            SceneManager.LoadScene("Level Main");
        }
     }
}