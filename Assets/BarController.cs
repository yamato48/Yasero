using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarController : MonoBehaviour {
    public Image bmiCursor;
    public Image hpBar;
    private GameObject stateText;



    // Use this for initialization
    void Start () {
        //this.stateText = GameObject.Find("GameOverText");
    }
	

	// Update is called once per frame
	void Update () {
		
	}

    //BMIバー
    public void UpdateBmi(float value)
    {

        if (value <= -50 || value >= 50)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();

        }

        bmiCursor.GetComponent<RectTransform>().anchoredPosition = new Vector2(value * 8,0);
    }


    //HPバー
    public void UpdateHp(float value)
    {

        hpBar.fillAmount = value / 100;

        if (value <= 0)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
        }


    }


}
