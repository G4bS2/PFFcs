using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public int ammoOnBox = 90;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jogador"))
        {
            DispararRifle gunController = collision.gameObject.GetComponentInChildren<DispararRifle>();
            if (gunController != null)
            {
                gunController.AddAmmo(ammoOnBox);
                Destroy(gameObject);
            }
        }
    }
}
