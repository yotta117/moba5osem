using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class ConfiguracionEntradas : MonoBehaviour
{
    //--|||--|||--
    #region Propiedades Clase

    public KeyCode adelante;
    public KeyCode atras;
    public KeyCode izquierda;
    public KeyCode derecha;

    public KeyCode interactuar;

    public KeyCode habilidadUno;
    public KeyCode habilidadDos;
    public KeyCode habilidadTres;
    public KeyCode habilidadCuatro;

    public KeyCode mostrarObjetivos;
    public KeyCode mostrarMenu;

    #endregion
    //--|||--|||--
    #region Propiedades Logica

    #endregion
    //--|||--|||--
    #region Propiedades Constantes

    private const KeyCode adelanteOriginal = KeyCode.W;
    private const KeyCode atrasOriginal = KeyCode.S;
    private const KeyCode izquierdaOriginal = KeyCode.A;
    private const KeyCode derechaOriginal = KeyCode.D;

    private const KeyCode interactuarOriginal = KeyCode.E;

    private const KeyCode habilidadUnoOriginal = KeyCode.C;
    private const KeyCode habilidadDosOriginal = KeyCode.V;
    private const KeyCode habilidadTresOriginal = KeyCode.B;
    private const KeyCode habilidadCuatroOriginal = KeyCode.R;

    private const KeyCode mostrarObjetivosOriginal = KeyCode.F1;
    public const KeyCode mostrarMenuOriginal = KeyCode.Escape;


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
        CargarAsignacionTeclas();
    }
    private void Update()
    {
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
    private void CargarAsignacionTeclas()
    {
        adelante = convertirStringKeycode(PlayerPrefs.GetString("adelante", adelanteOriginal.ToString()));
        atras = convertirStringKeycode(PlayerPrefs.GetString("atras", atrasOriginal.ToString()));
        adelante = convertirStringKeycode(PlayerPrefs.GetString("izquierda", izquierdaOriginal.ToString()));
        adelante = convertirStringKeycode(PlayerPrefs.GetString("derecha", derechaOriginal.ToString()));

        adelante = convertirStringKeycode(PlayerPrefs.GetString("interactuar", interactuar.ToString()));

        adelante = convertirStringKeycode(PlayerPrefs.GetString("habilidadUno", habilidadUnoOriginal.ToString()));
        adelante = convertirStringKeycode(PlayerPrefs.GetString("habilidadDos", habilidadDosOriginal.ToString()));
        adelante = convertirStringKeycode(PlayerPrefs.GetString("habilidadTres", habilidadTresOriginal.ToString()));
        adelante = convertirStringKeycode(PlayerPrefs.GetString("habilidadCuatro", habilidadCuatroOriginal.ToString()));

        adelante = convertirStringKeycode(PlayerPrefs.GetString("mostrarObjetivos", mostrarObjetivosOriginal.ToString()));
        adelante = convertirStringKeycode(PlayerPrefs.GetString("mostrarMenu", mostrarMenuOriginal.ToString()));
    }
    private void GuardarAsignacionTeclas()
    {
        PlayerPrefs.SetString("adelante", adelante.ToString());
        PlayerPrefs.SetString("atras", atras.ToString());
        PlayerPrefs.SetString("izquierda", izquierda.ToString());
        PlayerPrefs.SetString("derecha", derecha.ToString());

        PlayerPrefs.SetString("interactuar", interactuar.ToString());

        PlayerPrefs.SetString("habilidadUno", habilidadUno.ToString());
        PlayerPrefs.SetString("habilidadDos", habilidadDos.ToString());
        PlayerPrefs.SetString("habilidadTres", habilidadTres.ToString());
        PlayerPrefs.SetString("habilidadCuatro", habilidadCuatro.ToString());

        PlayerPrefs.SetString("mostrarObjetivos", mostrarObjetivos.ToString());
        PlayerPrefs.SetString("mostrarMenu", mostrarMenu.ToString());
}
    public void RestaurarTeclasDefault()
    {
        adelante = adelanteOriginal;
        atras = atrasOriginal;
        izquierda = izquierdaOriginal;
        derecha = derechaOriginal;

        interactuar = interactuarOriginal;

        habilidadUno = habilidadUnoOriginal;
        habilidadDos = habilidadDosOriginal;
        habilidadTres = habilidadTresOriginal;
        habilidadCuatro = habilidadCuatroOriginal;

        mostrarObjetivos = mostrarObjetivosOriginal;
        mostrarMenu = mostrarMenuOriginal;
    }
    private KeyCode convertirStringKeycode(string entrada)
    {
        KeyCode salida;
        switch (entrada)
        {
            case "A":
                salida = KeyCode.A;
                break;
            case "B":
                salida = KeyCode.B;
                break;
            case "C":
                salida = KeyCode.C;
                break;
            case "D":
                salida =  KeyCode.D;
                break;
            case "E":
                salida = KeyCode.E;
                break;
            case "F":
                salida = KeyCode.F;
                break;
            case "G":
                salida = KeyCode.G;
                break;
            case "H":
                salida = KeyCode.H;
                break;
            case "I":
                salida = KeyCode.I;
                break;
            case "J":
                salida = KeyCode.J;
                break;
            case "K":
                salida = KeyCode.K;
                break;
            case "L":
                salida = KeyCode.L;
                break;
            case "M":
                salida = KeyCode.M;
                break;
            case "N":
                salida = KeyCode.N;
                break;
            case "O":
                salida = KeyCode.O;
                break;
            case "P":
                salida = KeyCode.P;
                break;
            case "Q":
                salida = KeyCode.Q;
                break;
            case "R":
                salida = KeyCode.R;
                break;
            case "S":
                salida = KeyCode.S;
                break;
            case "T":
                salida = KeyCode.T;
                break;
            case "U":
                salida = KeyCode.U;
                break;
            case "V":
                salida = KeyCode.V;
                break;
            case "W":
                salida = KeyCode.W;
                break;
            case "X":
                salida = KeyCode.X;
                break;
            case "Y":
                salida = KeyCode.Y;
                break;
            case "Z":
                salida = KeyCode.Z;
                break;
            case "LeftControl":
                salida = KeyCode.LeftControl;
                break;
            case "RightControl":
                salida = KeyCode.RightControl;
                break;
            case "LeftShift":
                salida = KeyCode.LeftShift;
                break;
            case "RightShift":
                salida = KeyCode.RightShift;
                break;
            case "LeftAlt":
                salida = KeyCode.RightShift;
                break;
            case "Tab":
                salida = KeyCode.Tab;
                break;
            case "F1":
                salida = KeyCode.F1;
                break;
            case "F2":
                salida = KeyCode.F2;
                break;
            case "F3":
                salida = KeyCode.F3;
                break;
            case "F4":
                salida = KeyCode.F4;
                break;
            case "F5":
                salida = KeyCode.F5;
                break;
            case "F6":
                salida = KeyCode.F6;
                break;
            case "F7":
                salida = KeyCode.F7;
                break;
            case "F8":
                salida = KeyCode.F8;
                break;
            case "F9":
                salida = KeyCode.F9;
                break;
            case "F10":
                salida = KeyCode.F10;
                break;
            case "F11":
                salida = KeyCode.F11;
                break;
            case "F12":
                salida = KeyCode.F12;
                break;
            case "CapsLock":
                salida = KeyCode.CapsLock;
                break;
            case "Alpha0":
                salida = KeyCode.Alpha0;
                break;
            case "Alpha1":
                salida = KeyCode.Alpha1;
                break;
            case "Alpha2":
                salida = KeyCode.Alpha2;
                break;
            case "Alpha3":
                salida = KeyCode.Alpha3;
                break;
            case "Alpha4":
                salida = KeyCode.Alpha4;
                break;
            case "Alpha5":
                salida = KeyCode.Alpha5;
                break;
            case "Alpha6":
                salida = KeyCode.Alpha6;
                break;
            case "Alpha7":
                salida = KeyCode.Alpha7;
                break;
            case "Alpha8":
                salida = KeyCode.Alpha8;
                break;
            case "Alpha9":
                salida = KeyCode.Alpha9;
                break;
            default:
                salida = KeyCode.Escape;
                break;
        }
        return salida;
    }
    public void CambiarAsignacionTecla(KeyCode teclaVieja, KeyCode TeclaNueva)
    {
        if (teclaVieja == adelante)
        {
            adelante = TeclaNueva;
        }
        if (teclaVieja == atras)
        {
            atras = TeclaNueva;
        }
        if (teclaVieja == izquierda)
        {
            izquierda = TeclaNueva;
        }
        if (teclaVieja == derecha)
        {
            derecha = TeclaNueva;
        }
        if (teclaVieja == interactuar)
        {
            interactuar = TeclaNueva;
        }
        if (teclaVieja == interactuar)
        {
            interactuar = TeclaNueva;
        }
        if (teclaVieja == interactuar)
        {
            interactuar = TeclaNueva;
        }
        if (teclaVieja == interactuar)
        {
            interactuar = TeclaNueva;
        }
        if (teclaVieja == interactuar)
        {
            interactuar = TeclaNueva;
        }
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