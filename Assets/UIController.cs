using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class UIController : MonoBehaviour
{


    // ゲームオーバ-
    private GameObject gameOverText;
    private GameObject gameOverImg;
    private GameObject titleButton;
    private GameObject tButtonText;
    // 走行距離テキスト
    private GameObject runLengthText;

   
    // ゲームオーバの判定
    private bool isGameOver = false;

    // Use this for initialization
    void Start()
    {

        // シーンビューからオブジェクトの実体を検索する
        this.gameOverText = GameObject.Find("GameOverText");
        this.gameOverImg = GameObject.Find("GameOverImg");
        this.titleButton = GameObject.Find("TitleButton");
        this.tButtonText = GameObject.Find("TButtonText");
        //this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
    



    }

    public void GameOver()
    {
        // ゲームオーバになったときに、画面上にゲームオーバを表示する
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.gameOverImg.GetComponent<Image>().enabled = true;
        this.titleButton.GetComponent<Image>().enabled = true;
        this.tButtonText.GetComponent<Text>().text = "タイトルへ";
        this.isGameOver = true;
    }

    public void GetTitleButtonDown()
    {
        // ゲームオーバになった場合
        if (this.isGameOver)
        {
            //titleを読み込む
            SceneManager.LoadScene("Title");
        }
    }



    //以下、タイトル画面などで使用

    public void GetTitleButton2Down()
    {
            //titleを読み込む
            SceneManager.LoadScene("Title");

    }

    public void GetStartButtonDown()
    {
        //GameSceneを読み込む
        SceneManager.LoadScene("GameScene");

    }

    public void GetTutorialButtonDown()
    {
         //Tutorialを読み込む
         SceneManager.LoadScene("Tutorial");

    }


}