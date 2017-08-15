using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public GameObject player;
    private Rigidbody2D otherRigidbody;
    public GameObject itemPrefub;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("PlayerEmpty");
	}
	
	// Update is called once per frame
	void Update () {
    }

    //攻撃ボタンを押した場合の処理
    public void GetMyAttackButtonDown()
    {
        player.gameObject.GetComponent<CharactorChanger>().Action(10);
        //colliderをオン
        GetComponent<BoxCollider2D>().enabled = true;
        //秒後にcolliderオフ
        StartCoroutine(AttackButtonUp());
    }

    IEnumerator AttackButtonUp()
    {
        //秒後にcolliderオフ
        yield return new WaitForSeconds(0.5f);
        GetComponent<BoxCollider2D>().enabled = false;
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        float f = Random.Range(5.0f, 20.0f);
        float g = Random.Range(1.0f, 10.0f);

        if (other.gameObject.tag == "EnemyA")
        {
            //飛ばす
            otherRigidbody = other.GetComponent<Rigidbody2D>();
            otherRigidbody.AddForce(new Vector2(f, g) * 100);
        }

        if (other.gameObject.tag == "EnemyB")
        {
            //飛ばす
            otherRigidbody = other.GetComponent<Rigidbody2D>();
            otherRigidbody.AddForce(new Vector2(f, g) * 100);
            //アイテム生成
            GameObject item = Instantiate(itemPrefub) as GameObject;
            item.transform.position = new Vector2(other.transform.position.x + 3, other.transform.position.y + 2);
        }
        if (other.gameObject.tag == "Item")
        {
            //飛ばす
            otherRigidbody = other.GetComponent<Rigidbody2D>();
            otherRigidbody.AddForce(new Vector2(f, g) * 200);

        }


    }

}
