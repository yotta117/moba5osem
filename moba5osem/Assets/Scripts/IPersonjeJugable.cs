using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPersonjeJugable
{
    long experiencia { get; set; }
    bool ataqueDistancia { get; set; }


    short FisicoBase { get; set; }//--|||--|||--
    short FisicoEscalado { get; set; }
    short FisicoItems { get; set; }
    short FisicoConfig { get; set; }
    short FisicoBuffs { get; set; }
    short FisicoTotal { get; set; }

    short vidaMaximabase { get; set; }
    short vidaMaximaEscalado { get; set; }
    short vidaMaximaItems { get; set; }
    short vidaMaximaConfig { get; set; }
    short vidaMaximaBuffs { get; set; }
    short VidaMaximaTotal { get; set; }

    short velocidadMovimientoBase { get; set; }
    short velocidadMovimientoEscalado { get; set; }
    short velocidadMovimientoItems { get; set; }
    short velocidadMovimientoConfig { get; set; }
    short velocidadMovimientoBuffs { get; set; }
    short VelocidadMovimientoTotal { get; set; }

    short danioBase { get; set; }
    short danioEscalado { get; set; }
    short danioItems { get; set; }
    short danioConfig { get; set; }
    short danioBuffs { get; set; }
    short danioTotal { get; set; }

    short resistenciaFisicaBase { get; set; }
    short resistenciaFisicaEscalado { get; set; }
    short resistenciaFisicaItems { get; set; }
    short resistenciaFisicaConfig { get; set; }
    short resistenciaFisicaBuffs { get; set; }
    short resistenciaFisicaTotal { get; set; }


    short diminucionTiempoBuffsBase { get; set; }
    short disminucionTiempoBuffsEscalado { get; set; }
    short disminucionTiempoBuffsItems { get; set; }
    short disminucionTiempoBuffsConfig { get; set; }
    short disminucionTiempoBuffsBuffs { get; set; }
    short disminucionTiempoBuffsTotal { get; set; }

    short regeneracionVidaBase { get; set; }
    short regeneracionVidaEscalado { get; set; }
    short regeneracionVidaItems { get; set; }
    short regeneracionVidaConfig { get; set; }
    short regeneracionVidaBuffs { get; set; }
    short regeneracionVidaTotal { get; set; }


    short mentalBase { get; set; }//--|||--|||--
    short mentalEscalado { get; set; }
    short mentalItems { get; set; }
    short mentalConfig { get; set; }
    short mentalBuffs { get; set; }
    short mentalTotal { get; set; }

    short resistenciaMagicaBase { get; set; }
    short resistenciaMagicaItems { get; set; }
    short resistenciaMagicaConfig { get; set; }
    short resistenciaMagicaBuffs { get; set; }
    short resistenciaMagicaTotal { get; set; }

    short poderMagicoBase { get; set; }
    short poderMagicoEscalado { get; set; }
    short poderMagicoItems { get; set; }
    short poderMagicoConfig { get; set; }
    short poderMagicoBuffs { get; set; }
    short poderMagicoTotal { get; set; }

    short poderCuracionesEscudoBase { get; set; }
    short poderCuracionesEscudoEscalado { get; set; }
    short poderCuracionesEscudoItems { get; set; }
    short poderCuracionesEscudoConfig { get; set; }
    short poderCuracionesEscudoBuffs { get; set; }
    short poderCuracionesEscudoTotal { get; set; }

    short penetracionFisicaBase { get; set; }
    short penetracionFisicaEscalado { get; set; }
    short penetracionFisicaItems { get; set; }
    short penetracionFisicaConfig { get; set; }
    short penetracionFisicaBuffs { get; set; }
    short penetracionFisicaTotal { get; set; }

    short penetracionMagicaBase { get; set; }
    short penetracionMagicaEscalado { get; set; }
    short penetracionMagicaItems { get; set; }
    short penetracionMagicaConfig { get; set; }
    short penetracionMagicaBuffs { get; set; }
    short penetracionMagicaTotal { get; set; }

    //--|||--|||--
    short probabilidadCriticoBase { get; set; }
    short probabilidadCriticoItems { get; set; }
    short probabilidadCriticoConfig { get; set; }
    short probabilidadCriticoBuffs { get; set; }
    short probabilidadCriticoTotal { get; set; }

    short danioCriticoBase { get; set; }
    short danioCriticoItems { get; set; }
    short danioCriticoConfig { get; set; }
    short danioCriticoBuffs { get; set; }
    short danioCriticoTotal { get; set; }

    short roboVidaBase { get; set; }
    short roboVidaItems { get; set; }
    short roboVidaConfig { get; set; }
    short roboVidaBuffs { get; set; }
    short roboVidaTotal { get; set; }

    short alcanceAtaqueBase { get; set; }
    short alcanceAtaqueItems { get; set; }
    short alcanceAtaqueConfig { get; set; }
    short alcanceAtaqueBuffs { get; set; }
    short alcanceAtaqueTotal { get; set; }

    short cadenciaAtaqueBase { get; set; }
    short cadenciaAtaqueItems { get; set; }
    short cadenciaAtaqueConfig { get; set; }
    short cadenciaAtaqueBuffs { get; set; }
    short cadenciaAtaqueTotal { get; set; }



    //--|||--|||--
    void Moverse();
    void Correr();
    void Atacar();
    void Morir();
    void SubirNivel();

    void Q();
    void W();
    void E();
    void R();

    //bool RecibirCC(CC cc, Personaje personaje);
    //bool RecibirDanio(Danio danio, Personaje personaje);
    //bool RecibirCuracion(Curacion curacion, Personaje personaje);
}