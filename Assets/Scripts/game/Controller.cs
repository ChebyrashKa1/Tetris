using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour, IPointerDownHandler, IPointerClickHandler,
    IPointerUpHandler, IPointerExitHandler, IPointerEnterHandler,
    IBeginDragHandler, IDragHandler, IEndDragHandler{

	public void OnBeginDrag(PointerEventData eventData)
    {
		collisionDesk.objectControlBlock = null;
		stateBlock.dragOff = false;
		collisionDesk.objectControlBlock = this.gameObject;//eventData.pointerCurrentRaycast.gameObject.transform.pare;
		collisionDesk.posControlBlock = this.gameObject.transform.position;
		//eventData.pointerCurrentRaycast.gameObject.transform.parent.GetChild(4).GetComponent<stateBlock>().enabled = true;

		Debug.Log("Drag Begin: " + collisionDesk.objectControlBlock);
    }

    public void OnDrag(PointerEventData eventData)
    {
		Ray ray = Camera.main.ScreenPointToRay (eventData.position);
		Vector3 rayPoint = ray.GetPoint (Vector3.Distance (transform.position, Camera.main.transform.position));
		transform.position = rayPoint;
		//Debug.Log("Dragging");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
		stateBlock.dragOff = true;
		//Debug.Log("Drag Ended" + stateBlock.dragOff);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       // Debug.Log("Mouse Down: " + eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       // Debug.Log("Mouse Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Mouse Exit");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Mouse Up");
    }
}
