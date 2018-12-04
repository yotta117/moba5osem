using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Vista : MonoBehaviour
{
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

    //--|||--|||--
    #region Propiedades Clase
    public float sensibilidad = 5.0f;
    public float suavizado = 2.0f;
    #endregion
    //--|||--|||--
    #region Propiedades Logica
    private Vector2 vistaMouse;
    private Vector2 vectorSuavizado;
    public bool mouseBloqueado = false;

    private Transform pivoteCamara;
    private Transform camaraVista;
    private Transform posicionVistaPerdida;
    private Berner jugador;
    [SerializeField] private Transform rifleFrancotirador = null;
    #endregion
    //--|||--|||--
    #region Propiedades Constantes

    #endregion





    //--|||--|||--
    #region Metodos MonoBehaviour
    private void Awake()
    {
        jugador = GetComponent<Berner>();
        pivoteCamara = transform.GetChild(0);
        camaraVista = pivoteCamara.transform.GetChild(0);
        posicionVistaPerdida = camaraVista.GetChild(0);
        SwitchBloquearMouse();
        //rifleFrancotirador = transform.GetChild(1);
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
        Apuntar();
    }
    private void OnDisable()
    {
    }
    #endregion





    //--|||--|||--
    #region Metodos Clase
    // Metodo encargado de mover la camara como un FPS estandard.
    private void Apuntar()
    {
        Vector2 entradaMouse = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")); // Vector 2 que se usa para rastrear la posicion del mouse.
        entradaMouse = Vector2.Scale(entradaMouse, new Vector2(sensibilidad * suavizado, sensibilidad * suavizado)); // El vector entrada mouse se escala segun el suavizado y sensivilidad del mouse ingame.
        vectorSuavizado = new Vector2(Mathf.Lerp(vectorSuavizado.x, entradaMouse.x, 1f / suavizado), Mathf.Lerp(vectorSuavizado.y, entradaMouse.y, 1f / suavizado));
        vistaMouse += vectorSuavizado;
        // Limitar lo maximo que puede rotar la camara verticalmente el jugador.
        if (vistaMouse.y > 66)
        {
            vistaMouse.y = 66;
        }
        // Limitar lo minimo que puede rotar la camara verticalmente el jugador.
        if (vistaMouse.y < -66)
        {
            vistaMouse.y = -66;
        }

        RaycastHit rayoApuntarVista;
        if (Input.GetButtonDown("Fire1"))
        {
            
            if (Physics.Raycast(camaraVista.position, camaraVista.TransformDirection(Vector3.forward), out rayoApuntarVista, 100))
            {
                Debug.DrawRay(camaraVista.position, camaraVista.TransformDirection(Vector3.forward) * rayoApuntarVista.distance, Color.yellow);
                Debug.Log(rayoApuntarVista.transform.name);
                jugador.posicionVista = rayoApuntarVista.point;
                rifleFrancotirador.LookAt(rayoApuntarVista.point);
            }
        }
        else
        {
            rifleFrancotirador.LookAt(posicionVistaPerdida.position);
            jugador.posicionVista = posicionVistaPerdida.position;
        }


        pivoteCamara.transform.localRotation = Quaternion.AngleAxis(-vistaMouse.y, Vector3.right);
        transform.localRotation = Quaternion.AngleAxis(vistaMouse.x, Vector3.up);
    }
    // Metodo encargado de hacer que se oculte el mouse a la hora de jugar.
    private void SwitchBloquearMouse()
    {
        mouseBloqueado = !mouseBloqueado;
        if (mouseBloqueado)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
    #endregion
}