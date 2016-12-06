using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shooting2 : MonoBehaviour {
    public Text text;
    int score2;
    public Collision Col;
	// Use this for initialization
	void Start () {
        text = GameObject.Find("P2Text").GetComponent<Text>();
        text.text = "Score: ";

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(25 * Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player2")
            Destroy(gameObject);
            score2 += 100;
            text.text = "Score: " + score2;
    }
}
