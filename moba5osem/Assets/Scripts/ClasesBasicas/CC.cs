using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class CC
{
    //--|||--|||--
    #region Propiedades Clase
    public enum TipoCC
    {
        noquear,
        realentizar,
        enraizar,
        supresion,
        stasis,
        silenciar,
        cegar,
        encantar,
        temer,
        huir,
        provocar,
        desarmar,
        empujar,
        manquear
    }
    public TipoCC tipoCC;
    public float duracion;
    public Vector3 direccion;

    #endregion
    //--|||--|||--
    #region Propiedades Logica

    #endregion
    //--|||--|||--
    #region Propiedades Constantes

    #endregion





    //--|||--|||--
    #region Metodos Clase
    private  CC(TipoCC tipoCC, float duracion, Vector3 direccion)
    {
        this.tipoCC = tipoCC;
        this.duracion = duracion;
        this.direccion = direccion;
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