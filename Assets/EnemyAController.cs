using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAController : MonoBehaviour
{

    private Rigidbody2D myRigidbody;
    private GameObject chara;

    // Use this for initialization
    void Start()
    {
        //Rigidbodyコンポーネントを取得（追加）
        this.myRigidbody = GetComponent<Rigidbody2D>();
        chara = GameObject.Find("PlayerEmpty") as GameObject;

    }

    // Update is called once per frame
    void Update()
    {

        int speed = Random.Range(1, 10);
        int height = Random.Range(6, 8);

        Vector2 v = myRigidbody.velocity;
            v.x = Vector2.left.x * speed; 
               if (this.transform.position.y < -1.0f)
            {
                v.y = 1.0f * height;
            }
            //左に移動
            this.myRigidbody.velocity = v;
            

        


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            chara.gameObject.GetComponent<CharactorChanger>().Damage(10);
            //Destroy(this.gameObject);

        }
    }


}
