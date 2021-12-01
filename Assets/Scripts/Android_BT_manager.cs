using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TechTweaking.Bluetooth;

public class Android_BT_manager : MonoBehaviour
{

    private BluetoothDevice device;
    public Text statusText;


    void Awake()
    {
        BluetoothAdapter.enableBluetooth();//Force Enabling Bluetooth

        device = new BluetoothDevice();

        device.MacAddress = "00:20:12:08:E1:7D";
    }





    public void connect()
    {
        //statusText.text = "Status : ...";
        device.connect();
    }






    public void disconnect()
    {
        device.close();
    }






    public void sendHello()
    {
        if (device != null)
        {
            device.send(System.Text.Encoding.ASCII.GetBytes("Hello\n"));
        }
    }

}
