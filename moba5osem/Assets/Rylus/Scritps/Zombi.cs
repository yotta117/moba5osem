using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class Zombi : MonoBehaviour
{
    //--|||--|||--
    #region Propiedades Clase
    private NavMeshAgent zombi;
    private Transform posicionJugador;

    //private Transform contenedorPosiciones;
    //[SerializeField] private List<Transform> objetivo = new List<Transform>();
    //[SerializeField] private int currentTarget = 0;
    #endregion
    //--|||--|||--
    #region Propiedades Logica
    private bool persiguiendo = true;
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
        posicionJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        zombi = GetComponent<NavMeshAgent>();
        zombi.stoppingDistance = 0.5f;
    }
    private void Start()
    {
        //contenedorPosiciones = GameObject.Find("ContenedorPunto").GetComponent<Transform>();

        //short numero = (short)contenedorPosiciones.childCount;
        //for (short i = 0; i < numero; i++)
        //{
        //    objetivo.Add(contenedorPosiciones.GetChild(i));
        //}

        //personaje.SetDestination(objetivo[currentTarget].position);
    }
    private void Update()
    {
        //if (personaje.remainingDistance <= personaje.stoppingDistance)
        //{
        //    currentTarget = (currentTarget + 1) >= objetivo.Count ? 0 : currentTarget + 1;
        //    personaje.SetDestination(objetivo[currentTarget].position);
        //}
        zombi.SetDestination(posicionJugador.position);
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
    public void Morir()
    {   
        Destroy(gameObject, 0.5f);
    }
    public void VolverCueva()
    {
        persiguiendo = false;
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