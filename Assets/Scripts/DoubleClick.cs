using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoubleClick : MonoBehaviour, IPointerClickHandler, IDropHandler, IDragHandler
{
    public Button button;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        
        
        if (eventData.clickCount >= 2)
        {
            
        }
        else
        {
            
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        eventData.position
    }
}
