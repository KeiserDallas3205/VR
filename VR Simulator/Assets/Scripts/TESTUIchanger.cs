using System.Collections;
using TMPro;
using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;

public class TESTUIchanger : MonoBehaviour
{
    //public TextMeshPro uiText;
    //public GameObject ui;
    //public XRGrabInteractable grabbable;

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        //uiText.enabled = false;
        //ui.SetActive(false);
        text = gameObject.GetComponent<TextMeshProUGUI>();
        text.enabled = false;
    }

    // Update is called once per frame
    void OnGrab()
    {
        //uiText.enabled = true;
        //ui.SetActive(true);
        text.enabled = true;
        StartCoroutine("WaitForSec");

    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(20);
        //Destroy(uiText);
        //Destroy(ui);
    }
}
