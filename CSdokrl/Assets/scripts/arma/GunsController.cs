using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsController : MonoBehaviour
{
    [SerializeField] private GameObject rifle;
    [SerializeField] private GameObject Deagle;
    private bool temDeagle = false;  
    [SerializeField] private KeyCode primaria;
    [SerializeField] private KeyCode secundaria;
    // Start is called before the first frame update
    void Start()
    {
        //rifle.SetActive(false);
        Deagle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(primaria))
        {
            rifle.SetActive(true);
            Deagle.SetActive(false);
            Debug.Log("com rifle");
        }
        if (Input.GetKeyDown(secundaria))
        {
            rifle.SetActive(false);
            Deagle.SetActive(true);
            Debug.Log("com Deagle");
        }
    }
   //private void OnCollisionEnter(Collision collision)
   // {
   //     if (collision.collider.tag == "Deagle" )
   //     {
   //         Debug.Log("Deagle recebido");
   //         temDeagle = true;
   //         Destroy(collision.gameObject);
            
   //     }
        

   // }
}
