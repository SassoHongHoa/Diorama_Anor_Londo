using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject ControlsParent;

    public void OnActiveControlsUI()
    {
        ControlsParent.SetActive(!ControlsParent.activeSelf);
    }
}
