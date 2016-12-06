using UnityEngine;
using System.Collections;

public class BackgroundMove : MonoBehaviour {

    public float scrollSpeed = 2 * Time.deltaTime;
    public float tileSizeZ = 1;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
