using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tc_test : MonoBehaviour
{
    private void Update()
    {
        var x = gameObject.GetComponentInParent<TON>();
        Debug.Log(x.acc);
        Debug.Log(x.preset);

    }
}
