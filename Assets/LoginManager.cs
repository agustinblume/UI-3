using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField InputNombre;
    public Text nombre;
    string contra = "Berni";
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Consola()
    {
        string ContraUsuario = InputNombre.text;
        if (ContraUsuario == contra)
        {
            nombre.text = "correcto";
            Debug.Log("Acceso correcto");
        }
        else
        {
            Debug.Log("Acceso denegado");
        }

    }
}
