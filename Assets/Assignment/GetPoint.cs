using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoint : MonoBehaviour {

    private GameObject scoreText; // Text用変数
    private int point = 0; // 点数計算用変数

	// Use this for initialization
	void Start () {
        this.scoreText = GameObject.Find("ScoreText");
	}

    // 衝突により点数加算
    void OnCollisionEnter (Collision collision) {
        // Tag別に加点数を変更
        if (collision.gameObject.tag == "LargeStarTag") {
            point += 20;
        }
        else if (collision.gameObject.tag == "SmallStarTag") {
            point += 1;
        }
        else if (collision.gameObject.tag == "LargeCloudTag" || tag == "SmallCloudTag") {
            point += 5;
        }
    }

    // Update is called once per frame
    void Update () {
        // ScoreTextオブジェクトのTextコンポーネントを取得してpointを代入
        this.scoreText.GetComponent<Text>().text = "SCORE " + point;
	}
}
