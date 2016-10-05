using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    public Vector3 boundary;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    //void Update()
    //{
    //    if (rb.position.z > boundary.z) {
    //        Destroy(gameObject);
    //    }
    //}
}
