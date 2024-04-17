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
        rifle.SetActive(false);
        Deagle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(primaria))
        {
            rifle.SetActive(true);
            Deagle.SetActive(false);
            Debug.Log("rifle out");
        }
        if (Input.GetKeyDown(secundaria) && temDeagle)
        {
            rifle.SetActive(false);
            Deagle.SetActive(true);
            Debug.Log("Deagle out");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Deagle"))
        {
            temDeagle = true;
            Destroy(collision.gameObject);
            Debug.Log("Deagle recebido");
        }
        

    }
}
