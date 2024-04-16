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
    public int ammoRe = 90;
    public int ammoReloaded;
    public bool recarregando = false;

    public Text ammoDisplay;
    public Text ammoReDisplay;

    public Animator anim;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        #region // recarrega a arma
        if (Input.GetKey(KeyCode.R) && !recarregando && ammo < 30 && ammoRe > 0)
        {
            recarregando = true;
            anim.SetTrigger("Reload");
            Invoke("reload", 3f);
        }
        #endregion
        #region // atira
        if (Input.GetMouseButton(0) && ammo > 0 && !recarregando)
        {
            var ba = Instantiate(Bala, canoDaArma.transform.position, canoDaArma.transform.rotation);
            ammo--;
            Debug.Log("pew" + ammo);
            Destroy(ba, 3f);
        }
        #endregion
        #region // deixa a quantidade maxima de munição como 320
        if (ammoRe > 320)
        {
            ammoRe = 320;
            Debug.Log("full");
        }
        #endregion
        ammoDisplay.text = "Ammo: " + ammo; //mostra quantas balas ainda tem no pente
        ammoReDisplay.text = "Reserve Ammo: " + ammoRe; //mostra quantas balas ainda tem na reserva
        #region // decide quantas balas serão colocadas no pente e retiradas da reserva
        if (ammoRe < 30)
        {
            ammoReloaded = ammoRe;
        }
        else
        {
            ammoReloaded = 30 - ammo;
        }
        Debug.Log("recarregar: "+ammoReloaded+" balas");
        #endregion
    }
    public void AddAmmo(int amount)
    {
        ammoRe += amount;
    }
    void reload()
    {
        ammoRe = ammoRe - ammoReloaded;
        ammo = ammo + ammoReloaded;
        recarregando = false;    
    }
}
