using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSciFiHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 originalScale;

    public Text buttonText;
    Color originalTextColor;

    public Color hoverTextColor = Color.cyan;

    void Start()
    {
        originalScale = transform.localScale;

        if (buttonText != null)
        {
            originalTextColor = buttonText.color;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = originalScale * 1.1f;

        if (buttonText != null)
            buttonText.color = hoverTextColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale;

        if (buttonText != null)
            buttonText.color = originalTextColor;
    }
}