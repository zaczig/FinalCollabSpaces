using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScaler : MonoBehaviour
{
    [SerializeField]
    private float defaultHeight = 1.8f;
    [SerializeField]
    private Camera camera1;

    private void Resize()
    {
        float headHeight = camera1.transform.localPosition.y;
        float scale = defaultHeight / headHeight;
        transform.localScale = Vector3.one * scale;
    }

    void OnEnable()
    {
        Resize();
    }
}