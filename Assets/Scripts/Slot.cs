using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0)
        {
            GameObject droppedItem = eventData.pointerDrag;
            DraggableItem draggableItem = droppedItem.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
        }
    }
}
