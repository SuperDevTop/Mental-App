using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CalendarCellClick : MonoBehaviour
{
    public Text selectedYear;
    public Text selectedMonth;

    // Start is called before the first frame update
    void Start()
    {
        MentalEngine.instance.todayDate.text = "" + DateTime.Now.ToString("yyyy-MM-dd");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CellClick()
    {
        if (this.gameObject.GetComponentInChildren<Text>().text != "")
        {
            MentalEngine.instance.isSelectedDate = true;
            MentalEngine.instance.popularYear = selectedYear.text;
            MentalEngine.instance.popularMonth = selectedMonth.text;
            MentalEngine.instance.popularDay = this.gameObject.GetComponentInChildren<Text>().text;
            MentalEngine.instance.popularDate = MentalEngine.instance.popularYear + "-" + DateTime.ParseExact(MentalEngine.instance.popularMonth, "MMMM", CultureInfo.CurrentCulture).Month + "-"+ MentalEngine.instance.popularDay;

            if (MentalEngine.instance.pages[1].active == false)
            {
                MentalEngine.instance.popularDateText1.text = "" + System.DateTime.Parse(MentalEngine.instance.popularDate).ToString("yyyy-MM-dd");

                switch (PlayerPrefs.GetString(MentalEngine.instance.popularDate + "mood"))
                {
                    case "happy":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "happy";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[0];
                            break;
                        }
                    case "goofy":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "goofy";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[1];
                            break;
                        }
                    case "meh":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "meh";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[2];
                            break;
                        }
                    case "frustrated":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "frustrated";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[3];
                            break;
                        }
                    case "sad":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "sad";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[4];
                            break;
                        }
                    case "scared":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "scared";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[5];
                            break;
                        }
                    case "sleepy":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "sleepy";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[6];
                            break;
                        }
                    case "sick":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "sick";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[7];
                            break;
                        }
                    case "tense":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "tense";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[8];
                            break;
                        }
                    case "surprised":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "surprised";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[9];
                            break;
                        }
                    case "embarrassed":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "embarrassed";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[10];
                            break;
                        }
                    case "angry":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "angry";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[11];
                            break;
                        }
                    case "loved":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "loved";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[12];
                            break;
                        }
                    case "anxious":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "anxious";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[13];
                            break;
                        }
                    case "devastated":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "devastated";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[14];
                            break;
                        }
                    case "depressed":
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(true);
                            MentalEngine.instance.moodText.text = "depressed";
                            MentalEngine.instance.mood.gameObject.SetActive(true);
                            MentalEngine.instance.mood.sprite = MentalEngine.instance.moods[15];
                            break;
                        }
                    default:
                        {
                            MentalEngine.instance.moodText.gameObject.SetActive(false);
                            MentalEngine.instance.moodText.text = "";
                            MentalEngine.instance.mood.gameObject.SetActive(false);
                            break;
                        }
                }
            }
            else
            {
                MentalEngine.instance.popularDateText.text = "" + System.DateTime.Parse(MentalEngine.instance.popularDate + " " + MentalEngine.instance.popularTime);
            }
        }        
    }   
}
