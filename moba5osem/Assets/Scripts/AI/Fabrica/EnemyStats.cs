using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {


    FSM enemyMachine;
    Animator myAnimator;
    int randomAnimImpact;
    [SerializeField]
    //private Animation[] animations = new Animation[3];
    public float health = 100;

    private void Awake()
    {
        enemyMachine = GetComponent<FSM>();
        myAnimator = GetComponent<Animator>();
        
    }

    public void Damage(float amount)
    {
        health -= amount;
        enemyMachine.hitDamage = true;
        randomAnimImpact = Random.Range(1, 4);
        myAnimator.SetInteger("RandomImpact", randomAnimImpact);
        enemyMachine.hitDamage = true;
        myAnimator.SetBool("ReceivingShoot", enemyMachine.hitDamage);
        
        
        Debug.Log("Recibio daño" + health + "Random anim" + randomAnimImpact);
    }

}
