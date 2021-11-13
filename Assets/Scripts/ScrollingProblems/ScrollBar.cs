using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScrollBar : MonoBehaviour
{
    public Scrollbar bar;
    
    // Start is called before the first frame update
    void Start()
    {
        bar.value = BoulderVar.scrollBarValue;
        bar.onValueChanged.AddListener((float val) => ScrollbarCallBack(val));
    }

    void Update()
    {
        
    }
   
    void ScrollbarCallBack(float value)
    {
        BoulderVar.scrollBarValue = value;
    }
}
