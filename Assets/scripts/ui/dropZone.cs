using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

	public int length = 0;
	static int allowedLenght = 7;
	
    public void OnPointerEnter(PointerEventData eventData)
	{
		length = 0;
		for (int i = 0; i < this.transform.childCount; i++)
		{
			Debug.Log("1");
			if (transform.GetChild(i).tag != "OR")
				length += 1;
			//else
			//length += orlength;

		}

		//Debug.Log("OnPointerEnter");
		if (eventData.pointerDrag == null)
			return;

		draggable d = eventData.pointerDrag.GetComponent<draggable>();
		if (d != null & length < allowedLenght)
		{
			d.placeholderParent = this.transform;
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		//Debug.Log("OnPointerExit");
		if (eventData.pointerDrag == null)
			return;

		draggable d = eventData.pointerDrag.GetComponent<draggable>();
		if (d != null && d.placeholderParent == this.transform & length < allowedLenght)
		{
			d.placeholderParent = d.parentToReturnTo;
		}
	}

	public void OnDrop(PointerEventData eventData)
	{
		
		draggable d = eventData.pointerDrag.GetComponent<draggable>();
		if (d != null & length < allowedLenght)
		{
			d.parentToReturnTo = this.transform;

		}

	}
    
    
}
