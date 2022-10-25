using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DrawCalendar : MonoBehaviour
{
    public static DrawCalendar instance;
    public GameObject[] cells;
    public Text selectedMonth;
    public Text selectedYear;       
    int index = 0;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        GetDate(DateTime.Now);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetDate(DateTime dateTime)
    {
        for (int i = 0; i < cells.Length; i++)
        {
            cells[i].GetComponentInChildren<Text>().text = "";
        }

        selectedMonth.text = "" + dateTime.ToString("MMMM");
        selectedYear.text = "" + dateTime.Year.ToString();
        int dateNumbers = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
        int firstCellNumber = 0;
        DateTime dt = new DateTime(dateTime.Year, dateTime.Month, 1);

        switch (dt.DayOfWeek)
        {
            case DayOfWeek.Sunday:
                {
                    firstCellNumber = 0;
                    break;
                }
            case DayOfWeek.Monday:
                {
                    firstCellNumber = 1;
                    break;
                }
            case DayOfWeek.Tuesday:
                {
                    firstCellNumber = 2;
                    break;
                }
            case DayOfWeek.Wednesday:
                {
                    firstCellNumber = 3;
                    break;
                }
            case DayOfWeek.Thursday:
                {
                    firstCellNumber = 4;
                    break;
                }
            case DayOfWeek.Friday:
                {
                    firstCellNumber = 5;
                    break;
                }
            case DayOfWeek.Saturday:
                {
                    firstCellNumber = 6;
                    break;
                }
        }

        for (int i = 0; i < dateNumbers; i++)
        {
            cells[i + firstCellNumber].GetComponentInChildren<Text>().text = "" + (i + 1);
        }
    }

    public void PrevDate()
    {
        index--;
        GetDate(DateTime.Now.AddMonths(index));
    }

    public void NextDate()
    {
        index++;
        GetDate(DateTime.Now.AddMonths(index));
    }      
}
