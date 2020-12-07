using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject ControlsParent;
    public RawImage Background;

    public void OnActiveControlsUI()
    {
        ControlsParent.SetActive(!ControlsParent.activeSelf);
        Background.enabled = ControlsParent.activeSelf;
    }
}
