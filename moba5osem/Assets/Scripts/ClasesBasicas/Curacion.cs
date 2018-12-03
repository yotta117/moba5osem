using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class Curacion
{
    //--|||--|||--
    #region Propiedades Clase
    public enum TipoCuracion
    {
        escudo,
        sobrecuracion,
        salud
    }
    public TipoCuracion tipoCuracion;
    public short poderCuracionEscudo;
    public float cantidad;
    #endregion
    //--|||--|||--
    #region Propiedades Logica

    #endregion
    //--|||--|||--
    #region Propiedades Constantes

    #endregion





    //--|||--|||--
    #region Metodos Clase
    private Curacion(TipoCuracion tipoCuracion, short poderCuracionEscudo, float cantidad)
    {
        this.tipoCuracion = tipoCuracion;
        this.poderCuracionEscudo = poderCuracionEscudo;
        this.cantidad = cantidad;
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