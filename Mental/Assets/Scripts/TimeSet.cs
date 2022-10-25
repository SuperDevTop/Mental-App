using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSet : MonoBehaviour
{
    int hourIndex = 0;
    int minIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        MentalEngine.instance.minText.text = "00";
        MentalEngine.instance.hourText.text = "0";
        MentalEngine.instance.popularTime = MentalEngine.instance.hourText.text + ":" + MentalEngine.instance.minText.text;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpToHour()
    {
        if (hourIndex != 23)
        {
            hourIndex++;
        }
        else
        {
            hourIndex = 0;
        }

        MentalEngine.instance.hourText.text = "" + hourIndex;
        MentalEngine.instance.popularTime = MentalEngine.instance.hourText.text + ":" + MentalEngine.instance.minText.text;
        MentalEngine.instance.popularDateText.text = "" + System.DateTime.Parse(MentalEngine.instance.popularDate + " " + MentalEngine.instance.popularTime);
    }

    public void UpToMin()
    {
        if (minIndex != 59)
        {
            minIndex++;
        }
        else
        {
            minIndex = 0;
        }

        if (minIndex < 9)
        {
            MentalEngine.instance.minText.text = "0" + minIndex;
        }
        else
        {
            MentalEngine.instance.minText.text = "" + minIndex;
        }
        
        MentalEngine.instance.popularTime = MentalEngine.instance.hourText.text + ":" + MentalEngine.instance.minText.text;
        MentalEngine.instance.popularDateText.text = "" + System.DateTime.Parse(MentalEngine.instance.popularDate + " " + MentalEngine.instance.popularTime);
    }

    public void DownToHour()
    {
        if (hourIndex != 0)
        {
            hourIndex--;
        }
        else
        {
            hourIndex = 23;
        }

        MentalEngine.instance.hourText.text = "" + hourIndex;
        MentalEngine.instance.popularTime = MentalEngine.instance.hourText.text + ":" + MentalEngine.instance.minText.text;
        MentalEngine.instance.popularDateText.text = "" + System.DateTime.Parse(MentalEngine.instance.popularDate + " " + MentalEngine.instance.popularTime);
    }

    public void DownToMin()
    {
        if (minIndex != 0)
        {
            minIndex--;
        }
        else
        {
            minIndex = 59;
        }

        if (minIndex < 9)
        {
            MentalEngine.instance.minText.text = "0" + minIndex;
        }
        else
        {
            MentalEngine.instance.minText.text = "" + minIndex;
        }

        MentalEngine.instance.popularTime = MentalEngine.instance.hourText.text + ":" + MentalEngine.instance.minText.text;
        MentalEngine.instance.popularDateText.text = "" + System.DateTime.Parse(MentalEngine.instance.popularDate + " " + MentalEngine.instance.popularTime);
    }
}
