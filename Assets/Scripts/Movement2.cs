using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {

    public Rigidbody prefab;

    // Use this for initialization
    void Start()
    {
        //bullet = GameObject.FindGameObjectWithTag("Bullet1");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 carMove = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            carMove = new Vector3(0, 5, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            carMove = new Vector3(0, -5, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            Fire();
        }


        transform.Translate(carMove);
    }

    void Fire()
    {
        Rigidbody lprefab = Instantiate(prefab, new Vector3(transform.position.x - 1f, transform.position.y, 0), gameObject.transform.rotation) as Rigidbody;
        
        
    }
}
