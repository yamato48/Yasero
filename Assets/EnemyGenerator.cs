using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    float timeA;
    float timeB;
    public GameObject itemPrefub;
    public GameObject enemyBPrefub;
    public GameObject enemyAPrefub;
    public GameObject enemyCPrefub;


    // Use this for initialization
    void Start () {

 	}
	
	// Update is called once per frame
	void Update () {

        float f = Random.Range(1.0f, 4.0f);

        //経過時間
        timeA += Time.deltaTime;

        //f秒ごとに
        if (timeA >= f)
        {
            timeA = 0;
            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                //item生成
                int x = Random.Range(-6, 5);
                GameObject item = Instantiate(itemPrefub) as GameObject;
                item.transform.position = new Vector2(x, 3);

            }
            else if (num <= 4)
            {
                //EnemyB生成
                GameObject enemyB = Instantiate(enemyBPrefub) as GameObject;
                enemyB.transform.position = new Vector2(7, -1.4f);
            }
            else
            {
                //EnemyA生成
                int y = Random.Range(0, 7);
                GameObject enemyA = Instantiate(enemyAPrefub) as GameObject;
                enemyA.transform.position = new Vector2(7, y);
            }
        }


    }
    /*
    public void WindGenerator(bool wind)
    {
        if (wind)
        {
            //経過時間
            timeB += Time.deltaTime;

            //f秒ごとに
            if (timeB >= 2.0f)
            {
                timeB = 0;
                //EnemyC生成
                int y = Random.Range(0, 3);
                GameObject enemyC = Instantiate(enemyCPrefub) as GameObject;
                enemyC.transform.position = new Vector2(7, y);
            }
        }

    }

    */


}
