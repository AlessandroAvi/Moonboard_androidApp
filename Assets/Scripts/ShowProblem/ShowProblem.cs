using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using SimpleJSON;
using UnityEngine.UI;

public class ShowProblem : MonoBehaviour
{
    public TextMeshProUGUI nameProblem;
    public TextMeshProUGUI gradeProblem;
    public TextMeshProUGUI idProblem;
    public GameObject sendButton;


    Color green = new Color((float)0.5, (float)1.0, (float)0.5,  1);
    Color red = new Color((float)1.0, (float)0.5, (float)0.5, 1);

    // Start is called before the first frame update
    void Awake()
    {
        nameProblem.SetText(BoulderVar.problemName.ToString());
        gradeProblem.SetText(BoulderVar.grade.ToString());
        idProblem.SetText(BoulderVar.problemId.ToString());
        Debug.Log("Check Moves");
        Debug.Log(BoulderVar.moves);
        
        if (BoulderVar.problemSended)
        {
            sendButton.transform.GetChild(2).GetComponent<TextMeshProUGUI>().SetText("SENT");
            sendButton.transform.GetChild(0).GetComponent<Image>().color = green;
        }
        else
        {
            sendButton.transform.GetChild(2).GetComponent<TextMeshProUGUI>().SetText("NOT SENT");
            sendButton.transform.GetChild(0).GetComponent<Image>().color = red;
        }
        
    }

    public void ProblemSendedToggle()
    {
        //string path = Application.dataPath + "/Scripts/ScrollingProblems/filtered_problems.json";
        string path = Application.persistentDataPath + "/filtered_problems.json";
        string json = File.ReadAllText(path);
        JSONObject list = (JSONObject)JSON.Parse(json); 


        if (BoulderVar.problemSended)
        {
            sendButton.transform.GetChild(2).GetComponent<TextMeshProUGUI>().SetText("NOT SENT");
            sendButton.transform.GetChild(0).GetComponent<Image>().color = red;
            list[BoulderVar.problemId - 1]["Sended"] = false;
            json = list.ToString();
            FileStream fileStream = new FileStream(path, FileMode.Truncate);
            using(StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(json); 
            }
        }
        if (!BoulderVar.problemSended)
        {
            sendButton.transform.GetChild(2).GetComponent<TextMeshProUGUI>().SetText("SENT");
            sendButton.transform.GetChild(0).GetComponent<Image>().color = green;
            list[BoulderVar.problemId - 1]["Sended"] = true;
            JsonUtility.FromJsonOverwrite(list.ToString(), list);
            json = list.ToString();
            FileStream fileStream = new FileStream(path, FileMode.Truncate);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(json);
            }
        }
        BoulderVar.problemSended = !BoulderVar.problemSended; 
    }

   


    
}
