using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaGun : MonoBehaviour
{
    
    private bool temDeagle = false;
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.collider.CompareTag("Jogador"))
        {
           
            temDeagle = true;
            //Destroy(collision.gameObject);
            Debug.Log("Deagle recebido");
        }


    }
}
