using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    public int vidaDummy = 3;

    public CenaController controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vidaDummy <= 0)
        {
            CenaController.instance.AumentarPontos();
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            vidaDummy--;
        }
    }
}
