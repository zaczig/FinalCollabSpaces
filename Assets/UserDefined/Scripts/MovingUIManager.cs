using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class MovingUIManager : MonoBehaviour
{
    [SerializeField] Sprite[] imagesList;
    [SerializeField] TMP_Text label;
    private Image myImage;
    public InputActionProperty secondaryButton;
    private string[] viewpoint = { "Blue", "Black", "Yellow", "Red" };
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        myImage = this.GetComponent<Image>();
        label.text = viewpoint[index];
        myImage.sprite = imagesList[index];
    }

    // Update is called once per frame
    void Update()
    {
        if (secondaryButton.action.WasPressedThisFrame())
        {
            if (index >= viewpoint.Length) index = 0;
            else
            {
                index++;
            }
            label.text = viewpoint[index];
            myImage.sprite = imagesList[index];
        }

    }
}
