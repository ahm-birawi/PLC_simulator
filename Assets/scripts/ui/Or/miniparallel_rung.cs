using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniparallel_rung : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount == 0 && this.transform.parent.GetChild(1).childCount == 0)
        { Destroy(this.transform.parent.gameObject);

            Transform rungrect = this.transform.parent.parent.parent.parent;
            RectTransform panelRectTransform = rungrect.GetComponent<RectTransform>();

            panelRectTransform.sizeDelta = new Vector2(panelRectTransform.sizeDelta.x, 38);

        }


         
    


    }


}