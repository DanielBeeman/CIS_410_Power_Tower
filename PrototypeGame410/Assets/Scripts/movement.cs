using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody rb;


    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 movement = new Vector3(5.0f, 0.0f, 5.0f);
        transform.Translate(Vector3.forward * speed);

        //rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Endpoint"))
        {
            gameObject.SetActive(false);
        }
    }

}
