using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderVar : MonoBehaviour
{

    [SerializeField] public static string problemName;
    [SerializeField] public static int problemId;
    [SerializeField] public static string minGrade = "All";
    [SerializeField] public static string maxGrade = "All";
    [SerializeField] public static string grade;
    [SerializeField] public static string[] moves = new string[20];
    [SerializeField] public static bool[] isStart = new bool[20];
    [SerializeField] public static bool[] isEnd = new bool[20];
    [SerializeField] public static bool filterSended = false;
    [SerializeField] public static bool problemSended = false;
    [SerializeField] public static int nMoves = 0;
    [SerializeField] public static int minRating = 0;
    [SerializeField] public static bool benchmark = false;

    [SerializeField] public static float scrollBarValue = 1; 

    public static void PrintBoulderVar()
    {
        Debug.Log("-----------------------");
        Debug.Log("Min Grade : " + minGrade);
        Debug.Log("Max Grade : " + maxGrade);
        Debug.Log("Min Rating: " + minRating.ToString());
        Debug.Log("Benchmark : " + benchmark.ToString());
    }

}
