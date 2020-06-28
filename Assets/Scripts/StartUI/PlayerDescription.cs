using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDescription : MonoBehaviour
{
    [HideInInspector]
    public Text text;
    private void Awake()
    {
        text = GetComponentInChildren<Text>();
    }
}
