using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public RectTransform UI_Element;//代表ui的一个元素
    public RectTransform CanvasRect;//跟坐标相关
    public Transform trashBinPos;
    public float xOffset;
    public float yOffset;
    public Text coinNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 viewportPos = Camera.main.WorldToViewportPoint(trashBinPos.position);
        Vector2 worldObjectScreenPos = new Vector2((viewportPos.x * CanvasRect.sizeDelta.x)-(CanvasRect.sizeDelta.x * 0.5f) + xOffset,
                                                   (viewportPos.y * CanvasRect.sizeDelta.y) - (CanvasRect.sizeDelta.y * 0.5f) + yOffset);
        UI_Element.anchoredPosition = worldObjectScreenPos;//实现UI物体跟着特定的物体走
    }
}
