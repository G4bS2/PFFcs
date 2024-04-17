using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mira_controller : MonoBehaviour
{
    [Header("Mira Laser")]
    [SerializeField] private GameObject laser;
    [SerializeField] private LineRenderer line;
    [SerializeField] private float distancia;
    [SerializeField] private KeyCode habilitarLaser;
    private bool laserHabilitado = false;

    // Update is called once per frame
    void Update()
    {
        #region // laser
        line.SetPosition(0, laser.transform.position);
        line.SetPosition(1, laser.transform.forward * distancia);

        if (Input.GetKeyDown(habilitarLaser))
        {
            laserHabilitado = !laserHabilitado;
        }
        if (laserHabilitado)
        {
            laser.SetActive(true);
        }
        else
        {
            laser.SetActive(false);
        }
        #endregion

        
    }
}
