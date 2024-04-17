using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispararRifle : MonoBehaviour
{
    #region // variaveis
    public int ammo = 30;
    public GameObject canoDaArma;
    public GameObject Bala;

    public Text ammoDisplay;

    #endregion
    // Update is called once per frame
    void Update()
    {
       
        #region // atira
        if (Input.GetMouseButton(0) && ammo > 0 )
        {
            var ba = Instantiate(Bala, canoDaArma.transform.position, canoDaArma.transform.rotation);
            ammo--;
            Debug.Log("pew" + ammo);
            Destroy(ba, 3f);
        }
        #endregion
        
        ammoDisplay.text = "Ammo: " + ammo; //mostra quantas balas ainda tem no pente      
    }
    public void AddAmmo(int amount)
    {
        ammo += amount;
    }
    
}