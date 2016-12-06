using UnityEngine;
using System.Collections;

public class OffScreen : MonoBehaviour {

	void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
