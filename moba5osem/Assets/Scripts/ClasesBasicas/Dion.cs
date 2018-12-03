using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class Dion :MonoBehaviour, IPersonjeJugable
{
    //--|||--|||--
    #region Propiedades Clase
    private static readonly float[] escalado = new float [] { 1.0f, 1.0f, 1.0f };//Deben ser 11


    public short nivel { get; set; }
    public long experiencia { get; set; }

    public short vidaActual { get; set; }
    public bool ataqueDistancia { get; set; }
    public float dineroSegundo { get; set; }

    public short FisicoBase { get; set; }//--|||--|||--
    public short FisicoEscalado { get; set; }
    public short FisicoItems { get; set; }
    public short FisicoConfig { get; set; }
    public short FisicoBuffs { get; set; }
    public short FisicoTotal { get; set; }

    public short vidaMaximabase { get; set; }
    public short vidaMaximaEscalado { get; set; }
    public short vidaMaximaItems { get; set; }
    public short vidaMaximaConfig { get; set; }
    public short vidaMaximaBuffs { get; set; }
    public short VidaMaximaTotal { get; set; }

    public short velocidadMovimientoBase { get; set; }
    public short velocidadMovimientoEscalado { get; set; }
    public short velocidadMovimientoItems { get; set; }
    public short velocidadMovimientoConfig { get; set; }
    public short velocidadMovimientoBuffs { get; set; }
    public short VelocidadMovimientoTotal { get; set; }

    public short danioBase { get; set; }
    public short danioEscalado { get; set; }
    public short danioItems { get; set; }
    public short danioConfig { get; set; }
    public short danioBuffs { get; set; }
    public short danioTotal { get; set; }

    public short resistenciaFisicaBase { get; set; }
    public short resistenciaFisicaEscalado { get; set; }
    public short resistenciaFisicaItems { get; set; }
    public short resistenciaFisicaConfig { get; set; }
    public short resistenciaFisicaBuffs { get; set; }
    public short resistenciaFisicaTotal { get; set; }


    public short diminucionTiempoBuffsBase { get; set; }
    public short disminucionTiempoBuffsEscalado { get; set; }
    public short disminucionTiempoBuffsItems { get; set; }
    public short disminucionTiempoBuffsConfig { get; set; }
    public short disminucionTiempoBuffsBuffs { get; set; }
    public short disminucionTiempoBuffsTotal { get; set; }

    public short regeneracionVidaBase { get; set; }
    public short regeneracionVidaEscalado { get; set; }
    public short regeneracionVidaItems { get; set; }
    public short regeneracionVidaConfig { get; set; }
    public short regeneracionVidaBuffs { get; set; }
    public short regeneracionVidaTotal { get; set; }


    public short mentalBase { get; set; }//--|||--|||--
    public short mentalEscalado { get; set; }
    public short mentalItems { get; set; }
    public short mentalConfig { get; set; }
    public short mentalBuffs { get; set; }
    public short mentalTotal { get; set; }

    public short resistenciaMagicaBase { get; set; }
    public short resistenciaMagicaItems { get; set; }
    public short resistenciaMagicaConfig { get; set; }
    public short resistenciaMagicaBuffs { get; set; }
    public short resistenciaMagicaTotal { get; set; }

    public short poderMagicoBase { get; set; }
    public short poderMagicoEscalado { get; set; }
    public short poderMagicoItems { get; set; }
    public short poderMagicoConfig { get; set; }
    public short poderMagicoBuffs { get; set; }
    public short poderMagicoTotal { get; set; }

    public short poderCuracionesEscudoBase { get; set; }
    public short poderCuracionesEscudoEscalado { get; set; }
    public short poderCuracionesEscudoItems { get; set; }
    public short poderCuracionesEscudoConfig { get; set; }
    public short poderCuracionesEscudoBuffs { get; set; }
    public short poderCuracionesEscudoTotal { get; set; }

    public short penetracionFisicaBase { get; set; }
    public short penetracionFisicaEscalado { get; set; }
    public short penetracionFisicaItems { get; set; }
    public short penetracionFisicaConfig { get; set; }
    public short penetracionFisicaBuffs { get; set; }
    public short penetracionFisicaTotal { get; set; }

    public short penetracionMagicaBase { get; set; }
    public short penetracionMagicaEscalado { get; set; }
    public short penetracionMagicaItems { get; set; }
    public short penetracionMagicaConfig { get; set; }
    public short penetracionMagicaBuffs { get; set; }
    public short penetracionMagicaTotal { get; set; }

    //--|||--|||--
    public short probabilidadCriticoBase { get; set; }
    public short probabilidadCriticoItems { get; set; }
    public short probabilidadCriticoConfig { get; set; }
    public short probabilidadCriticoBuffs { get; set; }
    public short probabilidadCriticoTotal { get; set; }

    public short danioCriticoBase { get; set; }
    public short danioCriticoItems { get; set; }
    public short danioCriticoConfig { get; set; }
    public short danioCriticoBuffs { get; set; }
    public short danioCriticoTotal { get; set; }

    public short roboVidaBase { get; set; }
    public short roboVidaItems { get; set; }
    public short roboVidaConfig { get; set; }
    public short roboVidaBuffs { get; set; }
    public short roboVidaTotal { get; set; }

    public short alcanceAtaqueBase { get; set; }
    public short alcanceAtaqueItems { get; set; }
    public short alcanceAtaqueConfig { get; set; }
    public short alcanceAtaqueBuffs { get; set; }
    public short alcanceAtaqueTotal { get; set; }

    public short cadenciaAtaqueBase { get; set; }
    public short cadenciaAtaqueItems { get; set; }
    public short cadenciaAtaqueConfig { get; set; }
    public short cadenciaAtaqueBuffs { get; set; }
    public short cadenciaAtaqueTotal { get; set; }
    #endregion
    //--|||--|||--
    #region Propiedades Logica
    public float tiempoFuente { get; set; }
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
        tiempoFuente = 5;
    }
    private void Update()
    {
        Moverse();
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
    public void Moverse()
    {
        Vector3 vectorMovimiento = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(vectorMovimiento * VelocidadMovimientoTotal);
    }
    public void Correr()
    {

    }
    public void Atacar()
    {

    }
    public void Morir()
    {

    }
    public void SubirNivel()
    {

    }

    public void Q()
    {

    }
    public void W()
    {

    }
    public void E()
    {

    }
    public void R()
    {

    }

    public bool RecibirCC(CC cc/*Personaje personaje*/)
    {
        return true;
    }
    public bool RecibirDanio(Danio danio/*Personaje personaje*/)
    {
        return true;
    }
    public bool RecibirCuracion(Curacion curacion/*Personaje personaje*/)
    {
        return true;
    }
    #endregion
}
#region Etiquetas
/*
[Header("Propiedades")]
[Space]
[Multiline][Tooltip("Descripcion de algo")] public string text = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja.";
[TextArea] public string text1 = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja.";
[Range(0, 9)] public public short number = 0;

//--|||--|||--
[UnityEditor.MenuItem("Tools/Decir/Hola")]
public static void Hola()
{
    Debug.Log("Hola mundo");
}*/
#endregion