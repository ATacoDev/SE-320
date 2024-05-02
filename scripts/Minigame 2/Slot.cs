using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    
    // each slot will have a character assigned to it
    private string slotCharacter;
    [SerializeField] DragDrop dragDrop;
    
    public void OnDrop(PointerEventData eventData)
    {
        // Debug.Log("On Drop");
        if(eventData.pointerDrag != null)
        {
             dragDrop = eventData.pointerDrag.GetComponent<DragDrop>();

            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            slotCharacter = dragDrop.GetTextComponent();
            // Debug.Log("Character: " + slotCharacter);
        }
    }
    
    public string GetSlotCharacter()
    {
        return slotCharacter;
    }
    
    public void resetSlotCharacter()
    {
        slotCharacter = null;
    }
    
}

