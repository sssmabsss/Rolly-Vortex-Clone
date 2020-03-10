using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    public PlayerController InputReceiver = null;
    public PipeEngine StartReceiver = null;

    private RectTransform _rectTransform = null;

    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 delta = new Vector2(
            data.delta.x / _rectTransform.rect.width,
            data.delta.y / _rectTransform.rect.height);
        InputReceiver.OnDrag(delta);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        StartReceiver.OnGameStart();
    }

    public void onClickPlay()
    {
          StartReceiver.OnGameStart();

    }
}
