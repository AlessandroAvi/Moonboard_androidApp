using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectedBoulder : MonoBehaviour
{
    #region Circles 
    public Image g4;
    public Image h5;
    public Image j5;
    public Image c5;
    public Image b6;
    public Image e6;
    public Image g6;
    public Image i7;
    public Image j7;
    public Image d7;
    public Image c8;
    public Image e8;
    public Image h8;
    public Image g9;
    public Image i9;
    public Image k9;
    public Image e9;
    public Image a9;
    public Image b10;
    public Image g10;
    public Image h10;
    public Image i10;
    public Image f11;
    public Image d11;
    public Image b12;
    public Image e12;
    public Image h12;
    public Image j12;
    public Image h13;
    public Image j13;
    public Image f13;
    public Image c13;
    public Image a14;
    public Image e14;
    public Image g14;
    public Image i14;
    public Image k14;
    public Image i15;
    public Image g15;
    public Image d15;
    public Image b15;
    public Image c16;
    public Image e16;
    public Image h16;
    public Image j16;
    public Image k16;
    public Image g17;
    public Image a18;
    public Image d18;
    public Image i18;
    #endregion
    public Image TEST;





    // Start is called before the first frame update
    void Start()
    {
        BoulderVar.nMoves = 0;
        
        for (int i = 0; i < 20; i++)
        {
            if (BoulderVar.moves[i] == null) break;
            ActivateCircle(i);
        }
        //TEST.gameObject.SetActive(true);
        Debug.Log("Fine");
        Debug.Log(BoulderVar.moves);
    }

    void ActivateCircle(int i)
    {
        string move = BoulderVar.moves[i];
        bool start = BoulderVar.isStart[i];
        bool end = BoulderVar.isEnd[i];
        Debug.Log("Final scene" + move);

        if (move == "G4")
        {
            g4.gameObject.SetActive(true);
            if (start) g4.color = Color.green;
            if (end) g4.color = Color.red;
            BoulderVar.nMoves ++;
        }
        else if (move == "H5")
        {
            h5.gameObject.SetActive(true);
            if (start) h5.color = Color.green;
            if (end) h5.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "J5")
        {
            j5.gameObject.SetActive(true);
            if (start) j5.color = Color.green;
            if (end) j5.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "C5")
        {
            c5.gameObject.SetActive(true);
            if (start) c5.color = Color.green;
            if (end) c5.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "B6")
        {
            b6.gameObject.SetActive(true);
            if (start) b6.color = Color.green;
            if (end) b6.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "E6")
        {
            e6.gameObject.SetActive(true);
            if (start) e6.color = Color.green;
            if (end) e6.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "G6")
        {
            g6.gameObject.SetActive(true);
            if (start) g6.color = Color.green;
            if (end) g6.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "I7")
        {
            i7.gameObject.SetActive(true);
            if (start) i7.color = Color.green;
            if (end) i7.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "J7")
        {
            j7.gameObject.SetActive(true);
            if (start) j7.color = Color.green;
            if (end) j7.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "D7")
        {
            d7.gameObject.SetActive(true);
            if (start) d7.color = Color.green;
            if (end) d7.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "C8")
        {
            c8.gameObject.SetActive(true);
            if (start) c8.color = Color.green;
            if (end) c8.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "E8")
        {
            e8.gameObject.SetActive(true);
            if (start) e8.color = Color.green;
            if (end) e8.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "H8")
        {
            h8.gameObject.SetActive(true);
            if (start) h8.color = Color.green;
            if (end) h8.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "G9")
        {
            g9.gameObject.SetActive(true);
            if (start) g9.color = Color.green;
            if (end) g9.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "I9")
        {
            i9.gameObject.SetActive(true);
            if (start) i9.color = Color.green;
            if (end) i9.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "E9")
        {
            e9.gameObject.SetActive(true);
            if (start) e9.color = Color.green;
            if (end) e9.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "K9")
        {
            k9.gameObject.SetActive(true);
            if (start) k9.color = Color.green;
            if (end) k9.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "A9")
        {
            a9.gameObject.SetActive(true);
            if (start) a9.color = Color.green;
            if (end) a9.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "B10")
        {
            b10.gameObject.SetActive(true);
            if (start) b10.color = Color.green;
            if (end) b10.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "G10")
        {
            g10.gameObject.SetActive(true);
            if (start) g10.color = Color.green;
            if (end) g10.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "H10")
        {
            h10.gameObject.SetActive(true);
            if (start) h10.color = Color.green;
            if (end) h10.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "I10")
        {
            i10.gameObject.SetActive(true);
            if (start) i10.color = Color.green;
            if (end) i10.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "F11")
        {
            f11.gameObject.SetActive(true);
            if (start) f11.color = Color.green;
            if (end) f11.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "D11")
        {
            d11.gameObject.SetActive(true);
            if (start) d11.color = Color.green;
            if (end) d11.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "B12")
        {
            b12.gameObject.SetActive(true);
            if (start) b12.color = Color.green;
            if (end) b12.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "E12")
        {
            e12.gameObject.SetActive(true);
            if (start) e12.color = Color.green;
            if (end) e12.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "H12")
        {
            h12.gameObject.SetActive(true);
            if (start) h12.color = Color.green;
            if (end) h12.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "J12")
        {
            j12.gameObject.SetActive(true);
            if (start) j12.color = Color.green;
            if (end) j12.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "H13")
        {
            h13.gameObject.SetActive(true);
            if (start) h13.color = Color.green;
            if (end) h13.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "J13")
        {
            j13.gameObject.SetActive(true);
            if (start) j13.color = Color.green;
            if (end) j13.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "F13")
        {
            f13.gameObject.SetActive(true);
            if (start) f13.color = Color.green;
            if (end) f13.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "C13")
        {
            c13.gameObject.SetActive(true);
            if (start) c13.color = Color.green;
            if (end) c13.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "A14")
        {
            a14.gameObject.SetActive(true);
            if (start) a14.color = Color.green;
            if (end) a14.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "E14")
        {
            e14.gameObject.SetActive(true);
            if (start) e14.color = Color.green;
            if (end) e14.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "G14")
        {
            g14.gameObject.SetActive(true);
            if (start) g14.color = Color.green;
            if (end) g14.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "I14")
        {
            i14.gameObject.SetActive(true);
            if (start) i14.color = Color.green;
            if (end) i14.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "K14")
        {
            k14.gameObject.SetActive(true);
            if (start) k14.color = Color.green;
            if (end) k14.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "I15")
        {
            i15.gameObject.SetActive(true);
            if (start) i15.color = Color.green;
            if (end) i15.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "G15")
        {
            g15.gameObject.SetActive(true);
            if (start) g15.color = Color.green;
            if (end) g15.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "D15")
        {
            d15.gameObject.SetActive(true);
            if (start) d15.color = Color.green;
            if (end) d15.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "B15")
        {
            b15.gameObject.SetActive(true);
            if (start) b15.color = Color.green;
            if (end) b15.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "C16")
        {
            c16.gameObject.SetActive(true);
            if (start) c16.color = Color.green;
            if (end) c16.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "E16")
        {
            e16.gameObject.SetActive(true);
            if (start) e16.color = Color.green;
            if (end) e16.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "H16")
        {
            h16.gameObject.SetActive(true);
            if (start) h16.color = Color.green;
            if (end) h16.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "J16")
        {
            j16.gameObject.SetActive(true);
            if (start) j16.color = Color.green;
            if (end) j16.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "K16")
        {
            k16.gameObject.SetActive(true);
            if (start) k16.color = Color.green;
            if (end) k16.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "G17")
        {
            g17.gameObject.SetActive(true);
            if (start) g17.color = Color.green;
            if (end) g17.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "A18")
        {
            a18.gameObject.SetActive(true);
            if (start) a18.color = Color.green;
            if (end) a18.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "D18")
        {
            d18.gameObject.SetActive(true);
            if (start) d18.color = Color.green;
            if (end) d18.color = Color.red;
            BoulderVar.nMoves++;
        }
        else if (move == "I18")
        {
            i18.gameObject.SetActive(true);
            if (start) i18.color = Color.green;
            if (end) i18.color = Color.red;
            BoulderVar.nMoves++;
        }
    }
}


        
