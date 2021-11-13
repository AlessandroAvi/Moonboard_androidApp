using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BluetoothManager : MonoBehaviour
{

    public void SendBluetooth()
    {

        string to_send;
        int size_digit1;
        int size_digit2;


        // Send name trought bluetooth
        to_send = BoulderVar.problemName.PadLeft(47);
        size_digit1 = BoulderVar.problemName.Length / 10;
        size_digit2 = BoulderVar.problemName.Length & 10;
        SerialManagerScript.SendInfo('1' + size_digit1.ToString() + size_digit2.ToString() + to_send);
        Debug.Log("Name: " + BoulderVar.problemName);


        // Send grade through bluetooth
        to_send = BoulderVar.grade.PadLeft(47);
        size_digit1 = BoulderVar.grade.Length / 10;
        size_digit2 = BoulderVar.grade.Length & 10;
        SerialManagerScript.SendInfo('2' + size_digit1.ToString() + size_digit2.ToString() + to_send);
        Debug.Log("Grade: " + BoulderVar.grade);

        // Send the number of moves
        to_send = BoulderVar.nMoves.ToString().PadLeft(49);
        SerialManagerScript.SendInfo('3' + to_send);
        Debug.Log("N moves: " + BoulderVar.nMoves.ToString());

        // Send LETTER moves trought bluetooth
        SerialManagerScript.SendInfo("4");
        for (int i=0; i<BoulderVar.nMoves; i++){
            char currentMove = BoulderVar.moves[i][0];
            SerialManagerScript.SendInfo(currentMove + "");
            Debug.Log("Letter holds: " + BoulderVar.moves[i][0]);
            if (i!= BoulderVar.nMoves-1)
            {
                SerialManagerScript.SendInfo(",");
            }
        }
        to_send = " ".PadLeft(50- BoulderVar.nMoves-1);
        SerialManagerScript.SendInfo(to_send);
        

        // Send NUMBER moves trought bluetooth
        SerialManagerScript.SendInfo("5");
        for (int i = 0; i < BoulderVar.nMoves; i++)
        {
            char currentMove1;
            char currentMove2;

            if (BoulderVar.moves[i].Length == 3)
            {
                currentMove1 = BoulderVar.moves[i][1];
                currentMove2 = BoulderVar.moves[i][2];
                SerialManagerScript.SendInfo(currentMove1 + "");
                SerialManagerScript.SendInfo(currentMove2 + "");
                Debug.Log("Letter numbers: " + currentMove1 + currentMove2);
            }
            else if (BoulderVar.moves[i].Length == 2)
            {
                currentMove1 = BoulderVar.moves[i][1];
                SerialManagerScript.SendInfo(currentMove1 + "");
                Debug.Log("Letter numbers: " + currentMove1);
            }

            if (i != BoulderVar.nMoves-1){
                SerialManagerScript.SendInfo(",");
            }
        }
        to_send = " ".PadLeft(50 - BoulderVar.nMoves - 1);
        SerialManagerScript.SendInfo(to_send);


        // Send array of start/middle/top
        SerialManagerScript.SendInfo("6");
        for (int i = 0; i < BoulderVar.nMoves; i ++){
            if (BoulderVar.isStart[i] == true){
                SerialManagerScript.SendInfo("s");
                Debug.Log("s");
            }
            else if (BoulderVar.isEnd[i] == true){
                SerialManagerScript.SendInfo("e");
                Debug.Log("e");
            }
            else{
                SerialManagerScript.SendInfo("d");
                Debug.Log("d");
            }

            if (i != BoulderVar.nMoves-1){
                SerialManagerScript.SendInfo(",");
                Debug.Log(",");
            }
        }
        to_send = " ".PadLeft(50 - BoulderVar.nMoves - 1);
        SerialManagerScript.SendInfo(to_send);
        Debug.Log("Hold type sent");

    }



}
