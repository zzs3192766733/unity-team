using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitDescription : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
    }
    private void Update()
    {
        button.onClick.AddListener(F);
    }
    private void F()
    {
        PlayerSelection.CloseDescription();
    }
}
