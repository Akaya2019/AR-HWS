using UnityEngine;
using UnityEngine.EventSystems; // EventSystems namespace'ini kullanmak için gerekli

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public RectTransform backgroundRect;
    public RectTransform thumbstickRect;
    public Vector2 inputVector;

    void Start()
    {
        backgroundRect = GetComponent<RectTransform>();
        thumbstickRect = transform.GetChild(0).GetComponent<RectTransform>();
    }

    public virtual void OnDrag(PointerEventData eventData)
    {
        Vector2 position;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(backgroundRect, eventData.position, eventData.pressEventCamera, out position))
        {
            position.x = (position.x / backgroundRect.sizeDelta.x);
            position.y = (position.y / backgroundRect.sizeDelta.y);

            inputVector = new Vector2(position.x * 2, position.y * 2);
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            thumbstickRect.anchoredPosition = new Vector2(inputVector.x * (backgroundRect.sizeDelta.x / 2), inputVector.y * (backgroundRect.sizeDelta.y / 2));
        }
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector2.zero;
        thumbstickRect.anchoredPosition = Vector2.zero;
    }

    public float Horizontal()
    {
        return inputVector.x;
    }

    public float Vertical()
    {
        return inputVector.y;
    }
}
