using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //アニメーションするためのコンポーネントを入れる
    private Animator myAnimator;
    private Rigidbody2D myRigidbody;
    private GameObject attackCollision;
    private GameObject chara;

    //ジャンプするための力
    private float upForce = 1200.0f;

    //右を向いているかどうか（初期値はtrue）
    private bool facingRight = true;

    //左ボタン押下の判定
    public bool isLButtonDown = false;
    //右ボタン押下の判定）
    public bool isRButtonDown = false;





    // Use this for initialization
    void Start () {
        //Rigidbodyコンポーネントを取得
        this.myRigidbody = GetComponent<Rigidbody2D>();
        this.myAnimator = GetComponent<Animator>();
        chara = GameObject.Find("PlayerEmpty") as GameObject;


    }

	
	// Update is called once per frame
	void Update () {

        if (this.isLButtonDown)
        {
            if (this.transform.position.y < -1.0f)
            {
                //左に移動
                this.myRigidbody.velocity = (Vector2.left * 10);
                //体の向き
                transform.localScale = new Vector2(-0.25f, 0.25f);
            }
        }

        else if (this.isRButtonDown)
        {
            if (this.transform.position.y < -1.0f)
            {
                //右に移動
                this.myRigidbody.velocity = (Vector2.right * 10);
                //体の向き
                transform.localScale = new Vector2(0.25f, 0.25f);
            }

        }
    }
    //攻撃ボタンを押した場合の処理
    public void GetMyAttackButtonDown()
    {
        GetComponentInChildren<Animator>().SetTrigger("AttackTrigger");
    }


    //ジャンプボタンを押した場合の処理
    public void GetMyJumpButtonDown()
    {
         if (this.transform.position.y < 0.0f)
        {
            chara.gameObject.GetComponent<CharactorChanger>().Action(5);
            //this.myAnimator.SetBool("Jump", true);
            GetComponentInChildren<Animator>().SetTrigger("JumpTrigger");
            this.myRigidbody.AddForce(this.transform.up * this.upForce);

        }
    }

   
    //左ボタンを押し続けた場合の処理
    public void GetMyLeftButtonDown()
    {

        this.isLButtonDown = true;
        GetComponentInChildren<Animator>().SetBool("RunBool", true);
      
    }
    //左ボタンを離した場合の処理
    public void GetMyLeftButtonUp()
    {
        this.isLButtonDown = false;
        GetComponentInChildren<Animator>().SetBool("RunBool", false);
    }

    //右ボタンを押し続けた場合の処理
    public void GetMyRightButtonDown()
    {
        this.isRButtonDown = true;
        GetComponentInChildren<Animator>().SetBool("RunBool", true);
    }
    //右ボタンを離した場合の処理
    public void GetMyRightButtonUp()
    {
        this.isRButtonDown = false;
        GetComponentInChildren<Animator>().SetBool("RunBool", false);
    }



}
