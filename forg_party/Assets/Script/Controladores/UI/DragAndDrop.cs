using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private bool pressed;
    private Image imagen;
    private Vector2 posicionInicial;


    private void Awake()
    {
        imagen.GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        posicionInicial = eventData.position;
        pressed = true; 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.position =  posicionInicial;
        pressed = false;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        
        transform.position = eventData.position;   
    }
}
