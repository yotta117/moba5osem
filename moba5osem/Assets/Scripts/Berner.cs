using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class Berner : MonoBehaviour
{
    //--|||--|||--
    #region Propiedades Clase
    [SerializeField] private Transform posicionManoDerecha;
    [SerializeField] Vector3 offsetManoDerecha;
    [SerializeField] private Transform posicionManoIzuierda;
    [SerializeField] Vector3 offsetManoIzquierda;
    [HideInInspector] public Vector3  posicionVista;
    private Animator animacionPersonaje;
    [SerializeField] private Vector3 offsetPies;
    #endregion
    //--|||--|||--
    #region Propiedades Logica
    private short randomActual = 0;
    private float estadoActual = 0;
    private float equis = 0;
    private float zeta = 0;

    private Rigidbody cuerpoRigido;
    #endregion
    //--|||--|||--
    #region Propiedades Constantes

    #endregion





    //--|||--|||--
    #region Metodos MonoBehaviour
    private void Awake()
    {
        animacionPersonaje = GetComponent<Animator>();
        cuerpoRigido = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
    }
    private void Start()
    {
    }
    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            animacionPersonaje.SetFloat("Equis", horizontal * 2 );
            animacionPersonaje.SetFloat("Zeta", vertical * 2);
            animacionPersonaje.SetFloat("State", 0);
            animacionPersonaje.SetFloat("Random", 0);
        } else
        {
            animacionPersonaje.SetFloat("Equis", horizontal);
            animacionPersonaje.SetFloat("Zeta", vertical);
            animacionPersonaje.SetFloat("State", 0);
            animacionPersonaje.SetFloat("Random", 0);
        }
        if (vertical == 0 && horizontal == 0)
        {
            cuerpoRigido.velocity = Vector3.zero;
        }
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
    private void OnAnimatorIK(int layerIndex)
    {
        animacionPersonaje.SetLookAtPosition(posicionVista);
        animacionPersonaje.SetLookAtWeight(1);

        #region Manos
        animacionPersonaje.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        animacionPersonaje.SetIKPosition(AvatarIKGoal.LeftHand, posicionManoIzuierda.position + offsetManoIzquierda);

        animacionPersonaje.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        animacionPersonaje.SetIKPosition(AvatarIKGoal.RightHand, posicionManoDerecha.position + offsetManoDerecha);
        #endregion
        #region Pies
        RaycastHit hit;
        Vector3 posicionPieIzquierdo = animacionPersonaje.GetIKPosition(AvatarIKGoal.LeftFoot);
        Quaternion rotacionPieIzquierdo = animacionPersonaje.GetIKRotation(AvatarIKGoal.LeftFoot);
        if (Physics.Raycast(posicionPieIzquierdo + Vector3.up, Vector3.down, out hit, 10, LayerMask.GetMask("Ground")))
        {
            animacionPersonaje.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);
            animacionPersonaje.SetIKPosition(AvatarIKGoal.LeftFoot, hit.point + offsetPies);
            animacionPersonaje.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1);
            Quaternion normalHit = Quaternion.LookRotation(Vector3.ProjectOnPlane(transform.forward, hit.normal));
            animacionPersonaje.SetIKRotation(AvatarIKGoal.LeftFoot, normalHit);
        }

        Vector3 posicionPieDerecho = animacionPersonaje.GetIKPosition(AvatarIKGoal.RightFoot);
        Quaternion rotacionPieDerecho = animacionPersonaje.GetIKRotation(AvatarIKGoal.RightFoot);
        if (Physics.Raycast(posicionPieDerecho + Vector3.up, Vector3.down, out hit, 10, LayerMask.GetMask("Ground")))
        {
            animacionPersonaje.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);
            animacionPersonaje.SetIKPosition(AvatarIKGoal.RightFoot, hit.point + offsetPies);
            animacionPersonaje.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1);
            Quaternion normalHit = Quaternion.LookRotation(Vector3.ProjectOnPlane(transform.forward, hit.normal));
            animacionPersonaje.SetIKRotation(AvatarIKGoal.RightFoot, normalHit);
        }
        #endregion
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