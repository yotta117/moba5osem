using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadFabrica : AIState {

    public GameObject objetoAInstanciar;

    private float _timer = 3.0f;

    public override AIStateType GetStateType()
    {
        return AIStateType.Dead;
    }

    public override void OnEnterState()
    {
        Debug.Log("Muerto");
    }

    public override void OnExitState()
    {
        throw new System.NotImplementedException();
    }

    public override AIStateType OnUpdate()
    {
        _timer -= Time.deltaTime;
        if (_timer < 0.0f)
        {
            Destroy(this.gameObject);
            
            Instantiate(objetoAInstanciar,transform);
        }

        return AIStateType.Dead;
    }
}
