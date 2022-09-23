using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersNickName : MonoBehaviour
{
    public string nickname,saveNickname;
    public Text inputText,loadedName;
    
    // Update is called once per frame
    void Update()
    {
        nickname = PlayerPrefs.GetString("name"," ");
        loadedName.text = nickname;    
    }

    public void SetNickname()
    {
        saveNickname = input.text;
        PlayerPrefs.SetString("name",saveNickname);
    }
}
