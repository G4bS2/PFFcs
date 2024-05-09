using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaoCOntroller : MonoBehaviour
{
    [SerializeField] private Camera Camera1P;
    [SerializeField] private Camera Camera3P;
    [SerializeField] private Camera CameraRetrovisor;
    [SerializeField] private movimentoAviaoController aviaoController;
    [SerializeField] private KeyCode trocaCamera;
    [SerializeField] private KeyCode espelho;
    private bool primeiraPessoa = false;

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
        }
        else
        {
            Camera1P.enabled = false;
            Camera3P.enabled = false;
            CameraRetrovisor.enabled = false;
        }
        trocaDeCameras();
        habilitarRetrovisor();
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
    }
    void habilitarRetrovisor()
    {
        if (Input.GetKey(espelho))                
            CameraRetrovisor.depth = 3;      
        else
            CameraRetrovisor.depth = 0;
        
    }
}
