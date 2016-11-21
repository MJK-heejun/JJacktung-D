using UnityEngine;
using System.Collections;

public class ObjectBoundary : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);        
    }

}
