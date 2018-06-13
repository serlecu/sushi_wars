using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DraggableImage : MonoBehaviour, UnityEngine.EventSystems.IDragHandler
{

    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
}
