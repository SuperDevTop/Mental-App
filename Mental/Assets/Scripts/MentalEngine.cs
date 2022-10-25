using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Assertions;
using UnityEngine.Playables;

#if UNITY_ANDROID

using Unity.Notifications.Android;

#endif

#if UNITY_IOS

using Unity.Notifications.iOS;

#endif

public class MentalEngine : MonoBehaviour
{
    public static MentalEngine instance;
    public GameObject mainCanvas;
    public GameObject[] pages;
    public GameObject[] moodElements;
    public Sprite[] moods;
    public Image alertImage;
    public Image mood;
    public Toggle[] toggles;
    public Text[] popularDates;
    public Text popularMoodDate;
    public Text moodText;
    public Text hourText;
    public Text minText;
    public Text popularDateText;
    public Text popularDateText1;
    public Text todayDate;
    public InputField[] answerInputs;
    public bool isSelectedDate;
    public string popularYear;
    public string popularMonth;
    public string popularDay;
    public string popularDate;
    public string popularTime;
    public int moodIndex;

    void Awake()
    {
        instance = this;
        Application.runInBackground = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        //string a = "2022September24";
        //print(DateTime.Parse(a).ToString("yyyy-MM-dd"));
        //print(PlayerPrefs.GetString("kkk"));
        mainCanvas.transform.localScale = new Vector3(Screen.width / 1080f, Screen.height / 2340f, 1f);

        #if UNITY_ANDROID

        var channel = new AndroidNotificationChannel()
                {
                    Id = "Alarm",
                    Name = "Session Notification",
                    Importance = Importance.Default,
                    Description = "Session Notification",
                };
                AndroidNotificationCenter.RegisterNotificationChannel(channel);

        #endif        
    }

    // Update is called once per frame
    void Update()
    {
        mainCanvas.transform.localScale = new Vector3(Screen.width / 1080f, Screen.height / 2340f, 1f);
    }

    public void SceduleClick()
    {                
        if (isSelectedDate)
        {            
            print(System.DateTime.Parse(popularDate + " " + popularTime));
            isSelectedDate = false;
            pages[1].SetActive(false);
            pages[2].SetActive(true);

            if(PlayerPrefs.GetString(popularDate + popularTime + "Toggle0") != "")
            {
                if (PlayerPrefs.GetString(popularDate + popularTime + "Toggle0") == "true")
                {
                    toggles[0].isOn = true;
                }
                else if (PlayerPrefs.GetString(popularDate + popularTime + "Toggle0") == "false")
                {
                    toggles[0].isOn = false;
                }

                if (PlayerPrefs.GetString(popularDate + popularTime + "Toggle1") == "true")
                {
                    toggles[1].isOn = true;
                }
                else if (PlayerPrefs.GetString(popularDate + popularTime + "Toggle1") == "false")
                {
                    toggles[1].isOn = false;
                }

                if (PlayerPrefs.GetString(popularDate + popularTime + "Toggle2") == "true")
                {
                    toggles[2].isOn = true;
                }
                else if (PlayerPrefs.GetString(popularDate + popularTime + "Toggle2") == "false")
                {
                    toggles[2].isOn = false;
                }
            }
        }
    }

    public void SetNotification()
    {
#if UNITY_ANDROID

                var id = AndroidNotificationCenter.SendNotification(new AndroidNotification(), "");

                        if (toggles[0].isOn)
                        {
                            PlayerPrefs.SetString(popularDate + popularTime + "Toggle0", "true");

                            var notification = new AndroidNotification();
                            notification.Title = "Notification";
                            notification.Text = "Your therapy session is in one week on" + " " + popularDate + " at " + popularTime;
                            notification.FireTime = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7);            

                            id = AndroidNotificationCenter.SendNotification(notification, "Alarm");
                        }
                        else
                        {
                            PlayerPrefs.SetString(popularDate + popularTime + "Toggle0", "false");
                            AndroidNotificationCenter.CancelNotification(id);
                        }

                        if (toggles[1].isOn)
                        {
                            PlayerPrefs.SetString(popularDate + popularTime + "Toggle1", "true");

                            var notification = new AndroidNotification();
                            notification.Title = "Notification";
                            notification.Text = "Your therapy session is in one day on" + " " + popularDate + " at " + popularTime;
                            notification.FireTime = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-1);

                            AndroidNotificationCenter.SendNotification(notification, "Alarm");
                        }
                        else
                        {
                            PlayerPrefs.SetString(popularDate + popularTime + "Toggle1", "false");
                            AndroidNotificationCenter.CancelNotification(id);
                        }

                        if (toggles[2].isOn)
                        {
                            PlayerPrefs.SetString(popularDate + popularTime + "Toggle2", "true");

                            var notification = new AndroidNotification();
                            notification.Title = "Notification";
                            notification.Text = "Your therapy session is in one hour on" + " " + popularDate + " at " + popularTime;
                            notification.FireTime = System.DateTime.Parse(popularDate + " " + popularTime).AddHours(-1);

                            AndroidNotificationCenter.SendNotification(notification, "Alarm");
                        }
                        else
                        {
                            PlayerPrefs.SetString(popularDate + popularTime + "Toggle2", "false");
                            AndroidNotificationCenter.CancelNotification(id);
                        }

                        if (toggles[0].isOn || toggles[1].isOn || toggles[2].isOn)
                        {
                            alertImage.gameObject.SetActive(true);
                            StartCoroutine(DelayAlert());
                        }

#endif

#if UNITY_IOS
        var calendarTrigger = new iOSNotificationCalendarTrigger()
        {
            Year = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Year,
            Month = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Month,
            Day = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Day,
            Hour = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Hour,
            Minute = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Minute,
            Repeats = false
        };

        var notification = new iOSNotification()
        {
            // You can specify a custom identifier which can be used to manage the notification later.
            // If you don't provide one, a unique string will be generated automatically.
            Identifier = "_notification_01",
            Title = "Notification",
            Body = "Your therapy session is in one week on" + " " + popularDate + " at " + popularTime,
            Subtitle = "",
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
            CategoryIdentifier = "category_a",
            ThreadIdentifier = "thread1",
            Trigger = calendarTrigger,
        };

        if (toggles[0].isOn)
        {
            PlayerPrefs.SetString(popularDate + popularTime + "Toggle0", "true");

            calendarTrigger = new iOSNotificationCalendarTrigger()
            {
                Year = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Year,
                Month = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Month,
                Day = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Day,
                Hour = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Hour,
                Minute = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-7).Minute,
                Repeats = false
            };

            notification = new iOSNotification()
            {
                // You can specify a custom identifier which can be used to manage the notification later.
                // If you don't provide one, a unique string will be generated automatically.
                Identifier = "_notification_01",
                Title = "Notification",
                Body = "Your therapy session is in one week on" + " " + popularDate + " at " + popularTime,
                Subtitle = "",
                ShowInForeground = true,
                ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
                CategoryIdentifier = "category_a",
                ThreadIdentifier = "thread1",
                Trigger = calendarTrigger,
            };

            iOSNotificationCenter.ScheduleNotification(notification);           
        }
        else
        {
            PlayerPrefs.SetString(popularDate + popularTime + "Toggle0", "false");
            iOSNotificationCenter.RemoveScheduledNotification(notification.Identifier);
        }

        if (toggles[1].isOn)
        {
            PlayerPrefs.SetString(popularDate + popularTime + "Toggle1", "true");

            calendarTrigger = new iOSNotificationCalendarTrigger()
            {
                Year = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-1).Year,
                Month = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-1).Month,
                Day = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-1).Day,
                Hour = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-1).Hour,
                Minute = System.DateTime.Parse(popularDate + " " + popularTime).AddDays(-1).Minute,
                Repeats = false
            };

            notification = new iOSNotification()
            {
                // You can specify a custom identifier which can be used to manage the notification later.
                // If you don't provide one, a unique string will be generated automatically.
                Identifier = "_notification_01",
                Title = "Notification",
                Body = "Your therapy session is in one day on" + " " + popularDate + " at " + popularTime,
                Subtitle = "",
                ShowInForeground = true,
                ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
                CategoryIdentifier = "category_a",
                ThreadIdentifier = "thread1",
                Trigger = calendarTrigger,
            };

            iOSNotificationCenter.ScheduleNotification(notification);            
        }
        else
        {
            PlayerPrefs.SetString(popularDate + popularTime + "Toggle1", "false");
            iOSNotificationCenter.RemoveScheduledNotification(notification.Identifier);
        }

        if (toggles[2].isOn)
        {
            PlayerPrefs.SetString(popularDate + popularTime + "Toggle2", "true");

            calendarTrigger = new iOSNotificationCalendarTrigger()
            {
                Year = System.DateTime.Parse(popularDate + " " + popularTime).AddHours(-1).Year,
                Month = System.DateTime.Parse(popularDate + " " + popularTime).AddHours(-1).Month,
                Day = System.DateTime.Parse(popularDate + " " + popularTime).AddHours(-1).Day,
                Hour = System.DateTime.Parse(popularDate + " " + popularTime).AddHours(-1).Hour,
                Minute = System.DateTime.Parse(popularDate + " " + popularTime).AddHours(-1).Minute,
                Repeats = false
            };

            notification = new iOSNotification()
            {
                // You can specify a custom identifier which can be used to manage the notification later.
                // If you don't provide one, a unique string will be generated automatically.
                Identifier = "_notification_01",
                Title = "Notification",
                Body = "Your therapy session is in one day on" + " " + popularDate + " at " + popularTime,
                Subtitle = "",
                ShowInForeground = true,
                ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
                CategoryIdentifier = "category_a",
                ThreadIdentifier = "thread1",
                Trigger = calendarTrigger,
            };

            iOSNotificationCenter.ScheduleNotification(notification);            
        }
        else
        {
            PlayerPrefs.SetString(popularDate + popularTime + "Toggle2", "false");
            iOSNotificationCenter.RemoveScheduledNotification(notification.Identifier);
        }

        if (toggles[0].isOn || toggles[1].isOn || toggles[2].isOn)
        {
            alertImage.gameObject.SetActive(true);
            StartCoroutine(DelayAlert());
        }
#endif

    }

    IEnumerator DelayAlert()
    {
        yield return new WaitForSeconds(2f);

        alertImage.gameObject.SetActive(false);
    }

    public void GoToSessionLog()
    {
        for (int i = 0; i < popularDates.Length; i++)
        {
            popularDates[i].text = popularMonth + " " + popularDay + ", " + popularYear + " " + popularTime;
        }

        answerInputs[0].text = PlayerPrefs.GetString(popularDate + popularTime + "answer0");
        answerInputs[1].text = PlayerPrefs.GetString(popularDate + popularTime + "answer1");
        answerInputs[2].text = PlayerPrefs.GetString(popularDate + popularTime + "answer2");
        answerInputs[3].text = PlayerPrefs.GetString(popularDate + popularTime + "answer3");
        answerInputs[4].text = PlayerPrefs.GetString(popularDate + popularTime + "answer4");
        answerInputs[5].text = PlayerPrefs.GetString(popularDate + popularTime + "answer5");
    }

    public void SaveBeforeSessionLog()
    {
        PlayerPrefs.SetString(popularDate + popularTime + "answer0", answerInputs[0].text);
        PlayerPrefs.SetString(popularDate + popularTime + "answer1", answerInputs[1].text);
    }

    public void SaveDuringSessionLog()
    {
        PlayerPrefs.SetString(popularDate + popularTime + "answer2", answerInputs[2].text);
        PlayerPrefs.SetString(popularDate + popularTime + "answer3", answerInputs[3].text);
    }

    public void SaveAfterSessionLog()
    {
        PlayerPrefs.SetString(popularDate + popularTime + "answer4", answerInputs[4].text);
        PlayerPrefs.SetString(popularDate + popularTime + "answer5", answerInputs[5].text);
    }

    public void GoToMoodTracker()
    {
        mood.gameObject.SetActive(false);
    }

    public void GoToMoodList()
    {
        if (isSelectedDate)
        {
            popularMoodDate.text = popularMonth + " " + popularDay + ", " + popularYear;
            isSelectedDate = false;
            pages[7].SetActive(false);
            pages[8].SetActive(true);
        }            
    }

    public void MoodReportClick()
    {
        moodIndex = 0;

        for (int i = 0; i < moodElements.Length; i++)
        {
            moodElements[i].SetActive(false);
        }

        for (int i = 0; i < 365; i++)
        {
            print(System.DateTime.Now.AddDays(i * (-1)).Year + "-" + System.DateTime.Now.AddDays(i * (-1)).Month + "-" + System.DateTime.Now.AddDays(i * (-1)).Day + "mood");

            if (PlayerPrefs.GetString("" + System.DateTime.Now.AddDays(i * (-1)).Year + "-" + System.DateTime.Now.AddDays(i * (-1)).Month + "-" + System.DateTime.Now.AddDays(i * (-1)).Day +"mood") != "")
            {                
                moodElements[moodIndex].SetActive(true);
                moodElements[moodIndex].GetComponentInChildren<Text>().text = System.DateTime.Now.AddDays(i * (-1)).ToString("MM/dd/yyyy");

                switch (PlayerPrefs.GetString("" + System.DateTime.Now.AddDays(i * (-1)).Year + "-" + System.DateTime.Now.AddDays(i * (-1)).Month + "-" + System.DateTime.Now.AddDays(i * (-1)).Day + "mood"))
                {
                    case "happy":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[0];
                            break;
                        }
                    case "goofy":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[1];
                            break;
                        }
                    case "meh":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[2];
                            break;
                        }
                    case "frustrated":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[3];
                            break;
                        }
                    case "sad":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[4];
                            break;
                        }
                    case "scared":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[5];
                            break;
                        }
                    case "sleepy":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[6];
                            break;
                        }
                    case "sick":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[7];
                            break;
                        }
                    case "tense":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[8];
                            break;
                        }
                    case "surprised":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[9];
                            break;
                        }
                    case "embarrassed":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[10];
                            break;
                        }
                    case "angry":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[11];
                            break;
                        }
                    case "loved":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[12];
                            break;
                        }
                    case "anxious":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[13];
                            break;
                        }
                    case "devastated":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[14];
                            break;
                        }
                    case "depressed":
                        {
                            moodElements[moodIndex].GetComponentInChildren<Image>().sprite = MentalEngine.instance.moods[15];
                            break;
                        }
                    default:
                        {                           
                            break;
                        }
                }
                
                moodIndex++;

            }
        }
    }

    public void MoodCellClick()
    {
        switch (EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text)
        {
            case "happy":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "happy");
                    break;
                }
            case "goofy":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "goofy");
                    break;
                }
            case "meh":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "meh");
                    break;
                }
            case "frustrated":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "frustrated");
                    break;
                }
            case "sad":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "sad");
                    break;
                }
            case "scared":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "scared");
                    break;
                }
            case "sleepy":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "sleepy");
                    break;
                }
            case "sick":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "sick");
                    break;
                }
            case "tense":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "tense");
                    break;
                }
            case "surprised":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "surprised");
                    break;
                }
            case "embarrassed":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "embarrassed");
                    break;
                }
            case "angry":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "angry");
                    break;
                }
            case "loved":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "loved");
                    break;
                }
            case "anxious":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "anxious");
                    break;
                }
            case "devastated":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "devastated");
                    break;
                }
            case "depressed":
                {
                    PlayerPrefs.SetString(popularDate + "mood", "depressed");
                    break;
                }
        }
    }

    public void ResetCalendar()
    {
        DrawCalendar.instance.GetDate(DateTime.Now);
    }
}
