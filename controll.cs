using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll : MonoBehaviour
{
    public static string correctCode = "5785";
    public static string playerCode = "";

    public static int totalDigits = 0;
    // Start is called once at the beggining
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (totalDigits == 4)
        {
            if (playerCode == correctCode)
            {
                Debug.Log("Correct");
            }
            else
            {
                playerCode = "";
                totalDigits = 0;
                Debug.Log("Wrong Password");
            }
        }

    }
    private void OnMouseUp()
    {
        playerCode += gameObject.name;
        totalDigits += 1;
        StartCoroutine(waittochange());
    }

    private void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    IEnumerator waittochange()
    {
        yield return new WaitForSeconds(1);
    }
}

