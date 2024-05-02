using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
   [SerializeField] private Canvas canvas;
   private RectTransform rectTransform;
   
   private TMP_Text textComponent;

   private CanvasGroup canvasGroup;
   
   private void Awake()
   {
       rectTransform = GetComponent<RectTransform>();
         canvasGroup = GetComponent<CanvasGroup>();
   }
   
    public void OnBeginDrag(PointerEventData eventData)
    {
         // Debug.Log("OnBeginDrag");
            canvasGroup.alpha = .6f;
         canvasGroup.blocksRaycasts = false;
         
         GameObject draggedObject = eventData.pointerDrag;
         textComponent = draggedObject.GetComponentInChildren<TMP_Text>();
         // Debug.Log(textComponent.text); // this will print the text of the dragged object
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        // Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        // Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        // Debug.Log("OnPointerDown");
    }

    public string GetTextComponent()
    {
        if (textComponent != null)
        {
            return textComponent.text;
        }
        else
        {
            return null;
        }
    }
}
