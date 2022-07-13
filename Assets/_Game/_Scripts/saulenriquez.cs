using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class saulenriquez : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool berthashipley = false;
    [System.Serializable]
    public class wilfredofrench : UnityEvent { }
    [SerializeField]
    private wilfredofrench myOwnEvent = new wilfredofrench();
    public wilfredofrench onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, mamiealfaro = 1f;
    private Vector3 startPosition, madgelatham;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (berthashipley)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (berthashipley)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator kristasinger()
    {
        yield return estherstallings(transform, transform.localPosition, madgelatham, mamiealfaro);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float sherrypelletier = 1.0f / value;
        float jodymcdaniel = 0.0f;
        while (jodymcdaniel < 1.0)
        {
            jodymcdaniel += Time.deltaTime * sherrypelletier;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, jodymcdaniel));
            yield return null;
        }

        thisTransform.localPosition = madgelatham;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        madgelatham = EPos;

        mamiealfaro = MTime;

        StartCoroutine(kristasinger());
    }
}
