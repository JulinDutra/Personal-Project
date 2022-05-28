using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void Update()
    {
        if(this.gameObject.transform.parent.transform.position.x < -24.7f)
        {
            Debug.Log("Objeto destruído.");
            Destroy(this.gameObject);
        }
    }
}
