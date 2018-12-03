using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class MantenerArmaPosicion : MonoBehaviour
{
    //--|||--|||--
    #region Propiedades Clase
    [SerializeField] Transform posiconDeseada; 
    #endregion
    //--|||--|||--
    #region Propiedades Logica

    #endregion
    //--|||--|||--
    #region Propiedades Constantes

    #endregion





    //--|||--|||--
    #region Metodos MonoBehaviour
    private void Awake()
    {
    }
    private void OnEnable()
    {
    }
    private void Start()
    {
    }
    private void Update()
    {
        //this.transform.rotation = posiconDeseada.rotation;
        this.transform.position = posiconDeseada.position;
    }
    private void FixedUpdate()
    {
    }
    private void LateUpdate()
    {
    }
    private void OnDisable()
    {
    }
    #endregion





    //--|||--|||--
    #region Metodos Clase
    private void Metodo()
    {
    }
    #endregion
}
#region Etiquetas
/*
[Header("Propiedades")]
[Space]
[Multiline][Tooltip("Descripcion de algo")] public string text = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja.";
[TextArea] public string text1 = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja.";
[Range(0, 9)] public short number = 0;

//--|||--|||--
[UnityEditor.MenuItem("Tools/Decir/Hola")]
public static void Hola()
{
    Debug.Log("Hola mundo");
}*/
#endregion