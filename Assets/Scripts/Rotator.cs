using UnityEngine;
using UnityEngine.EventSystems;

public class Rotator : MonoBehaviour, IPointerClickHandler
{
    public float rotationSpeed = 50f;
    private bool shouldRotate = false;

    void Update()
    {
        if (shouldRotate) transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        changeRotate();
    }

    public void changeRotate()
    {
        shouldRotate = !shouldRotate;
    }
}
