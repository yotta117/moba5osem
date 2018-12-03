using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
//[RequireComponent(typeof())]
public class ScriptTemporal : MonoBehaviour
{
    //--|||--|||--
    #region Propiedades Clase
    [SerializeField] private Transform manoDerecha = null;
    [SerializeField] private Transform manoIzuierda = null;
    [SerializeField] private Transform ver = null;

    Animator animacion = null;

    [SerializeField] Vector3 offset = new Vector3(0, 0.05f, 0);
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
        animacion = GetComponent<Animator>();
    }
    private void OnEnable()
    {
    }
    private void Start()
    {       
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
    private void OnAnimatorIK(int layerIndex)
    {

        animacion.SetLookAtPosition(ver.position);
        animacion.SetLookAtWeight(1);

        Vector3 posicionPieIzquierdo = animacion.GetIKPosition(AvatarIKGoal.LeftFoot);
        Vector3 posicionPieDerecho = animacion.GetIKPosition(AvatarIKGoal.RightFoot);
        Quaternion rotacionPieIzquierdo = animacion.GetIKRotation(AvatarIKGoal.LeftFoot);
        Quaternion rotacionPieDerecho = animacion.GetIKRotation(AvatarIKGoal.RightFoot);

        animacion.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        animacion.SetIKPosition(AvatarIKGoal.LeftHand, manoIzuierda.position);
        animacion.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        animacion.SetIKPosition(AvatarIKGoal.RightHand, manoDerecha.position);

        RaycastHit hit;
        if (Physics.Raycast(posicionPieIzquierdo + Vector3.up, Vector3.down, out hit, 10, LayerMask.GetMask("Piso")))
        {
            animacion.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);
            animacion.SetIKPosition(AvatarIKGoal.LeftFoot, hit.point + offset);

            animacion.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1);
            Quaternion normalHit = Quaternion.LookRotation(Vector3.ProjectOnPlane(transform.forward, hit.normal));
            animacion.SetIKRotation(AvatarIKGoal.LeftFoot, normalHit);
        }
        if (Physics.Raycast(posicionPieDerecho + Vector3.up, Vector3.down, out hit, 10, LayerMask.GetMask("Piso")))
        {
            animacion.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);
            animacion.SetIKPosition(AvatarIKGoal.RightFoot, hit.point + offset);
            animacion.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1);
            Quaternion normalHit = Quaternion.LookRotation(Vector3.ProjectOnPlane(transform.forward, hit.normal));
            animacion.SetIKRotation(AvatarIKGoal.RightFoot, normalHit);
        }
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