using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class DataSave : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SavePlayerData("Mina", 3, 60);

    }
	
    public void SavePlayerData(string playerName, int score, int coin)
    {
        NCMBObject obj = new NCMBObject("PlayerData");

        obj.Add("PlayerName", playerName);
        obj.Add("Score", score);
        obj.Add("Coin", coin);

        obj.SaveAsync((NCMBException e) =>
        {
            if( e != null)
            {
                //오류처리
                Debug.Log("저장 실패. 통신 환경을 확인하십시오.");
            }
            else
            {
                //성공시 처리
                Debug.Log("저장 성공");
            }

        });
    }
}
