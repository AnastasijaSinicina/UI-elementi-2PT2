using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//importe lai lietotu pointer darbibu interfeisu
using UnityEngine.EventSystems;

//piesaistam interfeisu 
public class ObjektuParvietosana : MonoBehaviour,
    IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform transformKomponente;
    public Canvas kanva;

    void Start()
    {
        //startejot automatiski pieklust
        transformKomponente = GetComponent<RectTransform>();

    }
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Izdarits peles kliskis uz objekta");

    }
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsakta objekta vilksana");

    }
    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notiek obkekta parvietosana!");
        transformKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }
    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Objekta vilksana pabeigta!");
    }
}
