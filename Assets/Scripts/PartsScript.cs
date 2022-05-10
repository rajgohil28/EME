using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PartsScript : MonoBehaviour
{
    public GameObject[] parts;
    public GameObject IncreaseButton;
    public GameObject DecreaseButton;

    public int partindex = 0;
    private int TotalParts;

    [Header("Texts")]
    public TMP_Text PartTitle;
    public TMP_Text PartDescreption;
    // Start is called before the first frame update
    void Start()
    {
        TotalParts = parts.Length;
        parts[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(partindex == ((TotalParts - 1)))
        {
            IncreaseButton.SetActive(false);
        }
        else if(partindex == 0)
        {
            DecreaseButton.SetActive(false);
        }
        else
        {
            IncreaseButton.SetActive(true);
            DecreaseButton.SetActive(true);
        }
        if(partindex == 0)
        {
            PartTitle.text = "Brakes";
        }
        else if (partindex == 1)
        {
            PartTitle.text = "Recoil";
        }
        else if(partindex == 2)
        {
            PartTitle.text = "Bolt";
        }
    }
    public void IncreasePart()
    {
        if(partindex < (TotalParts -1))
        {
            partindex++;
            DeactivateAllParts();
            parts[partindex].SetActive(true);
            IncreaseButton.SetActive(true);
        }
    }
    public void DecreasePart()
    {
        if(partindex > 0)
        {
            partindex--;
            DeactivateAllParts();
            parts[partindex].SetActive(true);
            DecreaseButton.SetActive(true);
        }
    }
    public void DeactivateAllParts()
    {
        foreach (GameObject part in parts)
        {
            part.SetActive(false);
        }
    }
}
