using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrPanel : MonoBehaviour
{
    public int height = 77;
    public int height1 = 0;
    public int height2 = 0;
    public int height2P = 0;
    
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
            height1 = 77 + panel1T.GetComponentInChildren<OrPanel>().height1 + panel1T.GetComponentInChildren<OrPanel>().height2;


            
        }
        if (transform.Find("Panel (1)/minirung(Clone)") != null)
        {
            panel2 += panel2T.GetComponentInChildren<OrPanel>().width;
            height2 = 77 + panel2T.GetComponentInChildren<OrPanel>().height1;
            height2P = panel2T.GetComponentInChildren<OrPanel>().height2 + panel2T.GetComponentInChildren<OrPanel>().height2P;


        }
        if (panel1 > panel2)
            width = panel1;
        else
            width = panel2;
        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(60 + width * 50, height+height1/2 );
        panel2T.localPosition = new Vector2(transform.Find("loweredge").localPosition.x, transform.Find("loweredge").localPosition.y);
        panel1T.GetComponent<RectTransform>().sizeDelta= new Vector2(panel1T.GetComponent<RectTransform>().sizeDelta.x, 38);
        panel2T.GetComponent<RectTransform>().sizeDelta = new Vector2(panel2T.GetComponent<RectTransform>().sizeDelta.x, 38);
        //Debug.Log(transform.GetComponent<RectTransform>().sizeDelta.y);
        if (transform.parent.parent.name == "minirung(Clone)")
        {
            transform.localPosition = new Vector2(0, 0);
        }
        /*if (transform.parent.parent.parent.tag == "rung")
        {

            transform.parent.parent.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(transform.parent.parent.parent.GetComponent<RectTransform>().sizeDelta.x, height + height1 / 2 + height2 / 2);
            Debug.Log("good");
        }*/
    }
}
