using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBController : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    private Rigidbody2D playerRigidbody;
    private GameObject chara;

    // Use this for initialization
    void Start () {
        //Rigidbodyコンポーネントを取得（追加）
        this.myRigidbody = GetComponent<Rigidbody2D>();
        chara = GameObject.Find("PlayerEmpty") as GameObject;

        playerRigidbody = chara.GetComponent<Rigidbody2D>();


        int speed = Random.Range(3, 10);

        //左に移動
        this.myRigidbody.velocity = (Vector2.left * speed);
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //20ダメージ
            chara.gameObject.GetComponent<CharactorChanger>().Damage(20);
            playerRigidbody.AddForce(new Vector2(-1,2) * 200);

        }


    }
}
