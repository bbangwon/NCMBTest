using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class DataFetch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FetchScoreList(10);

    }

    private void FetchScoreList(int higherThan)
    {
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("PlayerData");
        query.WhereGreaterThan("Score", higherThan);
        query.FindAsync((List<NCMBObject> objList, NCMBException e) =>
        {
            if (e != null)
            {
                //오류시 처리
            }
            else
            {
                foreach (NCMBObject obj in objList)
                {
                    Debug.Log("playerName:" + obj["PlayerName"] +
                              ", Score: " + obj["Score"] +
                              ", Coin: " + obj["Coin"]);
                }
            }
        });
    }
	

}
