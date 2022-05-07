using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopUp : MonoBehaviour
{
    // Start is called before the first frame update
   public void Close()
    {
        Destroy(this.gameObject);
    }
}
