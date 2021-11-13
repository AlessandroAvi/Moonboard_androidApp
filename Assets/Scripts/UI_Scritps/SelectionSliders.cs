using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class SelectionSliders : MonoBehaviour
{
    public Slider maxGradeSlider;
    public Slider minGradeSlider;
    public Slider minRatingSlider;

    public TextMeshProUGUI maxGradeText;
    public TextMeshProUGUI minGradeText;
    public TextMeshProUGUI minRatingText;

    public void Awake()
    {
        BoulderVar.filterSended = false;
        BoulderVar.benchmark = false; 
    }

    public void SetMaxGrade()
    {
        PrintMaxGrade(maxGradeSlider.value);
        BoulderVar.maxGrade = GetGrade(maxGradeSlider.value); 
        if(maxGradeSlider.value <= minGradeSlider.value)
        {
            minGradeSlider.value = maxGradeSlider.value;
            PrintMinGrade(minGradeSlider.value);
            BoulderVar.minGrade = GetGrade(minGradeSlider.value); 
        }
    }

    public void SetMinGrade()
    {
        PrintMinGrade(minGradeSlider.value);
        BoulderVar.minGrade = GetGrade(minGradeSlider.value); 
        if (minGradeSlider.value >= maxGradeSlider.value)
        {
            maxGradeSlider.value = minGradeSlider.value;
            PrintMaxGrade(maxGradeSlider.value);
            BoulderVar.maxGrade = GetGrade(maxGradeSlider.value); 
        }
    }

    public void SetRating()
    {
        minRatingText.SetText(minRatingSlider.value.ToString());
        BoulderVar.minRating = (int)minRatingSlider.value; 
    }

    public void SetBenchmark()
    {
        BoulderVar.benchmark = !BoulderVar.benchmark;
    }

    public void SetSended()
    {
        BoulderVar.filterSended = !BoulderVar.filterSended; 
    }

    void PrintMaxGrade(float val)
    {
        maxGradeText.SetText(GetGrade(maxGradeSlider.value));
    }
    void PrintMinGrade(float val)
    {
        minGradeText.SetText(GetGrade(minGradeSlider.value));
    }

    string GetGrade(float val)
    {
        switch (val)
        {
            case 0:
                return "All";
            case 1:
                return "6A";
            case 2:
                return "6A+";
            case 3:
                return "6B";
            case 4:
                return "6B+";
            case 5:
                return "6C";
            case 6:
                return "6C+";
            case 7:
                return "7A";
            case 8:
                return "7A+";
            case 9:
                return "7B";
            case 10:
                return "7B+";
            case 11:
                return "7C";
            case 12:
                return "8A";
            case 13:
                return "8A+";
            case 14:
                return "8B";
            case 15:
                return "8B+"; 
            default:
                return ""; 
        }
    }

    
}
