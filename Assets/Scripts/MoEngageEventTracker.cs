using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoEngage;
using TMPro;

public class MoEngageEventTracker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textBox;

    public void TrackCustomEvent()
    {
        Properties properties = new Properties().AddBoolean("booleanAttr", true);

        MoEngageClient.TrackEvent("isWorking", properties);
    }

    public void OnBttn()
    {
        TrackCustomEvent();
        Debug.Log("Tracked UnityEvent with MoEngage");
        textBox.text = "Tracked UnityEvent with MoEngage";
    }
}
