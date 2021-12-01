using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TechTweaking.Bluetooth;


public class BluetoothManager : MonoBehaviour
{

    private BluetoothDevice device;
    public Text statusText;


    public void connect()
    {
        //statusText.text = "Status : ...";
        device.connect();
    }


    void Awake()
    {
        BluetoothAdapter.enableBluetooth();//Force Enabling Bluetooth

        device = new BluetoothDevice();

        device.MacAddress = "00:20:12:08:E1:7D";
    }

    public void SendBluetooth()
    {

        //connect();

        string msg_to_send;
        char[] char_ary = new char[600];

        // Fill char with spaces
        for(int k=0; k<600; k++)
        {
            char_ary[k] = ' ';
        }

        // Fill with the name
        char_ary[0] = (char)((int)(BoulderVar.problemName.Length / 10));
        char_ary[1] = (char)((int)(BoulderVar.problemName.Length % 10));
        for (int k=0; k< BoulderVar.problemName.Length; k++)
        {
            char_ary[k+2] = BoulderVar.problemName[k];
        }


        // Fill with the grade
        for(int k=0; k< BoulderVar.grade.Length; k++)
        {
            char_ary[k + 100] = BoulderVar.grade[k];
        }


        // Fill with the number of moves
        if (BoulderVar.nMoves <= 9)
        {
            char_ary[200] = (char)((int)(BoulderVar.nMoves / 10));
            char_ary[201] = (char)((int)(BoulderVar.nMoves % 10));
        }


        // Fill with holds letters
        for(int k=0; k<BoulderVar.nMoves; k++)
        {
            char_ary[300+k*2] = BoulderVar.moves[k][0];
            if (k != BoulderVar.nMoves-1)
            {
                char_ary[301 + k * 2] = ',';
            }
        }


        // Fill with holds numbers
        int i = 0;
        for(int k=0; k<BoulderVar.nMoves; k++)
        {
            if (BoulderVar.moves[k].Length == 3)
            {
                char_ary[400+i] = BoulderVar.moves[k][1];
                char_ary[401+i] = BoulderVar.moves[k][2];
                if (k != BoulderVar.nMoves-1)
                {
                    char_ary[402 + i] = ',';
                }
                i += 3;
            }
            else if(BoulderVar.moves[k].Length == 2)
            {
                char_ary[400+i] = BoulderVar.moves[k][1];
                if (k != BoulderVar.nMoves - 1)
                {
                    char_ary[401 + i] = ',';
                }
                i += 2;
            }
        }


        // Fill with holds types
        char hold_type;
        for (int k = 0; k < BoulderVar.nMoves; k++)
        {
            if (BoulderVar.isStart[k] == true)
            {
                hold_type = 's';
            }else if (BoulderVar.isEnd[k] == true)
            {
                hold_type = 'e';
            }else
            {
                hold_type = 'd';
            }
            char_ary[500+k*2] = hold_type;
            if (k != BoulderVar.nMoves-1)
            {
                char_ary[501 + k * 2] = ',';
            }
        }

        // Send the string throught bluetooth
        msg_to_send = new string(char_ary);
        SerialManagerScript.SendInfo(msg_to_send);
        
        /*
        if (device != null)
        {
            device.send(System.Text.Encoding.ASCII.GetBytes(msg_to_send));
        }
        */
        Debug.Log("SENT" + BoulderVar.problemName);



    }




    public void SendDiscoModeBluetooth()
    {

        string msg_to_send;
        char[] char_ary = new char[600];

        // Fill char with spaces
        for (int k = 0; k < 600; k++)
        {
            char_ary[k] = ' ';
        }

        char_ary[0] = 'D';
        char_ary[1] = 'I';
        char_ary[2] = 'S';
        char_ary[3] = 'C';
        char_ary[4] = 'O';

        msg_to_send = new string(char_ary);

        SerialManagerScript.SendInfo(msg_to_send);
        Debug.Log("DISCO MODE SENT");

    }



}
