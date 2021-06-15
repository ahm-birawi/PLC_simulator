using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrPanel : MonoBehaviour
{
    public int height = 77;
    public int height1=0;
    public int width;
    int panel1;
    int panel2;
    public Transform panel1T;
    public Transform panel2T;
    void Update()
    {
        panel1 = panel1T.childCount-1;
        panel2 = panel2T.childCount-1;
        if (transform.Find("Panel/minirung(Clone)") != null)
        {
            panel1 += panel1T.GetComponentInChildren<OrPanel>().width;
            height1 = panel1T.GetComponentInChildren<OrPanel>().height;

            
        }
        if (transform.Find("Panel (1)/minirung(Clone)") != null)
        {
            panel2 += panel2T.GetComponentInChildren<OrPanel>().width;

        }
        if (panel1 > panel2)
            width = panel1;
        else
            width = panel2;
        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(50 + width * 50, height+height1/2 );
        panel2T.localPosition = new Vector2(transform.Find("loweredge").localPosition.x, transform.Find("loweredge").localPosition.y);
        Debug.Log(transform.GetComponent<RectTransform>().sizeDelta.y);
        if (transform.parent.parent.name == "minirung(Clone)")
        {
            transform.localPosition = new Vector2(0, 0);
        }

    }
}
