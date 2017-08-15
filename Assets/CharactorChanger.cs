using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorChanger : MonoBehaviour {

    public int bmi = 0;
    public int hp = 100;
    private GameObject canvas;
    //細いplayer
    public GameObject playerAPrefub;
    //太いplayer
    public GameObject playerBPrefub;


    private GameObject[] characters;
    private GameObject currentChar;
    private Rigidbody2D myRigidbody;
    Animator anim;

    public float moveSpeed;

    int _currentCharNum = 0;





    // Use this for initialization
    void Start()
    {

        canvas = GameObject.Find("Canvas") as GameObject;
        this.myRigidbody = GetComponent<Rigidbody2D>();


        characters = GameObject.FindGameObjectsWithTag("PlayerChild");
        Debug.Log("I have " + characters.Length + " Changable Characters");

        ChangeCharacter(_currentCharNum);


    }





    //  操作キャラクターの変更 
    void ChangeCharacter(int characterNum)

    {
        // いったん全キャラクターを非アクティブにする
        foreach (GameObject chara in characters)
        {
            chara.SetActive(false);
        }
        // 指定した番号のキャラクターだけをアクティブにする
        currentChar = characters[characterNum];
        currentChar.SetActive(true);

        //anim = currentChar.GetComponent<Animator>();    // 対象キャラクターのAnimatorコンポーネントを取得する
    }


    // Update is called once per frame
    void Update()
    {

        if (this.bmi < 0)
        {
            _currentCharNum = 0;
            ChangeCharacter(_currentCharNum);
            myRigidbody.gravityScale = 8;

        }
        else
        {
            _currentCharNum = 1;
            ChangeCharacter(_currentCharNum);
            myRigidbody.gravityScale = 11;
        }


    }



    //ここから　ステータス反映
    //ダメージ処理
    public void Damage(int damageHp)
    {
        this.hp -= damageHp;
        if (this.hp < 0)
        {
            this.hp = 0;
        }

        canvas.GetComponent<BarController>().UpdateHp(hp);
    }

    //攻撃など
    public void Action(int actionBmi)
    {
        this.bmi -= actionBmi;

        if (this.bmi < -50)
        {
            this.bmi = -50;
        }
        canvas.GetComponent<BarController>().UpdateBmi(bmi);
    }

    //アイテム
    public void Niku(int nikuBmi, int nikuHp)
    {
        this.hp += nikuHp;
        if (this.hp > 100)
        {
            this.hp = 100;
        }
        this.bmi += nikuBmi;
        if (this.bmi > 50)
        {
            this.bmi = 50;
        }
        canvas.GetComponent<BarController>().UpdateBmi(bmi);
        canvas.GetComponent<BarController>().UpdateHp(hp);

    }
    //ここまで　ステータス反映






}
