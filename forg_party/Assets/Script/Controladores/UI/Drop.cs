using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class Drop : MonoBehaviour, IDropHandler
{
    public static Drop instance;
    Image dropeada;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.Log("Mas de un Drop en escena");
    }
 
    public void OnDrop(PointerEventData eventData)
    {
        
    }
}
