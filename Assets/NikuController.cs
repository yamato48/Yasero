using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NikuController : MonoBehaviour {

    private GameObject chara;

	// Use this for initialization
	void Start () {
        chara = GameObject.Find("PlayerEmpty") as GameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            chara.gameObject.GetComponent<CharactorChanger>().Niku(20, 20);
            Destroy(this.gameObject);

        }   
    }



}
