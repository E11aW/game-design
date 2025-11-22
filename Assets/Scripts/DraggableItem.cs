using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public string itemID;
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    private Slot previousSlot;
    public AudioSource se;


    public void OnBeginDrag(PointerEventData eventData)
    {
        previousSlot = GetComponentInParent<Slot>();
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;

        if (previousSlot != null)
        {
            previousSlot.currentItem = null;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {

        transform.position = Mouse.current.position.ReadValue();
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;

        // Update slot reference
        Slot newSlot = GetComponentInParent<Slot>();
        if (newSlot != null)
        {
            newSlot.currentItem = this;
            se.Play();
        }
    }
}
