using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TriggerTest: MonoBehaviour
{
    public Text textcounter;
    public int Score = 100;

    private void OnTriggerEnter(Collider collider)
    {
        Score -= 1;
        textcounter.text = Score.ToString();
    }
}
