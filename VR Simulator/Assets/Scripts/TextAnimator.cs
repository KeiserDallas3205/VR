using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAnimator : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tmpText;
    [SerializeField] float timeBetweenChars;
    [SerializeField] float timeBetweenWords;

    public string[] arr;

    int i = 0;



    void Start()
    {
        EndCheck();
    }

    void EndCheck()
    {
        if (i <= arr.Length - 1) 
        { 
            tmpText.text = arr[i];
            StartCoroutine(visibleText());
        }
    }



    private IEnumerator visibleText()
    {
        tmpText.ForceMeshUpdate();
        int visibleChars = tmpText.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (visibleChars + 1);
            tmpText.maxVisibleCharacters = visibleCount;

            if (visibleCount >= visibleChars)
            {
                i++;
                Invoke("EndCheck", timeBetweenWords);
                break;
            }

            counter++;
            yield return new WaitForSeconds(timeBetweenChars);
        }
    }
}
