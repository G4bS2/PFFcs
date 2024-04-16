using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaControler : MonoBehaviour
{
    private Rigidbody fis;
    public float velocidade;

    void Start()
    {
        fis = GetComponent<Rigidbody>();
        fis.AddForce(transform.forward * velocidade, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Dummy"))
        {
            Destroy(gameObject);
        }
    }
}
