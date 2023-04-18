using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewTestUI : MonoBehaviour
{
    public void AddChild()
    {
        GameObject gameObject = new GameObject("Child");
        gameObject.transform.SetParent(this.transform);

        gameObject.AddComponent<TextMeshPro>().text = "Hello This is Child";
    }
}
