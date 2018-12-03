using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "nuevoItem", menuName = "ItemsTienda")]
public class SOItem : ScriptableObject
{
    public new string name;
    public short cost;
    public Sprite icono;

    public short fisico;
    public short vidaMaxima;
    public short velocidadMovimiento;
    public short danio;
    public short resistenciaFisica;
    [Space]
    public short mental;
    public short poderMagico;
    public short poderCuracionesEscudo;
    public short penetracionFisica;
    public short penetracionMagica;
    public short probabilidadCritico;
    public short danioCritico;
    public short roboVida;
    public short alcanceAtaque;
    public short cadenciaAtaque;
}