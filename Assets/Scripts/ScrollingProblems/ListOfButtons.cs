using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using SimpleJSON;
using UnityEngine.SceneManagement;

public static class ButtonExtensions
{
    public static void AddEventListener<T1, T2> (this Button button, T1 param1, T2 param2, Action<T1,T2> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param1,param2);
        });
    }
}

public class ListOfButtons : MonoBehaviour
{

    public TextMeshProUGUI nOfFilteredProblemText;

    // https://www.youtube.com/watch?v=Lq170ztDAPo

    void Awake()
    {
        //https://stackoverflow.com/questions/35926252/android-read-an-external-file-not-created-by-app

        // ----- UNITY GAME 
        string path = Application.dataPath + "/Scripts/ScrollingProblems/filtered_problems.json";
        // ----- ANDROID BUILD 
        //string path = Application.persistentDataPath + "/filtered_problems.json";

        Debug.Log(path);
        string json = File.ReadAllText(path);
        JSONObject list = (JSONObject)JSON.Parse(json);
        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject g;

        int nOfFilteredProblems = 0;


        for (int i = 0; i < 807; i++)
        {
            
            if (IsProblemOk(list[i]))
            {
                nOfFilteredProblems++; 

                g = Instantiate(buttonTemplate, transform);
                g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().SetText(list[(i+1).ToString()]["Name"]);
                g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().SetText(list[(i+1).ToString()]["Grade"]);
                g.transform.GetChild(2).GetComponent<TextMeshProUGUI>().SetText(list[(i+1).ToString()]["Rating"].ToString());
                //g.transform.GetChild(3).GetComponent<Text>().text =list[(i+1).ToString()]["Name"];
                g.transform.GetChild(4).gameObject.SetActive(list[(i+1).ToString()]["Sended"]);

                g.GetComponent<Button>().AddEventListener(list[i], i, ItemClicked);
                Debug.Log((i).ToString() + list[i.ToString()]["Name"]);
            }
        }

        nOfFilteredProblemText.GetComponent<TextMeshProUGUI>().SetText("N. OF PROBLEMS : " + nOfFilteredProblems);
        Destroy(buttonTemplate);

    }

    bool IsProblemOk(SimpleJSON.JSONNode sampleProblem)
    {
        // check grade 
        int minGrade = GradeStringToInt(BoulderVar.minGrade);
        int maxGrade = GradeStringToInt(BoulderVar.maxGrade);
        int sampleGrade = GradeStringToInt(sampleProblem["Grade"]);
        if (BoulderVar.minGrade == "All") minGrade = 0;
        if (BoulderVar.maxGrade == "All") maxGrade = 16;
        if (sampleGrade > maxGrade || sampleGrade < minGrade) return false;

        // check only if filtered = only sended 
        if (BoulderVar.filterSended && !sampleProblem["Sended"]) return false; 

        // check rating
        if ((int)sampleProblem["Rating"] < (int)BoulderVar.minRating) return false;

        // check benchmark
        if (BoulderVar.benchmark)
        {
            if (sampleProblem["IsBenchmark"] != BoulderVar.benchmark) return false; 
        }
        return true; 
    }

    void ItemClicked(SimpleJSON.JSONNode sampleProblem, int i)
    {
        Debug.Log("Problem cliked"); 
        BoulderVar.problemName = sampleProblem["Name"];
        BoulderVar.problemId = i+1;
        Debug.Log(BoulderVar.problemName +" : " +  BoulderVar.problemId);
        BoulderVar.grade = sampleProblem["Grade"];
        BoulderVar.problemSended = sampleProblem["Sended"];

        // Defining the set of moves 
        for(int j=0; j<20; j++)
        {
             
            string move = sampleProblem["Moves"].AsArray[j][1];
            Debug.Log(move); 
            bool isStart = sampleProblem["Moves"].AsArray[j][2];
            bool isEnd = sampleProblem["Moves"].AsArray[j][3]; 
            //Debug.Log(move + ": Start(" + isStart + "), End("+ isEnd +")");
            BoulderVar.nMoves++; 
            BoulderVar.moves[j] = move;
            BoulderVar.isStart[j] = isStart; 
            BoulderVar.isEnd[j] = isEnd;
            if (sampleProblem["Moves"][j] == null) break;
        }
        Debug.Log("finished moves");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    int GradeStringToInt(string grade)
    {
        if (grade == "6A")          return 1;
        else if (grade == "6A+")    return 2;
        else if (grade == "6B")     return 3;
        else if (grade == "6B+")    return 4;
        else if (grade == "6C")     return 5;
        else if (grade == "6C+")    return 6;
        else if (grade == "7A")     return 7;
        else if (grade == "7A+")    return 8;
        else if (grade == "7B")     return 9;
        else if (grade == "7B+")    return 10;
        else if (grade == "7C")     return 11;
        else if (grade == "7C+")    return 12;
        else if (grade == "8A")     return 13;
        else if (grade == "8A+")    return 14;
        else if (grade == "8B")     return 15;
        else if (grade == "8B+")    return 16;
        else return 0; 
    }
   
}
