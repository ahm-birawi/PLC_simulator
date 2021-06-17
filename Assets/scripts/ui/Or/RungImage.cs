using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RungImage : MonoBehaviour
{
    int child_hieght = 0;

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform.GetChild(0).GetChild(0))
        {
            if (child.tag == "OR")
            {

                OrPanel x = child.GetComponent<OrPanel>();
                if (x.height + x.height1 / 2 + x.height2 / 2 + x.height2P / 2 > child_hieght)
                    child_hieght = x.height + x.height1 / 2 + x.height2 / 2 + x.height2P/ 2;
            }
            else
                child_hieght = 0;
            
        }
        if (child_hieght > 0)
            transform.GetComponent<RectTransform>().sizeDelta = new Vector2(transform.GetComponent<RectTransform>().sizeDelta.x,child_hieght);

    }
}
