using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class saulvo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool antoniango = false;
    [System.Serializable]
    public class bradforddolan : UnityEvent { }
    [SerializeField]
    private bradforddolan myOwnEvent = new bradforddolan();
    public bradforddolan onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, maryannrosen = 1f;
    private Vector3 startPosition, genatan;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (antoniango)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (antoniango)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator barbaramagana()
    {
        yield return estherstallings(transform, transform.localPosition, genatan, maryannrosen);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float christianschumacher = 1.0f / value;
        float christianmiles = 0.0f;
        while (christianmiles < 1.0)
        {
            christianmiles += Time.deltaTime * christianschumacher;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, christianmiles));
            yield return null;
        }

        thisTransform.localPosition = genatan;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        genatan = EPos;

        maryannrosen = MTime;

        StartCoroutine(barbaramagana());
    }
}
