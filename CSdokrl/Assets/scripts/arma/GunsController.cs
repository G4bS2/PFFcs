using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsController : MonoBehaviour
{
    [SerializeField] private GameObject rifle;
    [SerializeField] private GameObject revolver;
    private bool temRevolver = false;
    private bool temRifle = false;
    [SerializeField] private KeyCode primaria;
    [SerializeField] private KeyCode secundaria;
    // Start is called before the first frame update
    void Start()
    {
        rifle.SetActive(false);
        revolver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(primaria) && temRifle)
        {
            rifle.SetActive(true);
            revolver.SetActive(false);
            Debug.Log("rifle out");
        }
        if (Input.GetKeyDown(secundaria) && temRevolver)
        {
            rifle.SetActive(false);
            revolver.SetActive(true);
            Debug.Log("revolver out");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("revolver"))
        {
            temRevolver = true;
            Destroy(collision.gameObject);
            Debug.Log("revolver recebido");
        }
        if (collision.gameObject.CompareTag("Rifle"))
        {
            temRifle = true;
            Destroy(collision.gameObject);
            Debug.Log("rifle recebido");
        }

    }
}
