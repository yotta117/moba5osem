using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class Danio
{
    //--|||--|||--
    #region Propiedades Clase
    public enum TipoDanio
    {
        fisico,
        magico,
        verdadero
    }
    TipoDanio tipoDanio;
    public float penetracionMagica;
    public float PenetracionFisica;
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
    public Danio(TipoDanio tipoDanio, float penetracionMagica, float PenetracionFisica, float cantidad)
    {
        this.tipoDanio = tipoDanio;
        this.penetracionMagica = penetracionMagica;
        this.PenetracionFisica = PenetracionFisica;
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