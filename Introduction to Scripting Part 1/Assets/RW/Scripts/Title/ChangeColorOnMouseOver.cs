using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColorOnMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public MeshRenderer model; 
    public Color normalColor; 
    public Color hoverColor;
    void Start()
    {
        model.material.color = normalColor;

    }

    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData) // 1
    {
        model.material.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData) // 2
    {
        model.material.color = normalColor;
    }

}
