using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {
    public Text text2;
    int score1;
	// Use this for initialization
	void Start () {
        text2 = GameObject.Find("P1Text").GetComponent<Text>();
        text2.text = "Score: ";
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-25 * Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player1")
            Destroy(gameObject);
            score1 += 100;
            text2.text = "Score: " + score1;
    }
}
