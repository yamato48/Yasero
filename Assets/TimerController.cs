using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    private GameObject timeText;
    private GameObject enemy;

    private int minite = 0;
    private float second = 0;
    private int oldSecond = 0;



    // Use this for initialization
    void Start () {

        timeText = GameObject.Find("Timer");
        enemy = GameObject.Find("EnemyGenerator") as GameObject;

    }

// Update is called once per frame
void Update () {

        second += Time.deltaTime;
        if (second >= 60.0f)
        {
            minite++;
            second = second - 60;
        }

        GetComponent<Text>().text = minite.ToString("00") + ":" + second.ToString("00");

        if (second >= 10.0f)
        {
           // enemy.gameObject.GetComponent<EnemyGenerator>().WindGenerator(true);
        }
    }

  }
