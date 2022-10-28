using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;


public class DragAndDrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static DragAndDrop instance;
    [HideInInspector] public Transform parentAfterDrag;
    public Image image;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.Log("Mas de un Drop en escena");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        string nameOfBlock = gameObject.name;
        if(nameOfBlock == "comida1") ControladorNecesidades.instance.cambiarComida(5);
        else if(nameOfBlock =="comida2") ControladorNecesidades.instance.cambiarComida(10);
        else if(nameOfBlock == "comida3") ControladorNecesidades.instance.cambiarComida(20);
        else if(nameOfBlock == "comida4") ControladorNecesidades.instance.cambiarComida(30);
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
}