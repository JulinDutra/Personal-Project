using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float speed = 5;

    private void Start()
    {
        if (InfoManager.Instance != null)
        {
            InfoManager.Instance.playerName = "Fulano";
        }
    }

    // POLYMORPHISM
    public virtual void SpawnEnemy(Transform target)
    {
        if(target != null)
        {
            Instantiate(gameObject, new Vector3(20.5f, target.transform.position.y, 0f), gameObject.transform.rotation);
        }
    }

    public virtual void SpawnEnemy(Vector3 positionTarget)
    {
        if (positionTarget != null || positionTarget.x > -20f || positionTarget.y < 10.02f || positionTarget.y > -8.07f || positionTarget.z != 0)
        {
            Instantiate(gameObject, positionTarget, gameObject.transform.rotation);
        }
    }
}
