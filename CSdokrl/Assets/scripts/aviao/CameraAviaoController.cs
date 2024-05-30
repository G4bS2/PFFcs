using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaoCOntroller : MonoBehaviour
{
    [SerializeField] private Camera Camera1P;
    [SerializeField] private Camera Camera3P;
    [SerializeField] private Camera CameraRetrovisor;
    [SerializeField] private Camera camMinimapa;
    [SerializeField] private movimentoAviaoController aviaoController;
    [SerializeField] private KeyCode trocaCamera;
    [SerializeField] private KeyCode espelho;
    [SerializeField] private KeyCode ligaMiniMapa;
    private bool primeiraPessoa = false;
  
    [SerializeField] private bool minimapaIsOn = false;
    private bool espelhoIsOn = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (aviaoController.ligado)
        {
            Camera1P.enabled = true;
            Camera3P.enabled = true;
            CameraRetrovisor.enabled = true;
            camMinimapa.enabled = true;
        }
        else
        {
            Camera1P.enabled = false;
            Camera3P.enabled = false;
            CameraRetrovisor.enabled = false;
            camMinimapa.enabled = false;
        }
        trocaDeCameras();
        //habilitarRetrovisor();
    }
    void trocaDeCameras()
    {
        if (Input.GetKeyDown(trocaCamera))
        {
            primeiraPessoa = !primeiraPessoa;
        }
        if (primeiraPessoa)
        {
            Camera1P.depth = 2;
            Camera3P.depth = 1;
        }
        else
        {
            Camera1P.depth = 0;
            Camera3P.depth = 2;
        }

        if (Input.GetKeyDown(ligaMiniMapa))
            minimapaIsOn = !minimapaIsOn;
        if (minimapaIsOn)
        {
            camMinimapa.depth = 4;
        }
        else
        {
            camMinimapa.depth = 0;
        }

   
       if (Input.GetKeyDown(espelho)) { 
            espelhoIsOn = !espelhoIsOn;
            if (espelhoIsOn)
            {
                CameraRetrovisor.depth = 13;
            }
            else
            {
                CameraRetrovisor.depth = 0;
            }

        }
    }
    void habilitarRetrovisor()
    {
        //if (Input.GetKey(espelho))
        //    CameraRetrovisor.depth = 3;
        //else
        //    CameraRetrovisor.depth = 0;

        //    if (Input.GetKeyDown(espelho))
        //    {
        //        retrovisorOn = !retrovisorOn;
        //    }
        //    if (retrovisorOn)
        //    {
        //        CameraRetrovisor.enabled = true;
        //    }
        //    else
        //    {
        //        CameraRetrovisor.enabled = false;
        //    }
        }
    }

