using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoEngage;
using TMPro;
using UnityEngine.UIElements;

public class UserLogger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI statusBox;
    [SerializeField] TMP_InputField userID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void userLogin()
    {
        MoEngageClient.SetUniqueId(userID.text);
        statusBox.text = "User logged in as: " + userID.text;
        //TrackLogInEvent();
    }

    public void userLogout()
    {
        MoEngageClient.Logout();
        statusBox.text = "User logged out";
        //TrackLogOutEvent();
    }

    //public void TrackLogInEvent()
    //{
    //    Properties isLoggedInPro = new Properties().AddBoolean("booleanAttr", true);

    //    MoEngageClient.TrackEvent("isLoggedIn", isLoggedInPro);
    //}

    //public void TrackLogOutEvent()
    //{
    //    Properties isLoggedOutPro = new Properties().AddBoolean("booleanAttr", true);

    //    MoEngageClient.TrackEvent("isLoggedOut", isLoggedOutPro);
    //}
}
